using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDao;

        public DrinkService()
        {
            drinkDao = new DrinkDao();
        }

        // Method to retrieve all drinks
        public List<Drink> GetDrinks()
        {
            // Retrieve all drinks from the database via the DAO
            List<Drink> drinks = drinkDao.GetAllDrinks();
            return drinks;
        }
        public void Delete(Drink drink)
        {
            drinkDao.DeleteDrink(drink);
        }
        public void Update(Drink drink)
        {

            drinkDao.UpdateDrink(drink);
        }
    }
}

