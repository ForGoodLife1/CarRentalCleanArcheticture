﻿using CarRental.Core.Bases;
using MediatR;

namespace CarRental.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}