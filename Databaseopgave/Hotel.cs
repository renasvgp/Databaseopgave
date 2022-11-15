﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave
{
   
    public class Hotel
    {
        public int Hotel_No { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return $"ID: {Hotel_No}, Name: {Name}, Address: {Address}";
        }
    }
}

