using CarRental.Data.Entities;

namespace CarRental.Service.Abstracts
{
    public interface IVehicleCategoryService
    {
        public Task<VehicleCategory> GetVehicleCategoryById(int id);
        public Task<bool> IsVehicleCategoryIdExist(int VehicleCategoryId);
    }
}
