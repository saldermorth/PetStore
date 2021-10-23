using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PetStoreLibrary
{
    //Base Class
    public class Animal 
    {       
        private string ArtikelNummer  { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }        
        public Animal(decimal _price, string _name)
        {
            ArtikelNummer = GetArtikelNummer();
            GiveName();
            Price = _price;            
        }          

        /// <summary>
        /// Generates a unique name for animal objects.
        /// </summary>
        private void GiveName()
        {
            Thread.Sleep(1);
            if (this.GetType() == typeof(Wolf))
            {                
                this.Name += "Wolf" + DateTime.Now.Millisecond.ToString();
            }
            else if (this.GetType() == typeof(Duck))
            {
                this.Name += "Duck" + DateTime.Now.Millisecond.ToString();
            }
            else if (this.GetType() == typeof(Elephant))
            {
                this.Name += "Elephant" + DateTime.Now.Millisecond.ToString();
            }
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public string GetName()
        {
            return Name;
        }
        public string Artikelnummer()
        {
            return ArtikelNummer;
        }
        private string GetArtikelNummer()
        {
            Guid NewGuid = Guid.NewGuid();

            return NewGuid.ToString();
        }

    }
}