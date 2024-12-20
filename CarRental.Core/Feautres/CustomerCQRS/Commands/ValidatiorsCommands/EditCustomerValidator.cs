﻿using CarRental.Core.Feautres.CustomerCQRS.Commands.ModelsCommands;
using CarRental.Core.Resources;
using CarRental.Service.Abstracts;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CarRental.Core.Feautres.CustomerCQRS.Commands.ValidatiorsCommands
{
    public class EditCustomerValidator : AbstractValidator<AddCustomerCommand>
    {
        #region Fields
        private readonly ICustomerService _CustomerService;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion
        #region Constructors
        public EditCustomerValidator(ICustomerService CustomerService,
                                    IStringLocalizer<SharedResources> localizer)
        {

            _CustomerService = CustomerService;
            _localizer = localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        #endregion
        #region Action
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.NameAr)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.ContactInformation)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

        }
        public void ApplyCustomValidationsRules()
        {

            RuleFor(x => x.NameAr)
                 .MustAsync(async (Key, CancellationToken) => !await _CustomerService.IsNameArExist(Key))
                 .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
            RuleFor(x => x.NameEn)
               .MustAsync(async (Key, CancellationToken) => !await _CustomerService.IsNameEnExist(Key))
               .WithMessage(_localizer[SharedResourcesKeys.IsExist]);


        }
        #endregion
    }
}
