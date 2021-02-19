using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1111
{
    public class DALClass
    {
        private BookShopDbContext context;
        public DALClass()
        {
            context = new BookShopDbContext();
        }

        // Get all books 
        public IQueryable<Book> GetAllBooks()
        {
            return context.Books;
        }
        public IQueryable<Genre> GetGenre()
        {
            return context.Genres;
        }
        //поиску книг по  название книги
        public IQueryable<Book> GetBookByName(string Name)
        {
            return context.Books.Where(s => s.Name == Name);
        }
        //поиску книг по автор
        public IQueryable<Book> GetBookByAuthor(string Name)
        {
            return context.Books.Where(s => s.Author.FullName == Name || (s.Author.Name == Name) || (s.Author.Surname == Name));
        }

        //поиску книг по жанр
        public IQueryable<Book> GetBookByGenre(string Genre)
        {
            return context.Books.Where(s => s.Genre.Name == Genre);
        }
        //редак-тировать параметры книг,
        public void ChangeBookName(int bookId, string NewName)
        {
            var book = context.Books.Find(bookId);
            if (book == null) return;
            book.Name = NewName;
            context.SaveChanges();
        }
        //редак-тировать параметры книг
        public void ChangeBookPrice(int bookId, decimal newPrice)
        {
            var book = context.Books.Find(bookId);
            if (book == null) return;
            book.SellingPrice = newPrice;
            context.SaveChanges();
        }
        // добавлять книги
        public void AddNewBook(Book newBook)
        {
            context.Books.Add(newBook);
            context.SaveChanges();
        }

        //просмотреть  список  новинок,
        public IQueryable<Book> GetNewesBooks()
        {
            return context.Books.OrderByDescending(b => b.PublishYear).Take(10);
        }

        public void AddNewCleint(Account acc)
        {

        }
        public IQueryable<Account> Login(string login, string passwd)
        {
            var acc = context.Accounts.Where(a => a.Login == login && a.Password == passwd);
            return acc;
        }
    }
}
