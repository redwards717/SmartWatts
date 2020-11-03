using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models
{
    public class RideMetaData
    {
        public string RideName { get; set; }
        public DateTime Date { get; set; }
        public int DistanceMeters { get; set; }
        public int TimeSeconds { get; set; }
        public int AvgWatts { get; set; }
        public int AvgCadence { get; set; }
        public int AvgHeartRate { get; set; }
    }
}
