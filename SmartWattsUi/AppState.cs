using Microsoft.AspNetCore.Components;
using SmartWattsCore.Models;
using SmartWattsDataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace SmartWattsUi
{
    public class AppState
    {
        public Cyclist LoggedInUser { get; set; }
        public bool Loading { get; set; }
        public string LoadingText { get; set; }
        public bool AddWindow { get; set; }
        public bool RideView { get; set; }
        public Ride RideToView { get; set; }
   
        public event Action OnChange;

        public void SetUser(Cyclist user)
        {
            LoggedInUser = user;
            NotifyStateChanged();
        }

        public void LogOut()
        {
            LoggedInUser = null;
            NotifyStateChanged();
        }

        public void ToggleLoader(bool loading, string msg = "")
        {
            Loading = loading;
            LoadingText = msg;
            NotifyStateChanged();
        }

        public void ToggleAddWindow(bool addWindow)
        {
            AddWindow = addWindow;
            NotifyStateChanged();
        }

        public void ToggleRideViewWindow(bool rideView, Ride ride)
        {
            RideView = rideView;
            RideToView = ride;
            NotifyStateChanged();
        }

        public void AppendRide(List<Ride> rides)
        {
            LoggedInUser.Rides.AddRange(rides);
            LoggedInUser.Rides.Sort((x, y) => DateTime.Compare(y.RideMetaData.Date, x.RideMetaData.Date));
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
