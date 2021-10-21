using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreLibrary.Animals
{
    class AnimalShop
    {
        public List<Animal> Inventory { get; set; }
        public List<Animal> Sold { get; set; }
        public int Profits { get; set; }

        public void Meny() { 
        }
        public Animal SellAnimal(string animalType)
        {
            if (animalType == null || animalType == "")
            {
                foreach (var item in Inventory)
                {
                    if (animalType == item.Name)
                    {

                    }
                }
            }
            

            
            Animal temp = new Animal();
            return temp;
        }
    }
}
