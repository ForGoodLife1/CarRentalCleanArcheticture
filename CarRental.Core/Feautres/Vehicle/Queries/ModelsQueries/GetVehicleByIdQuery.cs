using CarRental.Core.Bases;
using CarRental.Core.Feautres.Vehicle.Queries.ResponseQueries;
using MediatR;

namespace CarRental.Core.Feautres.Vehicle.Queries.ModelsQueries
{
    public class GetVehicleByIdQuery : IRequest<Response<GetVehicleByIdResponse>>
    {
        public int Id { get; set; }
        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
