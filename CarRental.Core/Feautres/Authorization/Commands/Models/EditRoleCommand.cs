using CarRental.Core.Bases;
using CarRental.Data.Requests;
using MediatR;

namespace CarRental.Core.Features.Authorization.Commands.Models
{
    public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
    {

    }
}
