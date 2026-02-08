using HoaP.Application.Interfaces;

namespace HoaP.Application.Services
{
    public class FileUploadService : IFileUploadService
    {
        public async Task<byte[]> HandleFileUploadAsync(Stream fileStream, long fileSize, long maxFileSize = 5242880)
        {
            if (fileSize > maxFileSize)
            {
                throw new InvalidOperationException("Soubor je příliš velký.");
            }

            using var memoryStream = new MemoryStream();
            await fileStream.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
