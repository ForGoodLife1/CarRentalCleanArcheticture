using CarRental.Core.Feautres.Vehicle.Queries.ResponseQueries;
using CarRental.Data.Entities;

namespace CarRental.Core.Mapping.VehicleMapping
{
    public partial class VehicleProfile
    {
        public void GetVehicleByIdMapping()
        {
            CreateMap<Vehicle, GetVehicleByIdResponse>();
        }
    }
}
