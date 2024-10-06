namespace CarRental.Core.Feautres.CustomerCQRS.Queries.ResponseQueries
{
    public class GetCustomerPaginatedListResopnse
    {
        public GetCustomerPaginatedListResopnse(int customerId, string name, string contactInformation, string driverLicenseNumber)
        {
            CustomerId=customerId;
            Name=name;
            ContactInformation=contactInformation;
            DriverLicenseNumber=driverLicenseNumber;
        }

        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string ContactInformation { get; set; } = null!;

        public string DriverLicenseNumber { get; set; } = null;
    }
}
