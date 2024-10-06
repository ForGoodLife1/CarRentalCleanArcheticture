
using CarRental.Core.Bases;
using CarRental.Core.Feautres.PatientCQRS.Queries.ResponseQueries;
using MediatR;

namespace CarRental.Core.Feautres.PatientCQRS.Queries.ModelsQueries
{
    public class GetListCustomerQuery : IRequest<Response<List<GetListCustomerResponse>>>
    {
    }
}
