using System.Security.Cryptography;
using System.Text;
using HoaP.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace HoaP.Infrastructure.Services
{
    public class AesEncryptionService : IEncryptionService
    {
        private readonly byte[] _key;

        public AesEncryptionService(IConfiguration configuration)
        {
            var keyString = configuration["Encryption:Key"]
                ?? throw new InvalidOperationException(
                    "Encryption key not configured. Set Encryption:Key in appsettings.json (must be 32 characters for AES-256).");

            _key = Encoding.UTF8.GetBytes(keyString);
            if (_key.Length != 32)
                throw new InvalidOperationException("Encryption key must be exactly 32 characters (256 bits) for AES-256.");
        }

        public string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                return plainText;

            using var aes = Aes.Create();
            aes.Key = _key;
            aes.GenerateIV();

            using var encryptor = aes.CreateEncryptor();
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            var result = new byte[aes.IV.Length + cipherBytes.Length];
            Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
            Buffer.BlockCopy(cipherBytes, 0, result, aes.IV.Length, cipherBytes.Length);

            return Convert.ToBase64String(result);
        }

        public string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                return cipherText;

            var fullCipher = Convert.FromBase64String(cipherText);

            using var aes = Aes.Create();
            aes.Key = _key;

            var iv = new byte[aes.BlockSize / 8];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, cipher.Length);

            aes.IV = iv;

            using var decryptor = aes.CreateDecryptor();
            var plainBytes = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);

            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
