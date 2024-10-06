using CarRental.Data.Entities;
using CarRental.Data.Enums;
using CarRental.Infarastructure.Abstracts;
using CarRental.Service.Abstracts;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace CarRental.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly ICustomerRepository _CustomerRepository;
        #endregion

        #region constructors
        public CustomerService(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }


        #endregion
        #region Handle Functions
        public async Task<List<Customer>> GetCustomersListAsync()
        {
            return await _CustomerRepository.GetCustomersListAsync();
        }

        public async Task<Customer> GetCustomerByIDWithIncludeAsync(int id)
        {
            // var Customer = await _CustomerRepository.GetByIdAsync(id);
            var Customer = _CustomerRepository.GetTableNoTracking()
                                          .Include(x => x.RentalBookings)
                                          .Where(x => x.CustomerId.Equals(id))
                                          .FirstOrDefault();
            return Customer;
        }

        public async Task<string> AddAsync(Customer Customer)
        {
            //Added Customer
            await _CustomerRepository.AddAsync(Customer);
            return "Success";
        }

        public async Task<bool> IsNameArExist(string nameAr)
        {
            //Check if the name is Exist Or not
            var Customer = _CustomerRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr)).FirstOrDefault();
            if (Customer == null) return false;
            return true;
        }

        public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            //Check if the name is Exist Or not
            var Customer = await _CustomerRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr) & !x.CustomerId.Equals(id)).FirstOrDefaultAsync();
            if (Customer == null) return false;
            return true;
        }

        public async Task<string> EditAsync(Customer Customer)
        {
            await _CustomerRepository.UpdateAsync(Customer);
            return "Success";
        }

        public async Task<string> DeleteAsync(Customer Customer)
        {
            var trans = _CustomerRepository.BeginTransaction();
            try
            {
                await _CustomerRepository.DeleteAsync(Customer);
                await trans.CommitAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                Log.Error(ex.Message);
                return "Falied";
            }

        }

        public async Task<Customer> GetByIDAsync(int id)
        {
            var Customer = await _CustomerRepository.GetByIdAsync(id);
            return Customer;
        }

        public IQueryable<Customer> GetCustomersQuerable()
        {
            return _CustomerRepository.GetTableNoTracking().Include(x => x.RentalBookings).AsQueryable();
        }

        public IQueryable<Customer> FilterCustomerPaginatedQuerable(CustomerOrderingEnum orderingEnum, string search)
        {
            var querable = _CustomerRepository.GetTableNoTracking().Include(x => x.RentalBookings).AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.NameAr.Contains(search) || x.ContactInformation.Contains(search));
            }
            switch (orderingEnum)
            {
                case CustomerOrderingEnum.CustomerId:
                    querable = querable.OrderBy(x => x.CustomerId);
                    break;
                case CustomerOrderingEnum.Name:
                    querable = querable.OrderBy(x => x.NameAr);
                    break;
                case CustomerOrderingEnum.ContactInformation:
                    querable = querable.OrderBy(x => x.ContactInformation);
                    break;
                case CustomerOrderingEnum.DriverLicenseNumber:
                    querable = querable.OrderBy(x => x.DriverLicenseNumber);
                    break;
            }

            return querable;
        }

        public async Task<bool> IsNameEnExist(string nameEn)
        {
            //Check if the name is Exist Or not
            var Customer = _CustomerRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn)).FirstOrDefault();
            if (Customer == null) return false;
            return true;
        }

        public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            //Check if the name is Exist Or not
            var Customer = await _CustomerRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn) & !x.CustomerId.Equals(id)).FirstOrDefaultAsync();
            if (Customer == null) return false;
            return true;
        }

        public IQueryable<Customer> GetCustomersByRentalBookingIDQuerable(int DID)

        {

            return _CustomerRepository.GetTableNoTracking().Where(x => x.RentalBookings.Equals(DID)).AsQueryable();
        }


        #endregion
    }
}
