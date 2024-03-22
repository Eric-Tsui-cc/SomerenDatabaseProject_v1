using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using SomerenDAL;
using SomerenModel;


public class DrinkDao : BaseDao
{
    public List<Drink> GetAllDrinks()
    {
        string query = "SELECT drinkId,name, type, stock FROM Drink";
        SqlParameter[] sqlParameters = new SqlParameter[0];
        return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
    }
    public void UpdateDrink(Drink drink)
    {
        string query = "UPDATE Drink " +
            "SET Name=@Name, Type=@Type, stock=@stock " +
            "WHERE drinkId=@id;";
        SqlParameter[] sqlParameters =
        {
        new SqlParameter("@id", drink.id),
        new SqlParameter("@Name", drink.name),
        new SqlParameter("@Type", drink.type),
        new SqlParameter("@Stock", drink.stock),
        };
        ExecuteEditQuery(query, sqlParameters);
    }

    private List<Drink> ReadDrinks(DataTable dataTable)
    {
        List<Drink> drinks = new List<Drink>();

        foreach (DataRow dr in dataTable.Rows)
        {
            Drink drink = new Drink();

            drink.name = dr["name"].ToString();
            drink.type = dr["type"].ToString();
            drink.stock = (int)dr["stock"];
            drink.id = (int)dr["drinkId"];
            drinks.Add(drink);
        }
        return drinks;
    }
    public void DeleteDrink(Drink drink)
    {
        string query = "DELETE FROM Drink WHERE DrinkId=@id;";
        SqlParameter[] sqlParameters = new SqlParameter[]
        {
            new SqlParameter("@id", drink.id)
        };
        ExecuteEditQuery(query, sqlParameters);
    }
    public void AddDrink(Drink drink)
    {
        string query = "INSERT INTO Drink (DrinkID, Name, Type, Stock, Price) VALUES (@DrinkID, @Name, @Type, @Stock, @Price);";
        SqlParameter[] sqlParameters =
        {
            new SqlParameter("@DrinkID", drink.id),
            new SqlParameter("@Name", drink.name),
            new SqlParameter("@Type", drink.type),
            new SqlParameter("@Stock", drink.stock),
            new SqlParameter("@Price", drink.price)
        };
        ExecuteEditQuery(query, sqlParameters);
    }
    public Drink GetByName(string name)
    {
        Drink drink = null;
        string query = "SELECT * FROM Drink WHERE Name = @Name;";
        SqlParameter[] sqlParameters = new SqlParameter[]
        {
            new SqlParameter("@Name", name)
        };

        DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

        if (dataTable.Rows.Count > 0)
        {
            DataRow row = dataTable.Rows[0];
            drink = new Drink
            {
                //id = Convert.ToInt32(row["DrinkId"]),
                name = row["Name"].ToString(),
                type = row["Type"].ToString(),
                stock = Convert.ToInt32(row["stock"]),
            };
        }

        return drink;
    }
    public Drink GetById(int id)
    {
        Drink drink = null;
        string query = "SELECT * FROM Drink WHERE DrinkId = @Id;";
        SqlParameter[] sqlParameters = new SqlParameter[]
        {
        new SqlParameter("@Id", id)
        };

        DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

        if (dataTable.Rows.Count > 0)
        {
            DataRow row = dataTable.Rows[0];
            drink = new Drink
            {
                id = Convert.ToInt32(row["DrinkId"]),
                name = row["Name"].ToString(),
                type = row["Type"].ToString(),
                stock = Convert.ToInt32(row["Stock"]),
                
            };
        }

        return drink;
    }
}




