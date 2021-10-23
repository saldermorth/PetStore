using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary
{
    public class Duck : Animal
    {
       
        public bool isMale { get; set; }
        public bool isParent { get; set; }
        public string Sound { get; set; }
        public Duck(bool isMale, bool isParent, string sound) : base(15, "Duck")
        {
            this.isMale = isMale;
            this.isParent = isParent;
            Sound = sound;
        }
        /// <summary>
        /// Unique data for Duck type of object.
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Är hane : {this.isMale}\n" +
                   $"Är förälder : {this.isParent}\n" +
                   $"Säger  : {this.Sound}";
        }


    }
}
