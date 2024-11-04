using CarRental.Core.Feautres.Vehicle.Commands.ModelsCommands;
using CarRental.Core.Resources;
using CarRental.Service.Abstracts;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CarRental.Core.Feautres.Vehicle.Commands.ValidatiorsCommands


{
    public class EditValidatior : AbstractValidator<AddVehicleModel>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public EditValidatior(IVehicleService vehicleService,
                              IStringLocalizer<SharedResources> localizer)
        {
            _vehicleService=vehicleService;
            _localizer=localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Make)
               .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
               .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
               .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.Model)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);




        }
        public void ApplyCustomValidationsRules()
        {
            /*
                        RuleFor(x => x.NameAr)
                             .MustAsync(async (Key, CancellationToken) => !await _vehicleService.IsNameArExist(Key))
                             .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
                        RuleFor(x => x.NameEn)
                           .MustAsync(async (Key, CancellationToken) => !await _vehicleService.IsNameEnExist(Key))
                           .WithMessage(_localizer[SharedResourcesKeys.IsExist]);*/


        }
    }
}
