using CarRental.Service.Abstracts;
using CarRental.Service.AuthServices.Implementations;
using CarRental.Service.AuthServices.Interfaces;
using CarRental.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IFuleTypeService, FuleTypeService>();
            services.AddTransient<IMaintenanceService, MaintenanceService>();
            services.AddTransient<IRentalBookingService, RentalBookingService>();
            services.AddTransient<IRentalTransactionService, RentalTransactionService>();
            services.AddTransient<IVehicleCategoryService, VehicleCategoryService>();
            services.AddTransient<IVehicleReturnService, VehicleReturnService>();
            services.AddTransient<IVehicleService, VehicleService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IFileService, FileService>();
            return services;

        }

    }
}
