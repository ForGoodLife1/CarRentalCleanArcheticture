﻿using AutoMapper;

namespace CarRental.Core.Mapping.Roles
{
    public partial class RoleProfile : Profile
    {
        public RoleProfile()
        {
            GetRolesListMapping();
            GetRoleByIdMapping();
        }
    }
}
