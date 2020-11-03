using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartWattsCore.Services
{
    public class PowerCurveServices : IPowerCurveServices
    {


        public Dictionary<int, int> CalculatePowerCurve(List<DataPoint> dataPoints)
        {
            Dictionary<int, int> powerCurve = new Dictionary<int, int>();
            Dictionary<int, List<int>> rollingWatts = new Dictionary<int, List<int>>();
            var totalSeconds = dataPoints.Count;

            var powerPointsInRide = Constants.PowerPoints.Where(pp => pp <= totalSeconds);

            foreach (int pp in powerPointsInRide)
            {
                rollingWatts.Add(pp, new List<int>());
                powerCurve.Add(pp, 0);
            }

            for (int i = 0; i < dataPoints.Count; i++)
            {
                foreach (int pp in powerPointsInRide)
                {
                    rollingWatts[pp].Add(dataPoints[i].Watts);
                    if (rollingWatts[pp].Count >= pp)
                    {
                        var rollingAvg = rollingWatts[pp].Sum() / pp;
                        if (powerCurve[pp] < rollingAvg)
                        {
                            powerCurve[pp] = rollingAvg;
                        }
                        rollingWatts[pp].RemoveAt(0);
                    }
                }
            }

            return powerCurve;
        }

        public Ride AddPowerCurveHistoryToRide(List<Ride> rides, Ride ride)
        {
            var rideDate = ride.RideMetaData.Date;
            var longestInterval = ride.PowerCurve.Keys.Max();

            ride.PowerCurveHistory = new PowerCurveHistory();
            ride.PowerCurveHistory.PowerCurve30 = CalculatePowerCurveHistory(rides, rideDate, 30, longestInterval);
            ride.PowerCurveHistory.PowerCurve90 = CalculatePowerCurveHistory(rides, rideDate, 90, longestInterval);
            ride.PowerCurveHistory.PowerCurve365 = CalculatePowerCurveHistory(rides, rideDate, 365, longestInterval);
            ride.PowerCurveHistory.PowerCurveAll = CalculatePowerCurveHistory(rides, rideDate, 9999, longestInterval);

            return ride;
        }

        public Dictionary<int, int> CalculatePowerCurveHistory(List<Ride> rides, DateTime endDate, int lookBackDays, int longestInterval = 60 * 60 * 24)
        {

            var adjEndDate = endDate.AddMinutes(-10);
            var startDate = endDate.AddDays(-lookBackDays);

            var ridesInRange = rides.Where(r => r.RideMetaData.Date >= startDate && r.RideMetaData.Date <= adjEndDate).ToList();

            Dictionary<int, List<int>> bestPower = new Dictionary<int, List<int>>();
            foreach(var pp in Constants.PowerPoints)
            {
                if(pp <= longestInterval)
                {
                    bestPower.Add(pp, new List<int>() { 0,0,0 });
                }
            }

            foreach(var r in ridesInRange)
            {
                foreach(var pp in bestPower)
                {
                    var powerPoint = r.PowerCurve.Where(pc => pc.Key == pp.Key).FirstOrDefault();
                    if(powerPoint.Value > pp.Value.Min())
                    {
                        pp.Value.Remove(pp.Value.Min());
                        pp.Value.Add(powerPoint.Value);
                    }
                }
            }

            Dictionary<int, int> bestPowerAvg = new Dictionary<int, int>();

            foreach(var bp in bestPower)
            {
                var avg = (int)(bp.Value.Sum() / 3);
                bestPowerAvg.Add(bp.Key, avg);
            }

            return bestPowerAvg;
        }

        public int CalculateSinglePowerPointAvg(List<Ride> rides, int pp)
        {
            var powerValues = new List<int>();
            foreach(var ride in rides)
            {
                var value = ride.PowerCurve.FirstOrDefault(pc => pc.Key == pp).Value;
                powerValues.Add(value);
            }

            return Helpers.FindBestsAvg(powerValues);
        }

        public Intensity CalculateIntensity(KeyValuePair<int, int> powerPoint, Ride ride, int timeFrame)
        {
            var powerNow = powerPoint.Value;
            int powerHistory = 0;
            if(ride.PowerCurveHistory == null)
            {
                return null;
            }


            if(timeFrame == 30)
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
            else if(timeFrame == 9999)
            {
                powerHistory = ride.PowerCurveHistory.PowerCurveAll.FirstOrDefault(pcall => pcall.Key == powerPoint.Key).Value;
            }

            powerHistory = powerHistory == 0 ? 1 : powerHistory;

            float percent = powerNow / (float)powerHistory;

            foreach(var intensity in Constants.Intensities)
            {
                if(percent >= intensity.LowBand && percent < intensity.HighBand)
                {
                    return intensity;
                }
            }

            return null;
        }
    }
}
