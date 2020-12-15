using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Orders
    {
        public Orders()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Store Store { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
