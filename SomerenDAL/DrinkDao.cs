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
        string query = "SELECT name, price, type, stockOfamount FROM Drink";
        SqlParameter[] sqlParameters = new SqlParameter[0];
        return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
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

