using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.Models
{
    public class MovieLanguage
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int LanguageId { get; set; }

        public Movie movie { get; set; }

        public Language language { get; set; }
    }

    public class MovieLanguageModelConfiguration : IEntityTypeConfiguration<MovieLanguage>
    {
        public void Configure(EntityTypeBuilder<MovieLanguage> builder)
        {
            builder.HasKey(x => new { x.Id });

            builder.HasOne(x => x.movie).WithMany(x => x.MovieLanguages).HasForeignKey(x => x.MovieId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.language).WithMany(x => x.MovieLanguages).HasForeignKey(x => x.LanguageId).OnDelete(DeleteBehavior.ClientSetNull);


        }

    }
}
