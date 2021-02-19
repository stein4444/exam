namespace Exam1111
{
    using System.Data.Entity;
    using System.Linq;

    public partial class BookShopDbContext : DbContext
    {

        public BookShopDbContext()
            : base("name=Model1")
        {
            Database.SetInitializer(new Initializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Configurations.Add(new AuthorConfig());

            modelBuilder.Configurations.Add(new BookConfig());

            modelBuilder.Configurations.Add(new GenreConfig());

            modelBuilder.Configurations.Add(new PublisherConfig());

            modelBuilder.Configurations.Add(new PaymentMethodConfig());

            modelBuilder.Configurations.Add(new OrderConfig());

            modelBuilder.Configurations.Add(new AccountConfig());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<SaveForClient> SaveForClients { get; set; }
    }
}
