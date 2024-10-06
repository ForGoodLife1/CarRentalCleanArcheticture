using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class CustomerRepository : GenericRepositoryAsync<Customer>, ICustomerRepository
    {
        #region Fields
        private DbSet<Customer> _customers;
        #endregion

        #region Constructors
        public CustomerRepository(CarRentalContext dbContext) : base(dbContext)
        {
            _customers = dbContext.Set<Customer>();
        }
        #endregion

        #region Handle Functions
        public async Task<List<Customer>> GetCustomersListAsync()
        {
            return await _customers.Include(x => x.RentalBookings).ToListAsync();
        }

        #endregion
    }
}
