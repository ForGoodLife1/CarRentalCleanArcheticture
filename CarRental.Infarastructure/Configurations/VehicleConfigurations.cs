using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class VehicleConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(e => e.VehicleId).HasName("PK__Vehicle__476B54B2E4724D7D");

            builder.ToTable("Vehicle");

            builder.Property(e => e.VehicleId)
                .ValueGeneratedNever()
                .HasColumnName("VehicleID");
            builder.Property(e => e.CarCategoryId).HasColumnName("CarCategoryID");
            builder.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");
            builder.Property(e => e.IsAvailableForRent).HasDefaultValue(true);
            builder.Property(e => e.Make).HasMaxLength(50);
            builder.Property(e => e.Model).HasMaxLength(50);
            builder.Property(e => e.PlateNumber).HasMaxLength(20);
            builder.Property(e => e.RentalPricePerDay).HasColumnType("decimal(10, 2)");

            builder.HasOne(d => d.CarCategory).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.CarCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vehicle__CarCate__3B75D760");

            builder.HasOne(d => d.FuelType).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.FuelTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehicle_FuleTypes");
        }
    }
}
