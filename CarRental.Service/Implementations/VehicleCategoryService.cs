using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Service.Implementations
{
    public class VehicleCategoryService : IVehicleCategoryService
    {
        private readonly IVehicleCategoryRepository _vehicleCategoryRepository;

        public VehicleCategoryService(IVehicleCategoryRepository vehicleCategoryRepository)
        {
            _vehicleCategoryRepository=vehicleCategoryRepository;
        }

        public async Task<VehicleCategory> GetVehicleCategoryById(int id)
        {
            var vehicleCategory = await _vehicleCategoryRepository.GetTableNoTracking().Where(x => x.CategoryId.Equals(id))
                                                                 .Include(x => x.Vehicles).FirstOrDefaultAsync();
            return vehicleCategory;
        }

        public async Task<bool> IsVehicleCategoryIdExist(int VehicleCategoryId)
        {
            return await _vehicleCategoryRepository.GetTableNoTracking().AnyAsync(x => x.CategoryId.Equals(VehicleCategoryId));
        }
    }
}
