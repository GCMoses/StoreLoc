using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreLoc.APIData;

namespace StoreLoc.LocatorDataEntities
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasData(
                new Province
                {
                    Id = 1,
                    Name = "Eastern Cape",
                    ShortName = "EC"
                },
                new Province
                {
                    Id = 2,
                    Name = "Free State",
                    ShortName = "FS"
                },
                new Province
                {
                    Id = 3,
                    Name = "Gauteng",
                    ShortName = "GP"
                },
                new Province
                {
                    Id = 4,
                    Name = "KwaZulu-Natal",
                    ShortName = "KZN"
                },
                new Province
                {
                    Id = 5,
                    Name = "Limpopo",
                    ShortName = "LP"
                },
                new Province
                {
                    Id = 6,
                    Name = "Mpumalanga",
                    ShortName = "MP"
                },
                new Province
                {
                    Id = 7,
                    Name = "Northern Cape",
                    ShortName = "NC"
                },
                new Province
                {
                    Id = 8,
                    Name = "North West",
                    ShortName = "NW"
                },
                new Province
                {
                    Id = 9,
                    Name = "Western Cape",
                    ShortName = "WC"
                }
            );
        }
    }
}