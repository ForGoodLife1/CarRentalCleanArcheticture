
using CarRental.Core.Bases;
using CarRental.Data.Results;
using MediatR;

namespace CarRental.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
