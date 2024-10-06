using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class VehicleReturnConfigurations : IEntityTypeConfiguration<VehicleReturn>
    {
        public void Configure(EntityTypeBuilder<VehicleReturn> builder)
        {
            builder.HasKey(e => e.ReturenId);

            builder.Property(e => e.ReturenId).HasColumnName("ReturenID");
            builder.Property(e => e.ActualReturnDate).HasColumnType("datetime");
            builder.Property(e => e.ActualTotalDueAmount).HasColumnType("smallmoney");
            builder.Property(e => e.AdditionalCharges).HasColumnType("smallmoney");
            builder.Property(e => e.FinalCheckNotes).HasMaxLength(500);
        }
    }
}
