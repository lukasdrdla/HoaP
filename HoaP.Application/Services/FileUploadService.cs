using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using Microsoft.AspNetCore.Components.Forms;

namespace HoaP.Application.Services
{
    public class FileUploadService : IFileUploadService
    {
        public async Task<byte[]> HandleFileUploadAsync(IBrowserFile file, long maxFileSize = 5242880)
        {
            if (file.Size > maxFileSize)
            {
                throw new InvalidOperationException("Soubor je příliš velký.");
            }

            using (var memoryStream = new MemoryStream())
            {
                await file.OpenReadStream().CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
