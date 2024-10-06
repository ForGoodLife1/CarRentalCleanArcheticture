using CarRental.Core.Feautres.PatientCQRS.Queries.ResponseQueries;
using CarRental.Data.Entities;


namespace CarRental.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void GetListCustomerMapping()
        {
            CreateMap<Customer, GetListCustomerResponse>();
        }
    }
}
