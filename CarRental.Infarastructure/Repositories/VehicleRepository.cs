using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class VehicleRepository : GenericRepositoryAsync<Vehicle>, IVehicleRepository
    {
        #region Fields
        private DbSet<Vehicle> Vehicles;
        #endregion

        #region Constructors
        public VehicleRepository(CarRentalContext dbContext) : base(dbContext)
        {
            Vehicles = dbContext.Set<Vehicle>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
