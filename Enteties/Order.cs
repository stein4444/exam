namespace Exam1111
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public Order()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int Number { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        // FOREIGN KEYS
        public int? AccountId { get; set; }
        public int PaymentMethodId { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Account Account { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
