using AutoMapper;
using CarRental.Core.Bases;
using CarRental.Core.Feautres.Vehicle.Commands.ModelsCommands;
using CarRental.Core.Resources;
using CarRental.Service.Abstracts;
using MediatR;
using Microsoft.Extensions.Localization;

namespace CarRental.Core.Feautres.Vehicle.Commands.HandlersCommands
{
    public class VehicleCommandHandler : ResponseHandler,
                                      IRequestHandler<AddVehicleModel, Response<string>>,
                                        IRequestHandler<EditVehicleModel, Response<string>>,
                                         IRequestHandler<DeleteVehicleModel, Response<string>>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public VehicleCommandHandler(IVehicleService vehicleService, IMapper mapper,
            IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _vehicleService=vehicleService;
            _mapper=mapper;
            _localizer=localizer;
        }

        public async Task<Response<string>> Handle(AddVehicleModel request, CancellationToken cancellationToken)
        {
            //mapping Between request and Vehicle
            var Vehiclemapper = _mapper.Map<CarRental.Data.Entities.Vehicle>(request);
            //add
            var result = await _vehicleService.AddAsync(Vehiclemapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();

        }

        public async Task<Response<string>> Handle(EditVehicleModel request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var vehicle = await _vehicleService.GetVehicleByIdAsync(request.VehicleId);
            //return NotFound
            if (vehicle == null) return NotFound<string>();
            //mapping Between request and vehicle
            var vehiclemapper = _mapper.Map(request, vehicle);
            //Call service that make Edit
            var result = await _vehicleService.EditAsync(vehiclemapper);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteVehicleModel request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var vehicle = await _vehicleService.GetVehicleByIdAsync(request.Id);
            //return NotFound
            if (vehicle == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _vehicleService.DeleteAsync(vehicle);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}
