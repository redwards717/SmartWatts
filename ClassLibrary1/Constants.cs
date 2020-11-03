using SmartWattsCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWattsCore
{
    public static class Constants
    {
        public static List<int> PowerPoints { get; } = new List<int>(){
            5, 15, 30, 45, 60, 90, 60 * 2, 60 * 3, 60 * 5, 60 * 7 + 30, 60 * 10, 60 * 15, 60 * 20, 60 * 30, 60 * 45, 60 * 60, 60 * 90, 60 * 60 * 2, 60 * 60 * 3, 60 * 60 * 4, 60 * 60 * 5
        };

        public static List<Intensity> Intensities { get; } = new List<Intensity>()
        {
            new Intensity()
            {
                Description = "Well Above Target Intensity, Phenomenal Effort!",
                Color = "purple",
                LowBand = 1.1F,
                HighBand = 10000F,
                EffortIndex = 5
            },
            new Intensity()
            {
                Description = "Above Target Intensity, Great Effort",
                Color = "red",
                LowBand = 1.05F,
                HighBand = 1.1F,
                EffortIndex = 4
            },
            new Intensity()
            {
                Description = "Target Intensity Hit, Good Effort",
                Color = "orange",
                LowBand = 1.00F,
                HighBand = 1.05F,
                EffortIndex = 3
            },
            new Intensity()
            {
                Description = "Just Below Target Intensity (Maintaining)",
                Color = "yellow",
                LowBand = .92F,
                HighBand = 1.00F,
                EffortIndex = 2
            },
            new Intensity()
            {
                Description = "Below Target (Not Pushing)",
                Color = "grey",
                LowBand = .60F,
                HighBand = .92F,
                EffortIndex = 1
            },
            new Intensity()
            {
                Description = "Easy Effort (Recovery)",
                Color = "green",
                LowBand = 0.00F,
                HighBand = .60F,
                EffortIndex = 0
            },
        };

        public static List<string> DaysOfTheWeek { get; } = new List<string>()
        {
            "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"
        };

        public enum Months { 
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
