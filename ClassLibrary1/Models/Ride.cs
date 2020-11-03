using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models
{
    public class Ride
    {
        public int RideId { get; set; }
        public RideMetaData RideMetaData { get; set; }
        public List<DataPoint> DataPoints { get; set; }
        public Dictionary<int, int> PowerCurve { get; set; }
        public PowerCurveHistory PowerCurveHistory { get; set; }
        public string RawXml { get; set; }
        public Intensity TopIntensity { get; set; }
        public Cyclist Cyclist { get; set; }
    }
}
