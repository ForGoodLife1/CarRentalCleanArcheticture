using CarRental.Core.Bases;
using CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using MediatR;

namespace CarRental.Core.Feautres.CustomerCQRS.Queries.ModelsQueries
{
    public class GetCustomerByIDQuery : IRequest<Response<GetCustomerByIDResponse>>
    {
        public int ID { get; set; }
        public GetCustomerByIDQuery(int id)
        {
            ID=id;
        }
    }
}
