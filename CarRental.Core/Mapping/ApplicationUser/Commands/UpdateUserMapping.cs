using CarRental.Core.Features.ApplicationUser.Commands.Models;
using CarRental.Data.Entities.Identity;

namespace CarRental.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void UpdateUserMapping()
        {
            CreateMap<EditUserCommand, User>();
        }
    }
}
