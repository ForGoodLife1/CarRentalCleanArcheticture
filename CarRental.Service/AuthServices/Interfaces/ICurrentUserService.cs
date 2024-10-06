﻿using CarRental.Data.Entities.Identity;

namespace CarRental.Service.AuthServices.Interfaces
{
    public interface ICurrentUserService
    {
        public Task<User> GetUserAsync();
        public int GetUserId();
        public Task<List<string>> GetCurrentUserRolesAsync();
    }
}