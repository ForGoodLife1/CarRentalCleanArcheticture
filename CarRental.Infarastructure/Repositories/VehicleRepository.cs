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
        private DbSet<Vehicle> _vehicles;
        #endregion

        #region Constructors
        public VehicleRepository(CarRentalContext dbContext) : base(dbContext)
        {
            _vehicles = dbContext.Set<Vehicle>();
        }

        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            return await _vehicles.Include(x => x.CarCategory)
                                  .Include(x => x.FuelType).ToListAsync();
        }


        #endregion

        #region Handle Functions

        #endregion
    }
}
