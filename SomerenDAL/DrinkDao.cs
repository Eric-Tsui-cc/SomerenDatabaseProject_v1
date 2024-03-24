using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SomerenDAL;
using SomerenModel;

public class DrinkDao : BaseDao
{
    public List<Drink> GetAllDrinks()
    {
       string query = "SELECT Name,price,VATType,type,DrinkId,Stock FROM Drink";
        SqlParameter[] sqlParameters = new SqlParameter[0];
        return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));

    }

    private List<Drink> ReadDrinks(DataTable dataTable)
    {
        List<Drink> drinks = new List<Drink>();

        foreach (DataRow dr in dataTable.Rows)
        {
            Drink drink = new Drink();

            drink.DrinkId = (int)dr["DrinkId"]; // no need to retrieve DrinkId again
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
            drinks.Add(drink);
        }
        return drinks;
    }


}

