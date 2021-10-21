using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStoreLibrary;
using PetStoreLibrary.Animals;

namespace PetShopUI
{
    public partial class PetStoreForm : Form
    {
        public PetStoreForm()
        {
            InitializeComponent();

            Animal two = new Wolf("Timber", "Grey", true);
            //foreach (var item in AnimalShop.Inventory)
            //{
            //    searchResultListBox.Items.Add(item.Name);          

            //}
            for (int i = 0; i < 15; i++)
            {
                searchResultListBox.Items.Add(two.Name);
            }
            
        }

        public void ShopConnector(string animalType)
        {

            //if (animalType == null || animalType == "")
            //{
            //    foreach (var item in Inventory)
            //    {
            //        if (animalType == item.Name)
            //        {
            //            Profits = Profits + item.Price;
            //            Sold.Add(item);
            //            Console.WriteLine("You just bought a {0}", item.Name);
            //            Inventory.Remove(item);

            //        }
            //    }
            //}
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            searchBarTextBox.Clear();
        }

        private void PetStoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}
