using System.Collections.Generic;

namespace Exam1111
{
    public class Publisher
    {
        public Publisher()
        {
            this.Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
