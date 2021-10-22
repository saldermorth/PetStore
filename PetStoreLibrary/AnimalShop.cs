using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStoreLibrary.Animals;

namespace PetStoreLibrary.Animals
{
    public class AnimalShop
    {
        public static List<Animal> Inventory = new List<Animal>();
        public static List<Animal> Sold = new List<Animal>();
        public static decimal Profits { get; set; }

        public static void Meny()
        {
            
            Farm oldMcdonalds = new Farm();
            oldMcdonalds.BreedAnimals(Inventory);
        }
        public Animal SellAnimal(string animalType)
        {
            if (animalType == null || animalType == "")
            {
                foreach (var item in Inventory)
                {
                    if (animalType == item.Name)
                    {
                        Profits = Profits + item.Price;
                        Sold.Add(item);
                        Console.WriteLine("You just bought a {0}", item.Name);
                        Inventory.Remove(item);

                    }
                }
            }


            return Inventory[1];
        }
    }
}
