using CarRental.Core.Bases;
using CarRental.Data.Results;
using MediatR;

namespace CarRental.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
