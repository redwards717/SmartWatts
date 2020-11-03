using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models
{
    public class Intensity
    {
        public string Description { get; set; }
        public string Color { get; set; }
        public float LowBand { get; set; }
        public float HighBand { get; set; }
        public int EffortIndex { get; set; }
    }
}
