using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class VehicleCategoryRepository : GenericRepositoryAsync<VehicleCategory>, IVehicleCategoryRepository
    {
        #region Fields
        private DbSet<VehicleCategory> VehicleCategorys;
        #endregion

        #region Constructors
        public VehicleCategoryRepository(CarRentalContext dbContext) : base(dbContext)
        {
            VehicleCategorys = dbContext.Set<VehicleCategory>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
