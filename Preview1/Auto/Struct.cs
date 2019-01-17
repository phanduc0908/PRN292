using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Struct : Auto
    {
        private int weight { get; set; }
        private double addedPrice { get; set; }

        public Struct(int id, double basePrice, int year, int weight, double addedPrice) : base(id, basePrice, year)
        {
            this.weight = weight;
            this.addedPrice = addedPrice;
        }

        public override string ToString()
        {
            return base.ToString() + " -Weight: " + weight + " -Add price: " + addedPrice + " -Total: " + getPrice();
        }
        public override double getPrice()
        {
            return base.getPrice() + addedPrice;
        }
    }
}
