using CarRental.Core.Bases;
using CarRental.Data.Results;
using MediatR;

namespace CarRental.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
