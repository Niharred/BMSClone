using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class Hall
    {
        public int HallId { get; set; }
        public string Name { get; set; }

        public List<Seat> seats { get; set; }

        public Theatre theatre { get; set; }

        public int seatId { get; set; }
    }



    public class HallModelConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasKey(x => new { x.HallId });
            builder.HasOne(x => x.theatre).WithMany(x => x.halls).HasForeignKey(x => x.HallId).OnDelete(DeleteBehavior.ClientSetNull);


        }

    }
}
