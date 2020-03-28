using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanFoods
{
    public class DayOffReport:Product
    {
        public DayOffReport() { }
        public DayOffReport(string Name, int Price):base(Name,Price)
        { }
        public DayOffReport(string Name, int Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
