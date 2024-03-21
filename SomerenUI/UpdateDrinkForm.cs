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
    public partial class UpdateDrinkForm : Form
    {
        DrinkService DrinkService;
        public UpdateDrinkForm()
        {
            InitializeComponent();
            DrinkService = new DrinkService();
            RefreshDrinks();
        }
        void RefreshDrinks()
        {
            comBoxDrinkID.Items.Clear();
            comBoxDrinkID.ResetText();
            List<Drink> drinks = DrinkService.GetDrinks();
            foreach (Drink drink in drinks)
            {
                comBoxDrinkID.Items.Add(drink.id);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        //private void comBoxDrinkID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int DrinkID = (int)comBoxDrinkID.SelectedItem;

        //    Drink drink = DrinkService.GetById(customerId);

        //    textBoxFirstName.Text = customer.FirstName;
        //    textBoxLastName.Text = customer.LastName;
        //    textBoxEmail.Text = customer.EmailAddress;
        //}
    }
}
