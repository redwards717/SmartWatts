using SmartWattsCore.Models;
using SmartWattsCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWattsUi.Controllers
{
    public class PowerProfileController
    {
        private readonly IPowerCurveServices _powerCurveServices;
        private readonly AppState _appState;

        public PowerProfileController(IPowerCurveServices powerCurveServices, AppState appState)
        {
            _powerCurveServices = powerCurveServices;
            _appState = appState;
            
        }


        public Dictionary<int, int> GetPowerCurveHistory(List<Ride> rides, DateTime endDate, int lookBackDays)
        {
            return _powerCurveServices.CalculatePowerCurveHistory(rides, endDate, lookBackDays);
        }


    }
}
