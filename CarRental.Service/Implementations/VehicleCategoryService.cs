using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Service.Abstracts;

namespace CarRental.Service.Implementations
{
    public class VehicleCategoryService : IVehicleCategoryService
    {
        private readonly IVehicleCategoryRepository _vehicleCategoryRepository;

        public VehicleCategoryService(IVehicleCategoryRepository vehicleCategoryRepository)
        {
            _vehicleCategoryRepository=vehicleCategoryRepository;
        }

        public Task<VehicleCategory> GetVehicleCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsVehicleCategoryIdExist(int VehicleCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
