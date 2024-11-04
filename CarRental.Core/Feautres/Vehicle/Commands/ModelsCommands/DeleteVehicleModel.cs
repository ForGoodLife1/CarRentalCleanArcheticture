using CarRental.Core.Bases;
using MediatR;

namespace CarRental.Core.Feautres.Vehicle.Commands.ModelsCommands
{
    public class DeleteVehicleModel : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteVehicleModel(int id)
        {
            Id = id;
        }
    }
}

