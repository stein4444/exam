using System.Collections.Generic;

namespace Exam1111
{
    public class Account
    {

        public Account()
        {
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
