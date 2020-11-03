using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models

{
    public class DataPoint
    {
        public DateTime TimeStamp { get; set; }
        public int Watts { get; set; }
        public int HeartRate { get; set; }
        public int Cadence { get; set; }
    }
}
