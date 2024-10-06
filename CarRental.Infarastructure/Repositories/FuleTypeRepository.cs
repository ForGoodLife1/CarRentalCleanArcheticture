using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class FuleTypeRepository : GenericRepositoryAsync<FuleType>, IFuleTypeRepository
    {
        #region Fields
        private DbSet<FuleType> FuleTypes;
        #endregion

        #region Constructors
        public FuleTypeRepository(CarRentalContext dbContext) : base(dbContext)
        {
            FuleTypes = dbContext.Set<FuleType>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
