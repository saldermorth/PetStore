using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreLibrary
{
    public abstract class Animal
    {
       
        public string ArtikelNummer  { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Animal( decimal _price)
        {
            ArtikelNummer = GetArtikelNummer();
            Name = GetName();
            Price = _price;
        }
        private string GetName()
        {
            return "Bob" + DateTime.Now.Millisecond.ToString();
        }
        private string GetArtikelNummer()
        {
            Guid NewGuid = Guid.NewGuid();

            return  NewGuid.ToString();
        }

    }
}