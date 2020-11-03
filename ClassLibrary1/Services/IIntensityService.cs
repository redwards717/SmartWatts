using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Services
{
    public interface IIntensityService
    {
        void AppendHighestIntensity(List<Ride> rides);
        Intensity CalculateIntensity(KeyValuePair<int, int> powerPoint, Ride ride, int timeFrame);
    }
}
