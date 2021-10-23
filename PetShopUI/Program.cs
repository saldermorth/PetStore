using PetStoreLibrary;
using PetStoreLibrary.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopUI
{
    static class Program
    {
       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AnimalShop petShopBoys = new AnimalShop();

            petShopBoys.Meny();//-

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PetStoreForm());
        }
    }
}
