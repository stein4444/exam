using System.Data.Entity.ModelConfiguration;

namespace Exam1111
{
    internal class PublisherConfig : EntityTypeConfiguration<Publisher>
    {
        public PublisherConfig()
        {
            Property(n => n.Name)
            .IsRequired()
            .HasColumnName("PublisherName");
        }
    }
}
