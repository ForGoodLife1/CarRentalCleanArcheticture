using CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using CarRental.Core.Wrappers;
using CarRental.Data.Enums;
using MediatR;

namespace CarRental.Core.Feautres.PatientCQRS.Queries.ModelsQueries
{
    public class GetListCustomerPaginatedQuery : IRequest<PaginatedResult<GetCustomerPaginatedListResopnse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public CustomerOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
