using CarRental.Core.Feautres.CustomerCQRS.Commands.ModelsCommands;
using CarRental.Data.Entities;

namespace CarRental.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void AddCustomerCommandMapping()
        {
            CreateMap<Customer, AddCustomerCommand>();
        }
    }
}
