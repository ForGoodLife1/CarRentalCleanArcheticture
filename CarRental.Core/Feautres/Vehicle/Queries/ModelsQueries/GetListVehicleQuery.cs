
using CarRental.Core.Bases;
using CarRental.Core.Feautres.Vehicle.Queries.ResponseQueries;
using MediatR;

namespace CarRental.Core.Feautres.Vehicle.Queries.ModelsQueries
{
    public class GetListVehicleQuery : IRequest<Response<List<GetListVehicleResponse>>>
    {
    }
}
