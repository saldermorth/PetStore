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
        public static List<Animal> SearchResult(string userSearch)
        {
            userSearch = userSearch.ToLower();
            List<Animal> searchResults = new List<Animal>();
            if (userSearch == "" || userSearch == null)
            {
                //Add null statment
                return searchResults;
            }
            foreach (Animal item in Inventory)//Todo - Switch here?
            {
                if (userSearch == "wolf" && item.GetType() == typeof(Wolf))
                {
                    searchResults.Add(item);
                }
                else if (userSearch == "duck" && item.GetType() == typeof(Duck))
                {
                    searchResults.Add(item);
                }
                else if (userSearch == "elephant" && item.GetType() == typeof(Elephant))
                {
                    searchResults.Add(item);
                }

            }
                       
            return searchResults;
        }
        public static List<Animal> ListSender(string search)
        {
            List<Animal> searchResults = SearchResult(search);

            return searchResults;


        }
        
    }
}
