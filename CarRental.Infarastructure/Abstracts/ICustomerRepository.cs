using CarRental.Data.Entities;
using CarRental.Infarastructure.InfrastructureBases;



namespace CarRental.Infarastructure.Abstracts
{
    public interface ICustomerRepository : IGenericRepositoryAsync<Customer>
    {
        public Task<List<Customer>> GetCustomersListAsync();
    }
}
