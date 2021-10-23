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
        private static List<Animal> Inventory = new List<Animal>();
        private static List<Animal> SoldItems = new List<Animal>();
        private static decimal Profits { get; set; }

        public void Meny()
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
        public string SellAnimal(string activeSearchResult)//Todo - rerturn string
        {
            //ToDo - print once?
            if (activeSearchResult == "duck")
            {
                foreach (Duck item in Inventory.OfType<Duck>())
                {
                    if (item.GetName().Contains("Duck"))
                    {
                        SoldItems.Add(item);
                        Inventory.Remove(item);
                        Profits += item.GetPrice();
                        return $"{item.GetName()} Såld. \n" +
                           $"Pris : {item.GetPrice()}.  \n" +
                           $"Bruttovinst : {Profits}\n" +
                           $"Artikelnummer :{item.Artikelnummer()}\n" +
                           item.GetInfo();                           
                    }
                }
            }
            if (activeSearchResult == "wolf")
            {
                foreach (Wolf item in Inventory.OfType<Wolf>())
                {
                    if (item.GetName().Contains("Wolf"))
                    {
                        SoldItems.Add(item);
                        Inventory.Remove(item);
                        Profits += item.GetPrice();
                        return $"{item.GetName()} Såld. \n" +
                           $"Pris : {item.GetPrice()}.  \n" +
                           $"Bruttovinst : {Profits}\n" +
                           $"Artikelnummer :{item.Artikelnummer()}\n" +
                           item.GetInfo();
                    }
                }

            }
            if (activeSearchResult == "elephant")
            {                                
                foreach (Elephant item in Inventory.OfType<Elephant>())
                {                    
                    if (item.GetName().Contains("Elephant") && item.GetType() == typeof(Elephant))
                    {                        
                        SoldItems.Add(item);
                        Inventory.Remove(item);
                        Profits += item.GetPrice();
                        return $"{item.GetName()} Såld. \n" +
                            $"Pris : {item.GetPrice()}.  \n" +
                            $"Bruttovinst : {Profits}\n" +
                            $"Artikelnummer :{item.Artikelnummer()}\n"                           
                            + item.GetInfo();                          
                    }
                }
            }            
            return "null";
        }
        
    }
}
