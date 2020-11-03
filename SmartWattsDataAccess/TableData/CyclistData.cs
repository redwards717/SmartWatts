using SmartWattsDataAccess.DbModels;
using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWattsDataAccess.TableData
{
    public class CyclistData : ICyclistData
    {
        private readonly ISqlDataAccess _db;

        public CyclistData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Cyclist>> GetUsers()
        {
            string sql = "select * from dbo.Users";

            return _db.LoadData<Cyclist, dynamic>(sql, new { });
        }

        public async Task<string> InsertUser(Cyclist user)
        {

            if (await CheckForDuplicateUsername(user) != 0)
            {
                return "User already exists";
            }

            string sql = @"insert into dbo.Cyclists (Username, Password)
                            values (@Username, @Password)";

            await _db.SaveData(sql, user);

            return "User has been created...Enjoy!";
        }

        public async Task<Cyclist> Login(Cyclist user)
        {
            string sql = @"SELECT * FROM dbo.Cyclists
                            WHERE Username = @Username AND Password = @Password";

            var cyclist = await _db.LoadData<Cyclist, dynamic>(sql, user);

            return cyclist.FirstOrDefault();

        }

        private async Task<int> CheckForDuplicateUsername(Cyclist user)
        {
            string sql = @"select COUNT(1) FROM Cyclists
                           WHERE Username = @Username";

            var result = await _db.LoadData<int, dynamic>(sql, user);

            return result.FirstOrDefault();
                
        }
    }
}
