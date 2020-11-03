using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWattsCore;

namespace SmartWattsUi.Services
{
    public class RideServices
    {
        private readonly AppState _appState;

        public RideServices(AppState appState)
        {
            _appState = appState;
        }

        public List<int> GetYearsWithRides(List<Ride> rides = null)
        {
            rides = rides == null ? _appState.LoggedInUser.Rides : rides;

            var years = new List<int>();

            var uniqueYearRides = _appState.LoggedInUser.Rides.GroupBy(r => r.RideMetaData.Date.Year).Select(g => g.First());
            foreach (var ride in uniqueYearRides)
            {
                years.Add(ride.RideMetaData.Date.Year);
            }

            return years;
        }

        public IEnumerable<Ride> FilterByMonth(int month, int year, List<Ride> rides = null)
        {
            rides = rides == null ? _appState.LoggedInUser.Rides : rides;

            return rides.Where(r => r.RideMetaData.Date.Month == month && r.RideMetaData.Date.Year == year);
        }

        public IEnumerable<Ride> FilterByYear(int year, List<Ride> rides = null)
        {
            rides = rides == null ? _appState.LoggedInUser.Rides : rides;

            return rides.Where(r => r.RideMetaData.Date.Year == year && r.RideMetaData.Date.Year == year);
        }


        public IEnumerable<Ride> FilterByWeek(DateTime date, List<Ride> rides = null)
        {
            rides = rides == null ? _appState.LoggedInUser.Rides : rides;

            var weekStart = Helpers.StartOfWeek(date);
            return rides.Where(r => r.RideMetaData.Date > weekStart);
        }

        
    }
}
