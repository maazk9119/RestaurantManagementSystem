using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class Product
    {
        public string Name;
        public int Price;
        public int Quantity;
        protected int Id;

        public Product() { }
        public Product(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Product(string Name, int Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }

    }
}
