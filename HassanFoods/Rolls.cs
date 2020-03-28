using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Rolls:Product
    {
        public Rolls() { }
        public Rolls(string Name, int Price):base(Name,Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Rolls(string Name, int Price, int Quantity):base(Name,Price,Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
