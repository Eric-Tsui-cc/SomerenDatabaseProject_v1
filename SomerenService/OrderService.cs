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
        public void CreateOrder(Student student, Drink drink, int Amount, DateTime dateOfOrder, TimeSpan timeOfOrder)
        {
 
            if(orderDb.OrderExists( student.Number, drink.DrinkId) )
            {
                orderDb.ifOrderExists(drink, Amount, student);

            }
            else
            {
                orderDb.CreateOrder(student, drink, Amount, dateOfOrder, timeOfOrder);

            }            

        }
        public void FillTheOrder(int studentSelectedIndex, int drinkSelectedIndex, Student student, Drink drink, int Amount)
        {
            if (studentSelectedIndex == -1)
            {
                throw new Exception("Select one student !");
            }
            else if (drinkSelectedIndex == -1)
            {
                throw new Exception("Select one drink !");
            }
            else
            {
                DateTime dateOfOrder = DateTime.Now;
                TimeSpan timeOfOrder = new TimeSpan();
                timeOfOrder = DateTime.Now.TimeOfDay; ;

                if (drink.Stock < Amount)
                {
                    throw new Exception($" {drink.Stock} is in stock. Stock is insufficient !");
                }

                orderDb.CreateOrder(student, drink, Amount, dateOfOrder, timeOfOrder);
            }
        }
        public void DisplayPrice(Drink drink, int studentSelectedIndex, int drinkSelectedIndex, decimal amountOfDrinks, out string finalPrice)
        {
            decimal price = 0m;

            if (studentSelectedIndex != -1 && drinkSelectedIndex != -1)
            {
                price = drink.price * amountOfDrinks;
            }

            finalPrice = $"{price}";
        }

    }
}
