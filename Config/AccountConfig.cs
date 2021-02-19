using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class AccountConfig : EntityTypeConfiguration<Account>
    {
        public AccountConfig()
        {
            Property(l => l.Login)
            .HasMaxLength(20)
            .IsRequired();

            Property(p => p.Password)
           .HasMaxLength(20)
           .IsRequired();

            Property(n => n.Name)
                       .IsRequired()
                       .HasMaxLength(100)
                       .HasColumnName("FirstName");

            Property(s => s.Surname)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("SecondName");

            Property(s => s.Email)
           .IsRequired()
           .HasMaxLength(40);
        }
    }
}
