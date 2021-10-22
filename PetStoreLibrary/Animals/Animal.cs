using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (this.GetType() == typeof(Wolf))
            {
                this.Name += DateTime.Now.Millisecond.ToString();
            }
            else if (this.GetType() == typeof(Duck))
            {
                this.Name += DateTime.Now.Millisecond.ToString();
            }
            else if (this.GetType() == typeof(Elephant))
            {
                this.Name += DateTime.Now.Millisecond.ToString();
            }
        }
        private string GetArtikelNummer()
        {
            Guid NewGuid = Guid.NewGuid();

            return NewGuid.ToString();
        }

    }
}