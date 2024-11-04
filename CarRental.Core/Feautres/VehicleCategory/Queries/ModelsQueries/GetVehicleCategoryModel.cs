

using CarRental.Core.Bases;
using CarRental.Core.Feautres.VehicleCategory.Queries.ResponseQueries;
using MediatR;

namespace CarRental.Core.Feautres.VehicleCategory.Queries.ModelsQueries
{
    public class GetVehicleCategoryModel : IRequest<Response<GetVehicleCategoryResponse>>
    {
        public GetVehicleCategoryModel(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
