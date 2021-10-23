﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetStoreLibrary
{
    public class Wolf : Animal
    {

        public Wolf(string type, string color, bool isAlfa) : base(5000, "Wolf")
        {
            Type = type;
            Color = color;
            this.isAlfa = isAlfa;
        }

        public string Type { get; set; }
        public string Color { get; set; }
        public bool isAlfa { get; set; }
    }
}
