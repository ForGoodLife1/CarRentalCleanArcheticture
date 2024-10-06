using CarRental.Core.Features.ApplicationUser.Queries.Results;
using CarRental.Data.Entities.Identity;

namespace CarRental.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserPaginationMapping()
        {
            CreateMap<User, GetUserPaginationReponse>();

        }
    }
}