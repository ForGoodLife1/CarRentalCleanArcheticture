using Microsoft.AspNetCore.Http;

namespace CarRental.Service.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
