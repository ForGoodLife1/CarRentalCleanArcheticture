namespace CarRental.Core.Feautres.PatientCQRS.Queries.ResponseQueries
{
    public class GetListCustomerResponse
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string ContactInformation { get; set; } = null!;

        public string DriverLicenseNumber { get; set; }

    }
}
