using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueReportService
    {
        private OrderDao orderDao;
        public RevenueReportService()
        {
            orderDao = new OrderDao();
        }




        public bool CheckDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                return false;
            }
            else
            {
                return true;

            }

        }

        public RevenueReport GenerateReport(DateTime startDate, DateTime endDate)
        {


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