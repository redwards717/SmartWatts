using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore.Models
{
    public class Cyclist
    {
        public int CyclistId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Ride> Rides { get; set; }
    }
}
