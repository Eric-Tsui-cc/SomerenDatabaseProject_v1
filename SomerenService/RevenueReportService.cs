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
        private RRDao RRDao;
        public RevenueReportService()
        {
            RRDao = new RRDao();
        }


        public List<Order> GetOrdersBydate(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = RRDao.GetOrdersByDateRange(startDate, endDate);
            return orders;
        }

        public bool CheckDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate && endDate > DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;

            }

        }
        public int GenerateSales(DateTime startDate, DateTime endDate)
        {


            // Retrieve orders within the date range
            List<Order> orders = GetOrdersBydate(startDate, endDate);

            // Calculate revenue report data
            int sales = orders.Sum(order => order.Amount);

            return sales;
        }
        public decimal GenerateTurnover(DateTime startDate, DateTime endDate)
        {


            // Retrieve orders within the date range
            List<Order> orders = GetOrdersBydate(startDate, endDate);

            // Calculate revenue report data
            decimal turnover = orders.Sum(order =>
            {
                Drink drink = order.Drink;
                return drink != null ? order.Amount * drink.price : 0;
            });


            return turnover;
        }

        public int GenerateCustomerCount(DateTime startDate, DateTime endDate)
        {

            // Retrieve orders within the date range
            List<Order> orders = GetOrdersBydate(startDate, endDate);

            int customerCount = orders.Count;

            return customerCount;
        }
    }
}