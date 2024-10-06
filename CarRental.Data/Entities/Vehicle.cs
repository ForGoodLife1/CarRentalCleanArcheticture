namespace CarRental.Data.Entities;


public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public int Mileage { get; set; }

    public int FuelTypeId { get; set; }

    public string PlateNumber { get; set; } = null!;

    public int CarCategoryId { get; set; }

    public decimal RentalPricePerDay { get; set; }

    public bool IsAvailableForRent { get; set; }

    public virtual VehicleCategory CarCategory { get; set; } = null!;

    public virtual FuleType FuelType { get; set; } = null!;

    public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<RentalBooking> RentalBookings { get; set; } = new List<RentalBooking>();
}
