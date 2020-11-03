using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsDataAccess.DbModels
{
    public class CyclistDb
    {
        public int CyclistId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
