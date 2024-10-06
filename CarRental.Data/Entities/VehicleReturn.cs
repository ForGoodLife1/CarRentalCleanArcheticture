namespace CarRental.Data.Entities;

public partial class VehicleReturn
{
    public int ReturenId { get; set; }

    public DateTime ActualReturnDate { get; set; }

    public byte ActualRentalDays { get; set; }

    public short Mileage { get; set; }

    public short ConsumedMileage { get; set; }

    public string FinalCheckNotes { get; set; } = null!;

    public decimal AdditionalCharges { get; set; }

    public decimal ActualTotalDueAmount { get; set; }

    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();
}
