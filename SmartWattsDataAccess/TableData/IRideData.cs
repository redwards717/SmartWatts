using SmartWattsCore.Models;
using SmartWattsDataAccess.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartWattsDataAccess.TableData
{
    public interface IRideData
    {
        Task DeleteRide(Ride ride);
        Task<List<Ride>> GetRides(int userId, bool withHistory = true);
        Task InsertRide(Ride ride);
        Task InsertRides(List<Ride> rides);
        Task UpdatePowerCurve(List<Ride> rides);
        Task UpdateRide(Ride ride);
    }
}