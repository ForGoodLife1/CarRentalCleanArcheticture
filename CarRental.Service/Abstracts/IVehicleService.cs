using CarRental.Data.Entities;

namespace CarRental.Service.Abstracts
{
    public interface IVehicleService
    {
        public Task<List<Vehicle>> GetVehiclesListAsync();
        public Task<Vehicle> GetVehicleByIdAsync(int id);
        public Task<string> AddAsync(Vehicle vehicle);

        public Task<string> EditAsync(Vehicle vehicle);
        public Task<string> DeleteAsync(Vehicle vehicle);
        public IQueryable<Vehicle> GetVehiclesQuerable();


    }
}
