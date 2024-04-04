using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int seatNumber { get; set; }

        public string seatType { get; set; }

        public Hall hall { get; set; }

        public int hallId { get; set; }

        public List<ShowSeats> showSeats { get; set; }


    }

    public class SeatModelConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(x => new { x.SeatId });
            builder.HasOne(x => x.hall).WithMany(x => x.seats).HasForeignKey(x => x.hallId).OnDelete(DeleteBehavior.ClientSetNull);




        }
    }
}
