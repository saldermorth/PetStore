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
        List<Animal> searchResults = new List<Animal>();
        public int Profits { get; private set; }

        public PetStoreForm()
        {
            InitializeComponent();

            //foreach (Animal pet in AnimalShop.Inventory)
            //{
            //    searchResultListBox.Items.Add(pet.Name);
            //}
            
            
        }
            
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            searchBarTextBox.Clear();
        }

        private void PetStoreForm_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {


            SearchResultBoxUpdate();


        }
        public void SearchResultBoxUpdate()
        {
            //searchResults.Clear();
            searchResults = AnimalShop.ListSender(searchBarTextBox.Text);
            if (searchResults != null)
            {
                searchResultListBox.Items.Clear();
                foreach (Animal item in searchResults)
                {
                    searchResultListBox.Items.Add(item.GetName());
                }
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            AnimalShop shop = new AnimalShop();
            string activeSearchResult = searchBarTextBox.Text.ToLower();
            string resultOfSale = shop.SellAnimal(activeSearchResult);
            MessageBox.Show(resultOfSale);            
            //searchBarTextBox.Clear();
            searchResultListBox.Items.Clear();
            SearchResultBoxUpdate();


        }
    }
}
