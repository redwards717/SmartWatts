using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace SmartWattsCore.Services
{
    public class IntensityService : IIntensityService
    {
        public IntensityService()
        {

        }

        public Intensity CalculateIntensity(KeyValuePair<int, int> powerPoint, Ride ride, int timeFrame)
        {
            var powerNow = powerPoint.Value;
            int powerHistory = 0;
            if (ride.PowerCurveHistory == null)
            {
                return null;
            }


            if (timeFrame == 30)
            {
                powerHistory = ride.PowerCurveHistory.PowerCurve30.FirstOrDefault(pc30 => pc30.Key == powerPoint.Key).Value;
            }
            else if (timeFrame == 90)
            {
                powerHistory = ride.PowerCurveHistory.PowerCurve90.FirstOrDefault(pc90 => pc90.Key == powerPoint.Key).Value;
            }
            else if (timeFrame == 365)
            {
                powerHistory = ride.PowerCurveHistory.PowerCurve365.FirstOrDefault(pc365 => pc365.Key == powerPoint.Key).Value;
            }
            else if (timeFrame == 9999)
            {
                powerHistory = ride.PowerCurveHistory.PowerCurveAll.FirstOrDefault(pcall => pcall.Key == powerPoint.Key).Value;
            }

            if (powerHistory == 0)
            {
                return null;
            }

            float percent = powerNow / (float)powerHistory;

            return Constants.Intensities.Find(i => percent >= i.LowBand && percent < i.HighBand);

        }

        public void AppendHighestIntensity(List<Ride> rides)
        {
            int powerHistory = 0;

            foreach (var ride in rides)
            {
                List<float> percents = new List<float>();

                foreach(var powerPoint in ride.PowerCurve)
                {
                    powerHistory = ride.PowerCurveHistory.PowerCurve30.FirstOrDefault(pc30 => pc30.Key == powerPoint.Key).Value;
                    powerHistory = powerHistory == 0 ? 1 : powerHistory;

                    float percent = powerPoint.Value / (float)powerHistory;
                    percents.Add(percent);
                }

                var highestPercent = percents.Max();

                ride.TopIntensity = Constants.Intensities.Find(i => highestPercent >= i.LowBand && highestPercent < i.HighBand);
            }
        }

	}
}
