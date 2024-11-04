using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Service.Implementations
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository=vehicleRepository;
        }

        public async Task<string> AddAsync(Vehicle vehicle)
        {
            await _vehicleRepository.AddAsync(vehicle);
            return "Success";
        }

        public async Task<string> DeleteAsync(Vehicle vehicle)
        {
            await _vehicleRepository.DeleteAsync(vehicle);
            return "Success";

        }

        public async Task<string> EditAsync(Vehicle vehicle)
        {
            await _vehicleRepository.UpdateAsync(vehicle);
            return "Success";

        }

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            var vehicle = _vehicleRepository.GetTableNoTracking()
                                            .Include(x => x.CarCategory)
                                            .Include(x => x.FuelType)
                                            .Where(x => x.VehicleId.Equals(id))
                                            .FirstOrDefault();
            return vehicle;
        }

        public async Task<List<Vehicle>> GetVehiclesListAsync()
        {
            return await _vehicleRepository.GetAllVehiclesAsync();

        }

        public IQueryable<Vehicle> GetVehiclesQuerable()
        {
            return _vehicleRepository.GetTableNoTracking()
                                     .Include(x => x.CarCategory)
                                     .Include(x => x.FuelType)
                                     .AsQueryable();
        }




    }
}
