﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverages : Product
    {
        public Beverages(string name, decimal price, double milliliters)
            :base(name, price)
        {
            this.Milliliters = milliliters;
        }
        
        public virtual double Milliliters { get; set; }
    }
}
