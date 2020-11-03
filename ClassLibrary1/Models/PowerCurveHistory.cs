using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models
{
    public class PowerCurveHistory
    {
        public Dictionary<int, int> PowerCurve30 { get; set; }
        public Dictionary<int, int> PowerCurve90 { get; set; }
        public Dictionary<int, int> PowerCurve365 { get; set; }
        public Dictionary<int, int> PowerCurveAll { get; set; }
    }
}
