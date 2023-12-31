﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IComparable1
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public string Print()
        {
            return $"Product{code},{name}{price}";
        }
    }
}
