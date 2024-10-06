using CarRental.Data.Entities.Identity;

namespace CarRental.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
