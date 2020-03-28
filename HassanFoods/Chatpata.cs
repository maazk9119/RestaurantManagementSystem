using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Chatpata:Product
    {
        public Chatpata() { }
        public Chatpata(string Name, int Price) : base(Name, Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Chatpata(string Name, int Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
