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
            "WHERE drinkId=@drinkid;";
        SqlParameter[] sqlParameters =
        {
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
    public Drink GetByName(Drink drink)
    {
        string query = "SELECT * FROM Drink WHERE Name = @Name";
        SqlParameter[] sqlParameters =
        {
            new SqlParameter("@Name", drink.name)
        };
        SqlDataReader reader = command.ExecuteReader();
        Customer customer = null;
        if (reader.Read())
        {
            customer = ReadCustomer(reader);
        }
        reader.Close();
        return (ExecuteSelectQuery(query, sqlParameters));

    }
    public Customer GetById(int customerId)
    {
        DbConnection.Open();
        SqlCommand command = new SqlCommand(
        "SELECT * FROM Customers WHERE Id = @Id", DbConnection);
        command.Parameters.AddWithValue("@Id", customerId);
        SqlDataReader reader = command.ExecuteReader();
        Customer customer = null;
        if (reader.Read())
        {
            customer = ReadCustomer(reader);
        }
        reader.Close();
        DbConnection.Close();
        return customer;
    }
}

