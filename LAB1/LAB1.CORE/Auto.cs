using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.CORE
{
    public class Auto:IComparable
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
            return "ID: " + id + " --- Base price: " + basePrice + " --- Year: " + year;
        }
        public virtual double getPrice()
        {
            return basePrice;
        }

        public int CompareTo(object obj)
        {
            Auto a = (Auto)obj;
            return a.id.CompareTo(id);
        }
        public override bool Equals(object obj)
        {
            Auto a = (Auto)obj;
            return id.Equals(a.id);
        }
    }
}
