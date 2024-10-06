namespace CarRental.Data.Entities;


public partial class RentalBooking
{
    public int BookingId { get; set; }

    public int CustomerId { get; set; }

    public int VehicleId { get; set; }

    public DateOnly RentalStartDate { get; set; }

    public DateOnly RentalEndDate { get; set; }

    public string PickupLocation { get; set; } = null!;

    public string DropoffLocation { get; set; } = null!;

    public byte InitialRentalDays { get; set; }

    public decimal RentalPricePerDay { get; set; }

    public decimal InitialTotalDueAmount { get; set; }

    public string? InitialCheckNotes { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

    public virtual Vehicle Vehicle { get; set; } = null!;
}
