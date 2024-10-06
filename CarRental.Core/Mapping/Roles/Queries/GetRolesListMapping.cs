using CarRental.Core.Features.Authorization.Quaries.Results;
using CarRental.Data.Entities.Identity;

namespace CarRental.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRolesListMapping()
        {
            CreateMap<Role, GetRolesListResult>();
        }
    }
}
