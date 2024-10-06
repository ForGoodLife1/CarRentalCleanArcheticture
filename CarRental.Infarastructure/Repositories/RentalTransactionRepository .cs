using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class RentalTransactionRepository : GenericRepositoryAsync<RentalTransaction>, IRentalTransactionRepository
    {
        #region Fields
        private DbSet<RentalTransaction> RentalTransactions;
        #endregion

        #region Constructors
        public RentalTransactionRepository(CarRentalContext dbContext) : base(dbContext)
        {
            RentalTransactions = dbContext.Set<RentalTransaction>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
