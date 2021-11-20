using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_oecercises{
    class Order {
        private List<OrderItem> items = new List<OrderItem>();
        public void AddOrderItem(OrderItem item) {
            items.Add(item);
        }
        public decimal GetValue() {
            decimal sum = 0; 
            foreach  (OrderItem item in items{
                sum += item.GetValue();
            }
        }
    }
}
