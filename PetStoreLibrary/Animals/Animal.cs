using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PetStoreLibrary
{
    public class Animal
    {
       
        public string ArtikelNummer  { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Animal(decimal _price, string _name)
        {
            ArtikelNummer = GetArtikelNummer();
            GetName();
            Price = _price;
            
        }          
        private void GetName()
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
        private string GetArtikelNummer()
        {
            Guid NewGuid = Guid.NewGuid();

            return NewGuid.ToString();
        }

    }
}