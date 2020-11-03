using SmartWattsDataAccess.DbModels;
using SmartWattsCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartWattsDataAccess.TableData
{
    public interface ICyclistData
    {
        Task<List<Cyclist>> GetUsers();
        Task<string> InsertUser(Cyclist user);
        Task<Cyclist> Login(Cyclist user);
    }
}