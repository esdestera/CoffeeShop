using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectionClass
/// </summary>
public static class ConnectionClass
{
    private static SqlConnection _connection;
    private static SqlCommand _command;

    static ConnectionClass()
    {
        var connectionString = ConfigurationManager.ConnectionStrings["CoffeeDBConnectionString"].ToString();
        _connection = new SqlConnection(connectionString);
        _command = new SqlCommand("", _connection);
    }

    public static IList<Coffee> GetCoffeeByType(string coffeeType)
    {
        var list = new List<Coffee>();
        var query = string.Format("Select * from Coffee where type LIKE '{0}'", coffeeType);
        try
        {
            _connection.Open();
            _command.CommandText = query;
            SqlDataReader reader = _command.ExecuteReader();

            while (reader.Read())
            {
                var coffee = new Coffee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetDouble(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                    reader.GetString(7));
                list.Add(coffee);
            }
        }
        finally
        {
            _connection.Close();
        }

        return list;
    }
}