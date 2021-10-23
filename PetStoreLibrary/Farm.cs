using PetStoreLibrary.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary
{
    class Farm
    {
        /// <summary>
        /// Creates all Animal objects
        /// </summary>
        /// <param name="inventory"></param>
        public void BreedAnimals(List<Animal> inventory)
        {            
            for (int i = 0; i <45; i++)
            {
                if (i < 13)
                {
                    Wolf temp = new Wolf("Timber", "Grey", false);
                    inventory.Add(temp);
                }
                else if (i > 13 && i < 33)
                {
                    Duck temp = new Duck(true, false, "Quack");
                    inventory.Add(temp);
                }
                else
                {
                    Elephant temp = new Elephant(true, 4000, "Africa");
                    inventory.Add(temp);
                }                   
            }
        }
    }
}
