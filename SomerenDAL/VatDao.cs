using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class VatDao : BaseDao
    {

        public List<Order> GetOrdersByQuarter(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT 
                        Orders.DrinkId,
                        Orders.Amount,
                        Orders.OrderDate,
                        Drink.* 
                     FROM Orders
                     JOIN Drink ON Orders.DrinkId = Drink.DrinkId 
                     WHERE Orders.OrderDate >= @startDate AND Orders.OrderDate <= @endDate";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@startDate", SqlDbType.Date) { Value = startDate },
        new SqlParameter("@endDate", SqlDbType.Date) { Value = endDate }
            };

            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        private Drink ReadDrinks(DataRow dr)
        {
            Drink drink = new Drink();
            drink.DrinkId = (int)dr["DrinkId"];
            drink.name = dr["name"].ToString();
            drink.price = (decimal)dr["price"];
            drink.type = dr["type"].ToString();

            if (dr["VATType"] == DBNull.Value)
            {
                drink.Vat = Convert.ToInt32(null);
            }
            else
            {
                drink.Vat = (int)dr["VATType"];
            }

            drink.stock = (int)dr["Stock"];
            return drink;
        }

        private List<Order> ReadOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int quantity = (int)dr["Amount"];
                DateTime orderDate = (DateTime)dr["OrderDate"];
                Drink drink = ReadDrinks(dr);

                // Create Order object
                Order order = new Order(drink, quantity, orderDate);
                orders.Add(order);
            }

            return orders;
        }

    }
}

