using CarRental.Core.Bases;
using CarRental.Data.Requests;
using MediatR;

namespace CarRental.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
