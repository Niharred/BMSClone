using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class City
    {
        public int CityId { get; set; }

        public string Name { get; set; }

        public List<Theatre> theatres { get; set; }


    }


    public class CityModelConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => new { x.CityId });

            
        }

    }
}
