namespace CarRental.Core.Feautres.Vehicle.Queries.ResponseQueries
{
    public class GetVehicleByIdResponse
    {
        public int VehicleId { get; set; }

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }
    }
}
