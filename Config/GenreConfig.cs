using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class GenreConfig : EntityTypeConfiguration<Genre>
    {
        public GenreConfig()
        {
            Property(n => n.Name)
            .IsRequired()
            .HasColumnName("GenreName");
        }
    }
}
