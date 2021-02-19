using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            Property(n => n.Name)
            .IsRequired()
            .HasColumnName("FirstName");

            Property(s => s.Surname)
           .IsRequired()
           .HasColumnName("SecondName");

            Ignore(e => e.FullName);

        }
    }
}
