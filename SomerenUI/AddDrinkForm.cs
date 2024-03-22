using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class AddDrinkForm : Form
    {
        DrinkService DrinkService;
        public AddDrinkForm()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(new object[] { "Alcohol", "No Alcohol" });
            DrinkService = new DrinkService();
        }

        private void AddDrinkbutton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int id = int.Parse(textBoxID.Text); 
            decimal price =  decimal.Parse(textBoxPrice.Text);
            string type = comboBoxType.SelectedItem.ToString();
            int stock = int.Parse(textBoxStock.Text);
            Drink drink = new Drink(id,name,price,type,stock);
            DrinkService.AddDrink(drink);
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxID.Text = "";
            textBoxStock.Text = "";
            MessageBox.Show("Drink added!");
        }
    }
}
