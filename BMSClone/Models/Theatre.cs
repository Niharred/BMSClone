using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class Theatre
    {
        public int TheatreId { get; set; }

        public string Name { get; set; }

        public string address { get; set; }

        public List<Hall> halls { get; set; }

        public List<Show> shows { get; set; }

        public City City { get; set; }

        public int cityId { get; set; }

    }

    public class TheatreModelConfiguration : IEntityTypeConfiguration<Theatre>
    {
        public void Configure(EntityTypeBuilder<Theatre> builder)
        {
            builder.HasKey(x => new { x.TheatreId });

            builder.HasOne(x => x.City).WithMany(x => x.theatres).HasForeignKey(x => x.cityId).OnDelete(DeleteBehavior.ClientSetNull);
        }

    }


}
