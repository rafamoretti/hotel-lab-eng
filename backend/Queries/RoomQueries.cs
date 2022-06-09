using System;
using System.Collections.Generic;
using AppConfig.DbDataProvider;
using Queries.QueriesInterface;
using System.Linq;
using Dapper;
using Queries.Resources;
using Queries.DataTransferObjects;

namespace Queries
{
    public class RoomQueries : IRoomQueries
    {
        private readonly DbConnectionProvider _provider;

        public RoomQueries(DbConnectionProvider provider)
        {
            _provider = provider;
        }

        public List<RoomData> GetGuestRoom(int id)
        {
            return ExecuteQuery<RoomData>(QuerieResources.RoommQuerie, new { Id = id });
        }

        public List<T> ExecuteQuery<T>(string query, object arguments)
        {
            using (var conn = _provider.Connection)
            {
                var data = conn.Query<T>(query, arguments).ToList();
                return data;
            }
        }
    }
}