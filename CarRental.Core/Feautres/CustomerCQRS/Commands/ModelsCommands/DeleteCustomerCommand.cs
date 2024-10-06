using CarRental.Core.Bases;
using MediatR;

namespace CarRental.Core.Feautres.CustomerCQRS.Commands.ModelsCommands
{
    public class DeleteCustomerCommand : IRequest<Response<string>>
    {
        public DeleteCustomerCommand(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
