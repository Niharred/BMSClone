using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public double Rating { get; set; }

        public List<MovieLanguage> MovieLanguages { get; set; }

        public Show show { get; set; }

       
    }



    public class MovieModelConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => new { x.MovieId });

            builder.HasOne(x => x.show).WithOne(x => x.movie).HasForeignKey<Show>(x => x.MovieId).OnDelete(DeleteBehavior.ClientSetNull);
        }

    }
}
