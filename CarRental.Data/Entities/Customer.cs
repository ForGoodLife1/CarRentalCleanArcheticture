using CarRental.Data.Commons;

namespace CarRental.Data.Entities;

public partial class Customer : GeneralLocalizableEntity
{
    public int CustomerId { get; set; }

    public string NameAr { get; set; } = null!;
    public string NameEn { get; set; } = null!;

    public string ContactInformation { get; set; } = null!;

    public string DriverLicenseNumber { get; set; } = null!;

    public virtual ICollection<RentalBooking> RentalBookings { get; set; } = new List<RentalBooking>();
}
