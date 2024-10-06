using AutoMapper;
using CarRental.Core.Bases;
using CarRental.Core.Feautres.CustomerCQRS.Queries.ModelsQueries;
using CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using CarRental.Core.Feautres.PatientCQRS.Queries.ModelsQueries;
using CarRental.Core.Feautres.PatientCQRS.Queries.ResponseQueries;
using CarRental.Core.Resources;
using CarRental.Core.Wrappers;
using CarRental.Data.Entities;
using CarRental.Service.Abstracts;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;

namespace CarRental.Core.Feautres.CustomerCQRS.Queries.HandlersQueries
{

    public class CustomerHandler : ResponseHandler,
                                   IRequestHandler<GetListCustomerQuery, Response<List<GetListCustomerResponse>>>,
                                    IRequestHandler<GetCustomerByIDQuery, Response<GetCustomerByIDResponse>>,
                                     IRequestHandler<GetListCustomerPaginatedQuery, PaginatedResult<GetCustomerPaginatedListResopnse>>
    {
        private readonly ICustomerService _CustomerService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;

        public CustomerHandler(ICustomerService customerService,
                               IMapper mapper,
                               IStringLocalizer<SharedResources> stringLocalizer) : base(stringLocalizer)
        {
            _CustomerService=customerService;
            _mapper=mapper;
            _stringLocalizer=stringLocalizer;
        }


        public async Task<Response<List<GetListCustomerResponse>>> Handle(GetListCustomerQuery request, CancellationToken cancellationToken)
        {
            var paitentList = await _CustomerService.GetCustomersListAsync();
            var paitentListMapper = _mapper.Map<List<GetListCustomerResponse>>(paitentList);
            var result = Success(paitentListMapper);
            result.Meta = new { Count = paitentListMapper.Count() };
            return result;
        }

        public async Task<Response<GetCustomerByIDResponse>> Handle(GetCustomerByIDQuery request, CancellationToken cancellationToken)
        {
            var customer = await _CustomerService.GetByIDAsync(request.ID);
            if (customer==null) return NotFound<GetCustomerByIDResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            var result = _mapper.Map<GetCustomerByIDResponse>(customer);
            return Success(result);
        }

        public async Task<PaginatedResult<GetCustomerPaginatedListResopnse>> Handle(GetListCustomerPaginatedQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Customer, GetCustomerPaginatedListResopnse>> expression = e => new GetCustomerPaginatedListResopnse(e.CustomerId, e.Localize(e.NameAr, e.NameEn), e.ContactInformation, e.DriverLicenseNumber);
            var querable = _CustomerService.GetCustomersQuerable();
            var FilterQuery = _CustomerService.FilterCustomerPaginatedQuerable(request.OrderBy, request.Search);
            var PaginatedList = await FilterQuery.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };
            return PaginatedList;
        }
    }

}
