using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class ShowSeats
    {
        public int ShowSeatsId { get; set; }

        public int ShowId { get; set; }

        public int SeatId { get; set; }

        public string status { get; set; }

        public Show show { get; set; }

        public Seat seat { get; set; }

    }

    public class ShowSeatsModelConfiguration : IEntityTypeConfiguration<ShowSeats>
    {
        public void Configure(EntityTypeBuilder<ShowSeats> builder)
        {
            builder.HasKey(x => new { x.ShowSeatsId });

            builder.HasOne(x => x.show).WithMany(x => x.showSeats).HasForeignKey(x => x.ShowId).OnDelete(DeleteBehavior.ClientSetNull); ;

            builder.HasOne(x => x.seat).WithMany(x => x.showSeats).HasForeignKey(x => x.SeatId).OnDelete(DeleteBehavior.ClientSetNull); ;
        }

    }
}
