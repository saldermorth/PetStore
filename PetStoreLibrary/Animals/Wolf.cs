using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetStoreLibrary
{
    class Wolf : Animal
    {
        public string WolfName { get; set; }

        public Wolf(string type, string color, bool isAlfa) :base(5000)
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
