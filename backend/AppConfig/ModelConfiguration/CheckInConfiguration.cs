using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace AppConfig.ModelConfiguration
{
    public class CheckInConfiguration : IEntityTypeConfiguration<CheckIn>
    {
        public void Configure(EntityTypeBuilder<CheckIn> builder)
        {
            builder
                .Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(_ => _.Guests)
                .WithOne(_ => _.CheckIn)
                .HasForeignKey<Guest>(_ => _.CheckInId);
        }
    }
}