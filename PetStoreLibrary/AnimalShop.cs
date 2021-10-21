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
        public static List<Animal> Inventory { get; set; }
        public static List<Animal> Sold { get; set; }
        private static decimal Profits { get; set; }

        public void Meny()
        {

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
