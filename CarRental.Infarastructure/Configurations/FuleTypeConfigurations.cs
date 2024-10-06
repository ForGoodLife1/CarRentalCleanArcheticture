using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class FuleTypeConfigurations : IEntityTypeConfiguration<FuleType>
    {
        public void Configure(EntityTypeBuilder<FuleType> builder)
        {
            builder.Property(e => e.Id)
               .ValueGeneratedNever()
               .HasColumnName("ID");
            builder.Property(e => e.FuleType1)
                .HasMaxLength(20)
                .HasColumnName("FuleType");
        }
    }
}
