using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary
{
    class Duck : Animal
    {
        public Duck(bool isMale, bool isParent, string sound) : base(15, "Duck")
        {
            this.isMale = isMale;
            this.isParent = isParent;
            Sound = sound;
        }

        public bool isMale { get; set; }
        public bool isParent { get; set; }
        public string Sound { get; set; }

    }
}
