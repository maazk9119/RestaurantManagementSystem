using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Burgers:Product
    {
        public Burgers() { }
        public Burgers(string Name, int Price) : base(Name, Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Burgers(string Name, int Price, int Quantity) : base(Name, Price, Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
