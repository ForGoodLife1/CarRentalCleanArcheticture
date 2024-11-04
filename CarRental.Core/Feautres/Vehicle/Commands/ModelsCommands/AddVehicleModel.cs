using CarRental.Core.Bases;
using MediatR;

namespace CarRental.Core.Feautres.Vehicle.Commands.ModelsCommands
{
    public class AddVehicleModel : IRequest<Response<string>>
    {


        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }
    }
}
