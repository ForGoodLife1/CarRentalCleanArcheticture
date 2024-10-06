using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class VehicleReturnRepository : GenericRepositoryAsync<VehicleReturn>, IVehicleReturnRepository
    {

        #region Fields
        private DbSet<VehicleReturn> VehicleReturns;
        #endregion

        #region Constructors
        public VehicleReturnRepository(CarRentalContext dbContext) : base(dbContext)
        {
            VehicleReturns = dbContext.Set<VehicleReturn>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
