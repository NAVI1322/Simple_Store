﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Navneet_4531978
{
    public class Product
    {
        public int ProductID { get; set; }      
        public string? ProductName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryID { get; set; }

        public Category? Category { get; set; }

    }
}
