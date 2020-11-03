using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace SmartWattsCore
{
    public static class Helpers
    {
        public static string ConvertSecToReadable(int secs, bool includeSeconds = true)
        {

            var hours = (int)(secs / 3600);
            var secsLeftInHour = secs % 3600;
            var minutes = (int)(secsLeftInHour / 60);
            var seconds = secsLeftInHour % 60;

            var strHours = hours >= 1 ? $"{hours}h" : "";
            var strMins = minutes >= 1 ? $"{minutes}m" : "";
            var strSecs = seconds >= 1 ? $"{seconds}s" : "";

            if (includeSeconds)
            {
                return strHours + strMins + strSecs;
            }
            else
            {
                return strHours + strMins;
            }
        }

        public static string ConvertSecToReadableLong(int secs)
        {

            var hours = (int)(secs / 3600);
            var secsLeftInHour = secs % 3600;
            var minutes = (int)(secsLeftInHour / 60);
            var seconds = secsLeftInHour % 60;

            var strHours = hours >= 1 ? $"{hours} Hours" : "";
            var strMins = minutes >= 1 ? $"{minutes} Mins" : "";

            return strHours + " " + strMins;
        }

        public static double ConvertMetersToMiles(int meters)
        {
            var miles = meters * 0.000621371;
            return Math.Truncate(100 * miles) / 100;
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public static int FindBestsAvg(List<int> numbers, int bestOf = 3)
        {
            var result = new List<int>();
            for(int i = 1; i <= bestOf; i++)
            {
                var max = numbers.Count() != 0 ? numbers.Max() : 0;
                numbers.Remove(max);

                result.Add(max);
            }

            return result.Sum() / bestOf;
        }

    }
}
