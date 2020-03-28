using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Order:Product
    {
        public Order() { }
        public Order(string Name, int Price) : base(Name, Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Order(string Name, int Price, int Quantity) : base(Name, Price, Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        
    }
}
