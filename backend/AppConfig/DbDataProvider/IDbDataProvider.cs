using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AppConfig.DbDataProvider
{
    public interface IDbDataProvider
    {
        public MySqlConnection GetConnection();
        public List<T> ProcessQueryResult<T>(MySqlCommand command);
    }

    public class DbDataProvider : IDbDataProvider
    {
        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection("");
            return connection;
        }

        public List<T> ProcessQueryResult<T>(MySqlCommand command)
        {
            var list = new List<T>();
            var classInstance = Activator.CreateInstance<T>();
            var properties = typeof(T).GetProperties();

            var reader = command.ExecuteReader();
            var count = reader.FieldCount;

            while (command.ExecuteNonQuery() != 0)
            {
                if (count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        properties[i].SetValue(classInstance, reader.GetValue(i));
                    }

                    list.Add(classInstance);
                }
            }

            return list;
        }
    }
}