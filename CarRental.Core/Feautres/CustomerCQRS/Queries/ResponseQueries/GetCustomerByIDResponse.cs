namespace CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries
{
    public class GetCustomerByIDResponse
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string ContactInformation { get; set; } = null!;

        public string DriverLicenseNumber { get; set; }

    }

}
