using CarRental.Data.Entities;
using CarRental.Data.Enums;

namespace CarRental.Service.Abstracts
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetCustomersListAsync();
        public Task<Customer> GetCustomerByIDWithIncludeAsync(int id);
        public Task<Customer> GetByIDAsync(int id);
        public Task<string> AddAsync(Customer Customer);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(Customer Customer);
        public Task<string> DeleteAsync(Customer Customer);
        public IQueryable<Customer> GetCustomersQuerable();
        public IQueryable<Customer> GetCustomersByRentalBookingIDQuerable(int DID);
        public IQueryable<Customer> FilterCustomerPaginatedQuerable(CustomerOrderingEnum orderingEnum, string search);
    }
}
