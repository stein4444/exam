using System.Collections.Generic;

namespace Exam1111
{
    public class Book
    {
        public Book()
        {
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int PublishYear { get; set; }
        public decimal RealPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public int? BookContinuationId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
