using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenDAL;
using SomerenModel;

public class DrinkDao : BaseDao
{
    public List<Drink> GetAllDrinks()
    {
        //string query = "SELECT name, price, type, stockOfamount FROM Drink";
        //SqlParameter[] sqlParameters = new SqlParameter[0];
        //return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        // Create a mock DataTable object
        DataTable mockDataTable = new DataTable();
        mockDataTable.Columns.Add("name", typeof(string));
        mockDataTable.Columns.Add("price", typeof(decimal));
        mockDataTable.Columns.Add("type", typeof(string));
        mockDataTable.Columns.Add("stockOfamount", typeof(int));

        // Add some mock data rows
        mockDataTable.Rows.Add("Coffee", 2.50m, "Hot", 10);
        mockDataTable.Rows.Add("Tea", 1.80m, "Hot", 5);
        // Add more data rows to simulate real data

        // Call the ReadDrinks method and return the result
        return ReadDrinks(mockDataTable);
    }

    private List<Drink> ReadDrinks(DataTable dataTable)
    {
        List<Drink> drinks = new List<Drink>();

        foreach (DataRow dr in dataTable.Rows)
        {
            Drink drink = new Drink();

            drink.name = dr["name"].ToString();
            drink.price = (decimal)dr["price"];
            drink.type = dr["type"].ToString();
            drink.stockOfamount = (int)dr["stockOfamount"];
            drinks.Add(drink);
        }
        return drinks;
    }
}

