using System;
using System.Collections.Generic;
using AppConfig;
using AppConfig.DbDataProvider;
using Queries.DataTransferObjects;
using Queries.QueriesInterface;
using Queries.Resources;
using MySql.Data.MySqlClient;
using System.Data;

namespace Queries
{
    public class RoomQueries : IRoomQueries
    {
        private readonly IDbDataProvider _dbDataProvider;

        public RoomQueries(IDbDataProvider dbDataProvider)
        {
            _dbDataProvider = dbDataProvider;
        }

        private readonly AppDbContext _context;

        public List<GuestRoomDTO> GetGuestRoom(Guid id)
        {
            return ExecuteQuery<GuestRoomDTO>(QuerieResources.RoommQuerie);
        }

        public List<T> ExecuteQuery<T>(string query)
        {
            var conn = _dbDataProvider.GetConnection();
            conn.Open();
            
            var command = new MySqlCommand();
            command.CommandText = query;
            command.Prepare();

            return _dbDataProvider.ProcessQueryResult<T>(command);
        }
    }
}