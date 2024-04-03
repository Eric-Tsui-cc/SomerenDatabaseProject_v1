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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class UpdateDrinkForm : Form
    {
        DrinkService DrinkService;
        public UpdateDrinkForm()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(new object[] { "Alcohol", "No Alcohol" });
            DrinkService = new DrinkService();
            RefreshDrinks();
        }
        void RefreshDrinks()
        {
            comBoxDrinkName.Items.Clear();
            comBoxDrinkName.ResetText();
            List<Drink> drinks = DrinkService.GetDrinks();
            foreach (Drink drink in drinks)
            {
                comBoxDrinkName.Items.Add(drink.name);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            object selectedItem = comBoxDrinkName.SelectedItem;

            if (selectedItem != null)
            {
                Drink updateddrink = new Drink(
                    DrinkService.GetByName(selectedItem.ToString()).id,
                    textBoxNewName.Text,
                    decimal.Parse(textBoxPrice.Text),
                    comboBoxType.SelectedItem.ToString(),
                    int.Parse(textBoxStock.Text)
                );

                DrinkService.Update(updateddrink);
                MessageBox.Show("Drink updated!");
                RefreshDrinks();
            }
            else
            {
                MessageBox.Show("No drink selected!");
            }

            comBoxDrinkName.SelectedItem = selectedItem;
        }


        private void comBoxDrinkID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drinkname = (string)comBoxDrinkName.SelectedItem;
            Drink drink = DrinkService.GetByName(drinkname);
            textBoxNewName.Text = drink.name;
            comboBoxType.SelectedItem = drink.type;
            textBoxStock.Text = drink.stock.ToString();
            textBoxPrice.Text = Convert.ToString(drink.price);
        }
    }
}
