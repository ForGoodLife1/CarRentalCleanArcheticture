using CarRental.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infarastructure.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B85DA89241");

            builder.ToTable("Customer");

            builder.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            builder.Property(e => e.ContactInformation).HasMaxLength(100);
            builder.Property(e => e.DriverLicenseNumber).HasMaxLength(20);
            builder.Property(e => e.NameAr).HasMaxLength(100);
            builder.Property(e => e.NameEn).HasMaxLength(100);
        }
    }
}
