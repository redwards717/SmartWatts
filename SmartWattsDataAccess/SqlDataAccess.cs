using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartWattsCore;
using Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling;

namespace SmartWattsDataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            var retryStrategy = new FixedInterval(5, TimeSpan.FromSeconds(30));

            var retryPolicy =
              new RetryPolicy<SqlDatabaseTransientErrorDetectionStrategy>(retryStrategy);


            var data = new List<T>();
            await retryPolicy.ExecuteAsync(async () =>
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var result = await connection.QueryAsync<T>(sql, parameters, commandTimeout: 120);
                    data = result.ToList();
                }
            });
            return data;
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
