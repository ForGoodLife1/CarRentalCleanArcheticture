using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class VehicleCategoryConfigurations : IEntityTypeConfiguration<VehicleCategory>
    {
        public void Configure(EntityTypeBuilder<VehicleCategory> builder)
        {
            builder.HasKey(e => e.CategoryId).HasName("PK__CarCateg__19093A2BB81B1038");

            builder.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            builder.Property(e => e.CategoryNameAr).HasMaxLength(50);
            builder.Property(e => e.CategoryNameEn).HasMaxLength(50);
        }
    }
}
