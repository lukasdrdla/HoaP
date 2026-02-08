namespace HoaP.Application.Interfaces
{
    public interface IFileUploadService
    {
        Task<byte[]> HandleFileUploadAsync(Stream fileStream, long fileSize, long maxFileSize = 5 * 1024 * 1024);
    }
}
