using AutoMapper;

namespace CarRental.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            GetListCustomerMapping();
            GetCustomerByIDMapping();
            AddCustomerCommandMapping();
            EditCustomerCommandMapping();
        }
    }
}
