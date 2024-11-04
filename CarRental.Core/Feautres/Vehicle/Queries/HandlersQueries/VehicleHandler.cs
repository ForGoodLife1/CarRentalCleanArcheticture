using AutoMapper;
using CarRental.Core.Bases;
using CarRental.Core.Feautres.Vehicle.Queries.ModelsQueries;
using CarRental.Core.Feautres.Vehicle.Queries.ResponseQueries;
using CarRental.Core.Resources;
using CarRental.Service.Abstracts;
using MediatR;
using Microsoft.Extensions.Localization;

namespace CarRental.Core.Feautres.Vehicle.Queries.HandlersQueries
{
    public class VehicleHandler : ResponseHandler,
        IRequestHandler<GetListVehicleQuery, Response<List<GetListVehicleResponse>>>,
        IRequestHandler<GetVehicleByIdQuery, Response<GetVehicleByIdResponse>>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;

        public VehicleHandler(IVehicleService vehicleService, IMapper mapper, IStringLocalizer<SharedResources> stringLocalizer) : base(stringLocalizer)
        {
            _vehicleService=vehicleService;
            _mapper=mapper;
            _stringLocalizer=stringLocalizer;
        }

        public async Task<Response<List<GetListVehicleResponse>>> Handle(GetListVehicleQuery request, CancellationToken cancellationToken)
        {
            var VehicleList = await _vehicleService.GetVehiclesListAsync();
            var VehicleListMapper = _mapper.Map<List<GetListVehicleResponse>>(VehicleList);
            var result = Success(VehicleListMapper);
            result.Meta=new { Count = VehicleListMapper.Count() };
            return result;
        }

        public async Task<Response<GetVehicleByIdResponse>> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            var Vehicle = await _vehicleService.GetVehicleByIdAsync(request.Id);
            if (Vehicle==null) return NotFound<GetVehicleByIdResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            var result = _mapper.Map<GetVehicleByIdResponse>(Vehicle);
            return Success(result);
        }
    }
}
