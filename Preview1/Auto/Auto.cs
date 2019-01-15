using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        public int id { get; set; }
        public double basePrice { get; set; }
        public int year { get; set; }

        public Auto(int id, double basePrice, int year)
        {
            this.id = id;
            this.basePrice = basePrice;
            this.year = year;
        }

        public override string ToString()
        {
            return "ID: " + id + " - Base price: " + basePrice +" - Year: " + year;
        }
        public virtual double getPrice()
        {
            return basePrice;
        }
    }
}
