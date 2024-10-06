using CarRental.Core.Bases;
using CarRental.Data.Results;
using MediatR;

namespace CarRental.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
