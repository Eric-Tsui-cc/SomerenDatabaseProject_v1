using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class DeleteDrinkForm : Form
    {
        DrinkService DrinkService;
        public DeleteDrinkForm()
        {
            InitializeComponent();
            DrinkService = new DrinkService();
            RefreshDrinks();
        }
        void RefreshDrinks()
        {
            comboBoxDrinks.Items.Clear();
            comboBoxDrinks.ResetText();
            List<Drink> drinks = DrinkService.GetDrinks();
            foreach (Drink drink in drinks)
            {
                comboBoxDrinks.Items.Add(drink.name);
            }
        }

        private void buttonDeleteDrink_Click(object sender, EventArgs e)
        {
            string selectedDrinkID = (string)comboBoxDrinks.SelectedItem;
            Drink drinkToDelete = DrinkService.GetByName(selectedDrinkID);
            if (drinkToDelete != null)
            {
                DrinkService.Delete(drinkToDelete);
                RefreshDrinks();
                MessageBox.Show("Drink deleted!");
            }
        }
    }
}
