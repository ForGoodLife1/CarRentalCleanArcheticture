using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class MaintenanceConfigurations : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.HasKey(e => e.MaintenanceId).HasName("PK__Maintena__E60542B587779474");

            builder.ToTable("Maintenance");

            builder.Property(e => e.MaintenanceId)
                .ValueGeneratedNever()
                .HasColumnName("MaintenanceID");
            builder.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            builder.Property(e => e.Description).HasMaxLength(300);
            builder.Property(e => e.VehicleId).HasColumnName("VehicleID");

            builder.HasOne(d => d.Vehicle).WithMany(p => p.Maintenances)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Maintenan__Vehic__44FF419A");
        }
    }
}
