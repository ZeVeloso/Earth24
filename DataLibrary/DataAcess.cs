using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAcess : IDataAcess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows =await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }

        }
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
               return  connection.ExecuteAsync(sql, parameters);
            }

        }

    }
}
