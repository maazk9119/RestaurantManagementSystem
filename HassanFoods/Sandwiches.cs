using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Sandwiches:Product
    {
        public Sandwiches() { }
        public Sandwiches(string Name, int Price) : base(Name, Price)
        {
            this.Name = Name;
            this.Price = Price;

        }
        public Sandwiches(string Name, int Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
