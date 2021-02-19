using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1111
{
    internal class Initializer : CreateDatabaseIfNotExists<BookShopDbContext>
    {
        protected override void Seed(BookShopDbContext context)
        {
            base.Seed(context);

            Publisher pb1 = context.Publishers.Add(new Publisher() { Name = "Big 5" });
            Publisher pb2 = context.Publishers.Add(new Publisher() { Name = "HarperCollins" });
            Publisher pb3 = context.Publishers.Add(new Publisher() { Name = "Macmillan " });
            context.SaveChanges();

            Genre genreFantasy = context.Genres.Add(new Genre() { Name = "Fantasy" });
            Genre genreThriller = context.Genres.Add(new Genre() { Name = "Thriller" });
            Genre genreRomance = context.Genres.Add(new Genre() { Name = "Romance" });
            context.SaveChanges();

            Author authorZadie = context.Authors.Add(new Author() { Name = "Zadie", Surname = "Smith" });
            Author authorHardy = context.Authors.Add(new Author() { Name = "Thomas ", Surname = "Hardy" });
            Author authorJoseph = context.Authors.Add(new Author() { Name = "Joseph ", Surname = "Conrad" });
            context.SaveChanges();

            Book bkd = context.Books.Add(new Book() { Name = "Jude the Obscure", Pages = 200, PublishYear = 1891, RealPrice = 40, SellingPrice = 55, GenreId = 1, AuthorId = 2, PublisherId = 3 });
            Book bkds = context.Books.Add(new Book() { Name = "he History of Tom Jones, a Foundling", Pages = 400, PublishYear = 1900, RealPrice = 50, SellingPrice = 65, GenreId = 2, AuthorId = 1, PublisherId = 1 });
            Book bkdkk = context.Books.Add(new Book() { Name = "Heart of Darkness", Pages = 300, PublishYear = 1899, RealPrice = 30, SellingPrice = 45, GenreId = 3, AuthorId = 3, PublisherId = 2 });
            context.SaveChanges();

            PaymentMethod pm1 = context.PaymentMethods.Add(new PaymentMethod() { Name = "by cash" });
            PaymentMethod pm2 = context.PaymentMethods.Add(new PaymentMethod() { Name = "by card" });
            PaymentMethod pm3 = context.PaymentMethods.Add(new PaymentMethod() { Name = "by phone" });
            context.SaveChanges();

            Account account1 = context.Accounts.Add(new Account() { Name = "Jim", Surname = "Carry", Email = "jim.carr@gmail.com", IsAdmin = true, Login = "billGay", Password = "123" });
            Account account2 = context.Accounts.Add(new Account() { Name = "Clown", Surname = "Cat", Email = "clown.cat@gmail.com", IsAdmin = false, Login = "admin", Password = "admin" });
            Account account3 = context.Accounts.Add(new Account() { Name = "Bill", Surname = "Gay", Email = "clown.cat@gmail.com", IsAdmin = true, Login = "dom", Password = "123" });
            context.SaveChanges();
        }
    }
}
