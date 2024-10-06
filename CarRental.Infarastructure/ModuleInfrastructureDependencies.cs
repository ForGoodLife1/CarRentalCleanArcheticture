using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.InfrastructureBases;
using CarRental.Infarastructure.Repositories;
using CarRental.Infrustructure.Abstracts;
using CarRental.Infrustructure.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarRental.Infarastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IVehicleRepository, VehicleRepository>();
            services.AddTransient<IFuleTypeRepository, FuleTypeRepository>();
            services.AddTransient<IMaintenanceRepository, MaintenanceRepository>();
            services.AddTransient<IRentalBookingRepository, RentalBookingRepository>();
            services.AddTransient<IRentalTransactionRepository, RentalTransactionRepository>();
            services.AddTransient<IVehicleCategoryRepository, VehicleCategoryRepository>();
            services.AddTransient<IVehicleReturnRepository, VehicleReturnRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;

        }

    }
}
