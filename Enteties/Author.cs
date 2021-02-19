using System.Collections.Generic;

namespace Exam1111
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public virtual ICollection<Book> Books { get; set; }
    }
}
