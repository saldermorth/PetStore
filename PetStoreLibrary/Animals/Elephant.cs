﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary
{
    public class Elephant : Animal
    {       
        public bool HasTusks { get; set; }
        public int TrunkLegth { get; set; }
        public string Origin { get; set; }

        public Elephant(bool hasTusks, int trunkLegth, string origin) : base(78000, "Elephant")
        {
            HasTusks = hasTusks;
            TrunkLegth = trunkLegth;
            Origin = origin;
        }
        public string GetInfo()
        {
            return $"Har betar : {this.HasTusks.ToString()}\n" +
                   $"Ursprung : {this.Origin}\n" +
                   $"Snabellängd : {this.TrunkLegth}mm"
                   ;
          
        }
    }
}
