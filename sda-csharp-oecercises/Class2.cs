using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_oecercises{
    class OrderItem {
        public string ProductName{ get;set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public virtual decimal GetValue(){
            return UnitPrice * Quantity;
        }
        public override string ToString(){
            return $"{ProductName}, cena: {UnitPrice} PLN, {Quantity} szt, wartość: {GetValue()} PLN";
        }
    }
}
