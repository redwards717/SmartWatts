using SmartWattsCore.Models;
using SmartWattsCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWattsUi.Controllers
{
    public class TrainingLogController
    {
        private readonly IIntensityService _intensityService;
        private readonly IPowerCurveServices _powerCurveServices;

        public TrainingLogController(IIntensityService intensityService, IPowerCurveServices powerCurveServices)
        {
            _intensityService = intensityService;
            _powerCurveServices = powerCurveServices;
        }

        public void AppendHighestIntensity(List<Ride> rides)
        {
            _intensityService.AppendHighestIntensity(rides);
        }

        public int GetSinglePowerPointAvg(List<Ride> rides, int pp)
        {
            return _powerCurveServices.CalculateSinglePowerPointAvg(rides, pp);
        }
    }
}
