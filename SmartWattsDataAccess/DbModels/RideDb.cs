using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsDataAccess.DbModels
{
    class RideDb
    {
        public int RideId { get; set; }
        public string RideName { get; set; }
        public DateTime Date { get; set; }
        public int DistanceMeters { get; set; }
        public int TimeSeconds { get; set; }
        public int AvgWatts { get; set; }
        public int AvgCadence { get; set; }
        public int AvgHeartRate { get; set; }
        public string PowerCurveJson { get; set; }
        public string RawXml { get; set; }
        public int CyclistId { get; set; }
        public CyclistDb Cyclist { get; set; }
    }
}
