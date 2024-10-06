using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class RentalTransactionConfigurations : IEntityTypeConfiguration<RentalTransaction>
    {
        public void Configure(EntityTypeBuilder<RentalTransaction> builder)
        {
            builder.HasKey(e => e.TransactionId).HasName("PK__RentalTr__55433A4BF9EB5844");

            builder.ToTable("RentalTransaction");

            builder.Property(e => e.TransactionId)
                .ValueGeneratedNever()
                .HasColumnName("TransactionID");
            builder.Property(e => e.ActualTotalDueAmount).HasColumnType("smallmoney");
            builder.Property(e => e.BookingId).HasColumnName("BookingID");
            builder.Property(e => e.PaidInitialTotalDueAmount).HasColumnType("smallmoney");
            builder.Property(e => e.PaymentDetails).HasMaxLength(100);
            builder.Property(e => e.ReturnId).HasColumnName("ReturnID");
            builder.Property(e => e.TotalRefundedAmount).HasColumnType("smallmoney");
            builder.Property(e => e.TotalRemaining).HasColumnType("smallmoney");
            builder.Property(e => e.TransactionDate).HasColumnType("datetime");
            builder.Property(e => e.UpdatedTransactionDate).HasColumnType("datetime");

            builder.HasOne(d => d.Booking).WithMany(p => p.RentalTransactions)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentalTransaction_RentalBooking");

            builder.HasOne(d => d.Return).WithMany(p => p.RentalTransactions)
                .HasForeignKey(d => d.ReturnId)
                .HasConstraintName("FK_RentalTransaction_VehicleReturns");
        }
    }
}
