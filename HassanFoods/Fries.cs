using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Fries:Product
    {
        public Fries() { }
        public Fries(string Name, int Price) : base(Name, Price)
        {
            this.Name = Name;
            this.Price = Price;

        }
        public Fries(string Name, int Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
