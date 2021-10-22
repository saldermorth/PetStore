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

                if (i % 2 == 0)
                {
                    Wolf temp = new Wolf("Timber", "Grey", false);
                    inventory.Add(temp);
                }
                else if (i % 1 == 0)
                {
                    Duck temp = new Duck(true, false, "Quack");
                    inventory.Add(temp);
                }
                else// TOdo - never enters here
                {
                    Elephant temp = new Elephant(true, 4000, "Africa");
                    inventory.Add(temp);
                }                   
            }
        }
    }
}
