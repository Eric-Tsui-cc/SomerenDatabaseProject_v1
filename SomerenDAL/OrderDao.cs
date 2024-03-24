using SomerenModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT Orders.Amount, Orders.OrderDate,Orders.OrderTime, Student.*, Drink.* FROM Orders JOIN Student ON Orders.StudentNumber = Student.StudentNumber JOIN Drink ON Orders.DrinkId = Drink.DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Order> ReadOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int quantity = (int)dr["Amount"];
                DateTime orderDate = (DateTime)dr["OrderDate"];
                TimeSpan orderTime = (TimeSpan)dr["orderTime"];
                Student student = ReadTablesStudent(dr);
                Drink drink = ReadDrinks(dr);

                // Create Order object
                Order order = new Order(student, drink, quantity, orderDate, orderTime);
                orders.Add(order);
            }

            return orders;
        }

        private Student ReadTablesStudent(DataRow dr)
        {
            Student student = new Student()
            {
                Number = (int)dr["Studentnumber"],
                FirstName = dr["FirstName"].ToString(),
                LastName = dr["LastName"].ToString(),
                TelePhoneNumber = dr["TelePhoneNumber"].ToString(),
                RoomNumber = dr["RoomNumber"].ToString(),
                Class = dr["Class"].ToString(),
            };

            return student;
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

            drink.Stock = (int)dr["Stock"];
            return drink;
        }
        public void CreateOrder(Student student, Drink drink, int Amount, DateTime dateOfOrder, TimeSpan timeOfOrder)
        {
            AddOrder(student, drink, Amount, dateOfOrder, timeOfOrder);
            ChangeStock(drink, Amount);
        }
        public void AddOrder(Student student, Drink drink, int quantity, DateTime dateOfOrder, TimeSpan timeOfOrder)
        {
            string query = "INSERT INTO Orders (Studentnumber, DrinkId, Amount, OrderDate, OrderTime) VALUES (@studentNumber, @drinkId, @quantity, @orderDate, @orderTime)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@studentNumber", SqlDbType.Int) {Value = student.Number},
                new("@drinkId", SqlDbType.Int) {Value = drink.DrinkId},
                new("@quantity", SqlDbType.Int) {Value = quantity},
                new("@orderDate", SqlDbType.Date) {Value = dateOfOrder},
                new("@orderTime", SqlDbType.Time) {Value = timeOfOrder}

            };

            ExecuteEditQuery(query, parameters);
        }

        private void ChangeStock(Drink drink, int quantity)
        {

            string query = "UPDATE Drink SET stock = stock - @quantity WHERE DrinkId = @drinkId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@quantity", SqlDbType.Int) {Value = quantity},
                new("@drinkId", SqlDbType.Int) {Value = drink.DrinkId}
            };

            ExecuteEditQuery(query, parameters);
        }
        public bool OrderExists(int studentNumber, int drinkId)
        {
            string query = "SELECT EXISTS(SELECT 1 FROM Orders WHERE StudentNumber = @studentNumber AND DrinkId = @drinkId)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                 new("@studentNumber", SqlDbType.Int) { Value = studentNumber },
                 new("@drinkId", SqlDbType.Int) { Value = drinkId }
            };

            object result = ExecuteScalarQuery(query, parameters);
            return (result != null) && (int)result == 1;
        }


        public void ifOrderExists(Drink drink, int amount, Student student)
        {
            string query = "UPDATE Orders SET Amount = Amount + @quantity WHERE StudentNumber = @studentNumber";

            SqlParameter[] parameters = new SqlParameter[]
{
                new("@quantity", SqlDbType.Int) {Value = amount},
                new("@drinkId", SqlDbType.Int) {Value = drink.DrinkId},
                new("@studentNumber", SqlDbType.Int){Value = student.Number}
};
            ExecuteEditQuery(query, parameters);

        }
    }
}
