using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace HoaP.Application.Interfaces
{
    public interface IFileUploadService
    {
        Task<byte[]> HandleFileUploadAsync(IBrowserFile file, long maxFileSize = 5 * 1024 * 1024);

    }
}
