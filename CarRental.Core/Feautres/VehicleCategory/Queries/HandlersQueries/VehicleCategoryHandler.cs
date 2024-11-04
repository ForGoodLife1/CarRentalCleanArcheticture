using AutoMapper;
using CarRental.Core.Bases;
using CarRental.Core.Feautres.VehicleCategory.Queries.ModelsQueries;
using CarRental.Core.Feautres.VehicleCategory.Queries.ResponseQueries;
using CarRental.Core.Resources;
using CarRental.Service.Abstracts;
using MediatR;
using Microsoft.Extensions.Localization;

namespace CarRental.Core.Feautres.VehicleCategory.Queries.HandlersQueries
{
    public class VehicleCategoryHandler : ResponseHandler, IRequestHandler<GetVehicleCategoryModel, Response<GetVehicleCategoryResponse>>
    {
        private readonly IVehicleCategoryService _vehicleCategoryService;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;

        public VehicleCategoryHandler(IVehicleCategoryService vehicleCategoryService,
                                      IStringLocalizer<SharedResources> stringLocalizer,
                                      IMapper mapper) : base(stringLocalizer)
        {
            _vehicleCategoryService=vehicleCategoryService;
            _stringLocalizer=stringLocalizer;
            _mapper=mapper;
        }

        public async Task<Response<GetVehicleCategoryResponse>> Handle(GetVehicleCategoryModel request, CancellationToken cancellationToken)
        {
            //service Get By Id include St sub ins
            var response = await _vehicleCategoryService.GetVehicleCategoryById(request.Id);
            //check Is Not exist
            if (response == null) return NotFound<GetVehicleCategoryResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            //mapping 
            var mapper = _mapper.Map<GetVehicleCategoryResponse>(response);


            // Log.Information($"Get Department By Id {request.Id}!");
            //return response
            return Success(mapper);

        }
    }
}
