using System.Collections.Generic;

namespace Exam1111
{
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // NAVIGATION PROPERTIES
        public virtual ICollection<Order> Orders { get; set; }
    }
}
