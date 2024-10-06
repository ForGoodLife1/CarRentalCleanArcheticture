using CarRental.Core.Bases;
using CarRental.Core.Features.Authorization.Quaries.Results;
using MediatR;

namespace CarRental.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResult>>
    {
        public int Id { get; set; }
    }
}
