using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class VatService
    {
        private VatDao vatDb;
        public VatService()
        {
            vatDb = new VatDao();
        }

         public List<Order> GetOrdersByQuarter(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = vatDb.GetOrdersByQuarter(startDate, endDate);
            return orders;
        }
      public void VatCalculation(DateTime startDate, DateTime endDate, out decimal vatNine, out decimal vatTwentyOne, out decimal vatTotal)
        {
            List<Order> orders = GetOrdersByQuarter(startDate, endDate);
            List<Drink> drink9Vat = new List<Drink>();
            List<Drink> drink21Vat = new List<Drink>();

            // Filter for drinks with specific VAT rates
            foreach (var order in orders)
            {
                if (order.Drink.Vat == 9)
                {
                    drink9Vat.Add(order.Drink);
                }
                else if (order.Drink.Vat == 21)
                {
                    drink21Vat.Add(order.Drink);
                }
            }

            // Calculate VAT for 9% drinks
            vatNine = drink9Vat.Sum(drink => drink.price * drink.Vat ); 

            // Calculate VAT for 21% drinks
            vatTwentyOne = drink21Vat.Sum(drink => drink.price * drink.Vat); 

            // Calculate total VAT
            vatTotal = vatNine + vatTwentyOne;
        }

    }
}
