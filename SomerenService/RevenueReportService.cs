using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    internal class RevenueReportService
    {
        private DrinkDao drinkDao;
        private OrderDao orderDao;

        public RevenueReportService(DrinkDao drinkDao, OrderDao orderDao)
        {
            this.drinkDao = drinkDao;
            this.orderDao = orderDao;
        }


        //Leith
        // Fixed the method
        public RevenueReport GenerateReport(DateTime startDate, DateTime endDate)
        {

            if (startDate > endDate)
            {
                throw new ArgumentException("Start date cannot be after end date.");
            }


            if (endDate > DateTime.Today)
            {
                throw new ArgumentException("End date cannot be in the future.");
            }

            // Retrieve orders within the date range
            List<Order> orders = orderDao.GetOrdersByDateRange(startDate, endDate);

            // Calculate revenue report data
            int sales = orders.Sum(order => order.Amount);
            decimal turnover = orders.Sum(order =>
            {
                Drink drink = order.Drink;
                return drink != null ? order.Amount * drink.price : 0;
            });

            int customerCount = orders.Count;

            return new RevenueReport(sales, turnover, customerCount);
        }
    }
}