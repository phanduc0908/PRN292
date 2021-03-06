﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.CORE
{
    public class Car : Auto
    {
        private int numOfPassenger { get; set; }
        private double pricePerPass { get; set; }

        public Car(int id, double basePrice, int year, int numOfPassenger, double pricePerPass) : base(id, basePrice, year)
        {
            this.numOfPassenger = numOfPassenger;
            this.pricePerPass = pricePerPass;
        }
        public override double getPrice()
        {
            return base.getPrice() + numOfPassenger * pricePerPass;
        }

        public override string ToString()
        {
            return base.ToString() + "--- NumOfPassenger: " + numOfPassenger + "--- Price per pass: " + pricePerPass;
        }
    }
}
