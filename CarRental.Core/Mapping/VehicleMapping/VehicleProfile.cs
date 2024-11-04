using AutoMapper;

namespace CarRental.Core.Mapping.VehicleMapping
{
    public partial class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            GetListVehicleMapping();
            GetVehicleByIdMapping();
        }
    }
}
