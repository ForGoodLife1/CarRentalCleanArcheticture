using CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using CarRental.Data.Entities;


namespace CarRental.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void GetCustomerByIDMapping()
        {
            CreateMap<Customer, GetCustomerByIDResponse>();
        }
    }
}
