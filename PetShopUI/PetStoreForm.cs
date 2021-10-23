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
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            searchBarTextBox.Clear();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchResultBoxUpdate();
        }
        public void SearchResultBoxUpdate()
        {
            searchResults = AnimalShop.SearchResult(searchBarTextBox.Text);
            if (searchResults.Count > 1)
            {
                searchResultListBox.Items.Clear();
                foreach (Animal item in searchResults)
                {
                    searchResultListBox.Items.Add(item.GetName());
                }
            }
            else
            {
                searchResultListBox.Items.Clear();
                searchResultListBox.Items.Add("Inget sådant djur i lager");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            AnimalShop shop = new AnimalShop();
            string activeSearchResult = searchBarTextBox.Text.ToLower();
            string resultOfSale = shop.SellAnimal(activeSearchResult);
            MessageBox.Show(resultOfSale);
            searchResultListBox.Items.Clear();
            SearchResultBoxUpdate();
        }

        private void searchBarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.searchButton_Click(sender, e);
        }
    }
}
