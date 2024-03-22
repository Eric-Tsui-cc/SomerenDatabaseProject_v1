using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao orderDb;
        public OrderService()
        {
            orderDb = new OrderDao();
        }
        public void CreateOrder(Student student, Drink drink, int Amount, DateTime dateOfOrder)
        {
            orderDb.CreateOrder(student, drink, Amount, dateOfOrder);
        }
        public void FillOrder(int studentSelectedIndex, int drinkSelectedIndex, Student student, Drink drink, int Amount)
        {
            if (studentSelectedIndex == -1)
            {
                throw new Exception("Select a student.");
            }
            else if (drinkSelectedIndex == -1)
            {
                throw new Exception("Select a drink.");
            }
            else
            {
                DateTime dateOfOrder = DateTime.Now;

                if (drink.Stock < Amount)
                {
                    throw new Exception($"Only {drink.Stock} is in stock.");
                }

                orderDb.CreateOrder(student, drink, Amount, dateOfOrder);
            }
        }
        public void DisplayPrice(Drink drink, int studentSelectedIndex, int drinkSelectedIndex, decimal quantityOfDrinks, out string totalPrice)
        {
            decimal price = 0m;

            if (studentSelectedIndex != -1 && drinkSelectedIndex != -1)
            {
                price = drink.price * quantityOfDrinks;
            }

            totalPrice = $"{price}";
        }

    }
}
