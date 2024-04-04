using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Name { get; set; }

        public DateTime start { get; set; }

        public int duration { get; set; }

        public Movie movie { get; set; }

        public int MovieId { get; set; }

        public List<ShowSeats> showSeats { get; set; }

        public Theatre theatre { get; set; }

        public int theatreId { get; set; }

        public Hall hall { get; set; }

        public int hallid { get; set; }


    }


    public class ShowModelConfiguration : IEntityTypeConfiguration<Show>
    {
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            builder.HasKey(x => new { x.ShowId });

            builder.HasOne(x => x.movie).WithOne(x => x.show).HasForeignKey<Show>(x => x.ShowId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.theatre).WithMany(x => x.shows).HasForeignKey(x => x.ShowId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x=>x.hall).WithOne(x=>x.show).HasForeignKey<Hall>(x => x.HallId).OnDelete(DeleteBehavior.ClientSetNull);


        }

    }
}
