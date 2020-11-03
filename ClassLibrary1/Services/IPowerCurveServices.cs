using SmartWattsCore.Models;
using System;
using System.Collections.Generic;

namespace SmartWattsCore.Services
{
    public interface IPowerCurveServices
    {

        Ride AddPowerCurveHistoryToRide(List<Ride> rides, Ride ride);
        Intensity CalculateIntensity(KeyValuePair<int, int> powerPoint, Ride ride, int timeFrame);
        Dictionary<int, int> CalculatePowerCurve(List<DataPoint> dataPoints);
        Dictionary<int, int> CalculatePowerCurveHistory(List<Ride> rides, DateTime endDate, int lookBackDays, int longestInterval = 86400);
        int CalculateSinglePowerPointAvg(List<Ride> rides, int pp);
    }
}