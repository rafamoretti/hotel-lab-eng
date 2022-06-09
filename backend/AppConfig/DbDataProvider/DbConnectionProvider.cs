using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace AppConfig.DbDataProvider
{
    public class DbConnectionProvider : IDisposable
    {
        public IDbConnection Connection { get; }

        public DbConnectionProvider(IConfiguration configuration)
        {
            Connection = new MySqlConnection(configuration.GetConnectionString("Default"));
        }

        public void Dispose()
            => Connection?.Dispose();
            
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