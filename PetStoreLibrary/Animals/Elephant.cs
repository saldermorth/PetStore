﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary
{
    class Elephant : Animal
    {
        public Elephant(bool hasTusks, int trunkLegth, string origin) : base(78000)
        {
            HasTusks = hasTusks;
            TrunkLegth = trunkLegth;
            Origin = origin;
        }

        public bool HasTusks { get; set; }
        public int TrunkLegth { get; set; }
        public string Origin { get; set; }
    }
}
