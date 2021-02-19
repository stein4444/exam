using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            Property(n => n.Name)
            .IsRequired();

            HasRequired(e => e.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(e => e.PublisherId);

            HasRequired(e => e.Author)
           .WithMany(p => p.Books)
           .HasForeignKey(e => e.AuthorId);

            HasRequired(e => e.Genre)
           .WithMany(p => p.Books)
           .HasForeignKey(e => e.GenreId);

            HasMany(o => o.Orders).WithMany(m => m.Books);

        }
    }
}
