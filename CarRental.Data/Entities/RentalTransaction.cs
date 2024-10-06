namespace CarRental.Data.Entities;


public partial class RentalTransaction
{
    public int TransactionId { get; set; }

    public int BookingId { get; set; }

    public int? ReturnId { get; set; }

    public string PaymentDetails { get; set; } = null!;

    public decimal PaidInitialTotalDueAmount { get; set; }

    public decimal ActualTotalDueAmount { get; set; }

    public decimal TotalRemaining { get; set; }

    public decimal TotalRefundedAmount { get; set; }

    public DateTime TransactionDate { get; set; }

    public DateTime? UpdatedTransactionDate { get; set; }

    public virtual RentalBooking Booking { get; set; } = null!;

    public virtual VehicleReturn? Return { get; set; }
}
