using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class RentalBookingConfigurations : IEntityTypeConfiguration<RentalBooking>
    {
        public void Configure(EntityTypeBuilder<RentalBooking> builder)
        {
            builder.HasKey(e => e.BookingId).HasName("PK__RentalBo__73951ACDED92E193");

            builder.ToTable("RentalBooking");

            builder.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("BookingID");
            builder.Property(e => e.CustomerId).HasColumnName("CustomerID");
            builder.Property(e => e.DropoffLocation).HasMaxLength(100);
            builder.Property(e => e.InitialCheckNotes).HasMaxLength(500);
            builder.Property(e => e.InitialTotalDueAmount).HasColumnType("smallmoney");
            builder.Property(e => e.PickupLocation).HasMaxLength(100);
            builder.Property(e => e.RentalPricePerDay).HasColumnType("smallmoney");
            builder.Property(e => e.VehicleId).HasColumnName("VehicleID");

            builder.HasOne(d => d.Customer).WithMany(p => p.RentalBookings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RentalBoo__Custo__3E52440B");

            builder.HasOne(d => d.Vehicle).WithMany(p => p.RentalBookings)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RentalBoo__Vehic__3F466844");
        }
    }
}
