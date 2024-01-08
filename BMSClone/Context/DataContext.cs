using BMSClone.Models;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }


        public DbSet<City> cities { get; set; }

        public DbSet<Theatre> theatres { get; set; }


        public DbSet<Movie> movies { get; set; }


        public DbSet<Hall> halls { get; set; }

        public DbSet<Show> shows { get; set; }


        public DbSet<Seat> seats { get; set; }

        public DbSet<ShowSeats> showSeats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityModelConfiguration());
            modelBuilder.ApplyConfiguration(new TheatreModelConfiguration());
            modelBuilder.ApplyConfiguration(new MovieModelConfiguration());
            modelBuilder.ApplyConfiguration(new HallModelConfiguration());
            modelBuilder.ApplyConfiguration(new ShowModelConfiguration());
            modelBuilder.ApplyConfiguration(new SeatModelConfiguration());
            modelBuilder.ApplyConfiguration(new ShowSeatsModelConfiguration());
            modelBuilder.ApplyConfiguration(new UserModelConfiguration());

        }

    }
}
