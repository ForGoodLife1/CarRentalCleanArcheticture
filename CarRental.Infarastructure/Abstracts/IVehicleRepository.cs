using CarRental.Data.Entities;
using CarRental.Infarastructure.InfrastructureBases;

namespace CarRental.Infarastructure.Abstracts
{
    public interface IVehicleRepository : IGenericRepositoryAsync<Vehicle>
    {
    }
}
