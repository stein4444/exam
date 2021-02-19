using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class PaymentMethodConfig : EntityTypeConfiguration<PaymentMethod>
    {
        public PaymentMethodConfig()
        {
            Property(n => n.Name)
            .HasMaxLength(100)
            .IsRequired();
        }
    }
}
