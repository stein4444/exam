using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            HasKey(o => o.Number);
            HasOptional(o => o.Account)
                    .WithMany(h => h.Orders)
                    .HasForeignKey(o => o.AccountId)
                    .WillCascadeOnDelete(false);

            HasRequired(o => o.PaymentMethod)
                    .WithMany(m => m.Orders)
                    .HasForeignKey(o => o.PaymentMethodId)
                    .WillCascadeOnDelete(false);

            HasMany(o => o.Books).WithMany(m => m.Orders);
        }

    }
}
