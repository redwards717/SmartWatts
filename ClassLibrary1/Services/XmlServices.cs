using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using SmartWattsCore.Models;

namespace SmartWattsCore.Services
{
    public class XmlServices : IXmlServices
    {
        public Ride ParseTcx(MemoryStream xmlMs)
        {
            string xmlContents = GetXmlAsString(xmlMs);

            var ride = new Ride();
            ride.DataPoints = new List<DataPoint>();

            ride.RawXml = xmlContents;

            var dataPoints = xmlContents.Split("Trackpoint");
            ride.RideMetaData = GetTcxMetaData(dataPoints[0]);

            var prevDataPoint = new DataPoint();

            for (int i = 1; i <= dataPoints.Count() - 2; i++)
            {
                if (dataPoints[i] == "><")
                {
                    continue;
                }

                var dataPoint = new DataPoint();
                dataPoint.TimeStamp = Convert.ToDateTime(GetValue("Time", dataPoints[i]));
                dataPoint.Watts = (int)float.Parse(GetValue("Watts", dataPoints[i]));


                if (i > 1)
                {
                    AddMissingDataPoints(dataPoint, prevDataPoint, ride.DataPoints);
                }
                prevDataPoint = dataPoint;
                ride.DataPoints.Add(dataPoint);
            }

            return ride;
        }

        public Ride ParseGpx(MemoryStream xmlMs)
        {
            string xmlContents = GetXmlAsString(xmlMs);

            var ride = new Ride();
            ride.DataPoints = new List<DataPoint>();

            ride.RawXml = xmlContents;

            var dataPoints = xmlContents.Split("trkpt");

            ride.RideMetaData = GetGpxMetaData(dataPoints[0]);


            var prevDataPoint = new DataPoint();

            for (int i = 1; i <= dataPoints.Count() - 2; i++)
            {
                if (dataPoints[i] == "><")
                {
                    continue;
                }

                var dataPoint = new DataPoint();

                dataPoint.TimeStamp = Convert.ToDateTime(GetValue("time", dataPoints[i]));
                dataPoint.Watts = int.Parse(GetValue("power", dataPoints[i]));

                if (i > 5)
                {
                    AddMissingDataPoints(dataPoint, prevDataPoint, ride.DataPoints);
                }
                prevDataPoint = dataPoint;
                ride.DataPoints.Add(dataPoint);
            }

            return ride;
        }

        private RideMetaData GetGpxMetaData(string xmlMetaString)
        {
            var rideMetaData = new RideMetaData();

            rideMetaData.Date = Convert.ToDateTime(GetValue("time", xmlMetaString));
            rideMetaData.RideName = GetValue("name", xmlMetaString);

            return rideMetaData;
        }

        private RideMetaData GetTcxMetaData(string xmlMetaString)
        {
            var rideMetaData = new RideMetaData();

            rideMetaData.AvgCadence = (int)float.Parse(GetValue("Cadence", xmlMetaString));
            rideMetaData.AvgHeartRate = (int)float.Parse(GetValue("Value", xmlMetaString));
            rideMetaData.AvgWatts = (int)float.Parse(GetValue("AverageWatts", xmlMetaString));
            rideMetaData.Date = Convert.ToDateTime(GetValue("Id", xmlMetaString));
            rideMetaData.DistanceMeters = (int)float.Parse(GetValue("DistanceMeters", xmlMetaString));
            rideMetaData.TimeSeconds = int.Parse(GetValue("TotalTimeSeconds", xmlMetaString));

            return rideMetaData;
        }

        private void AddMissingDataPoints(DataPoint dataPoint, DataPoint prevDataPoint, List<DataPoint> ride)
        {
            var timeFromLastPoint = (dataPoint.TimeStamp - prevDataPoint.TimeStamp).TotalSeconds;
            if(timeFromLastPoint > 1 || timeFromLastPoint <= 5)
            {
                for (int k = 1; k < timeFromLastPoint; k++)
                {
                    var missingDataPoint = new DataPoint();
                    missingDataPoint.TimeStamp = prevDataPoint.TimeStamp.AddSeconds(k);
                    missingDataPoint.Watts = (int)((prevDataPoint.Watts + dataPoint.Watts) / 2);
                    ride.Add(missingDataPoint);
                }
            }
            else if (timeFromLastPoint > 10)
            {
                for (int k = 1; k < timeFromLastPoint; k++)
                {
                    var missingDataPoint = new DataPoint();
                    missingDataPoint.TimeStamp = prevDataPoint.TimeStamp.AddSeconds(k);
                    missingDataPoint.Watts = 0;
                    ride.Add(missingDataPoint);
                }
            }
        }

        private string GetXmlAsString(MemoryStream xmlMs)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlMs);
            return xmlDoc.InnerXml;
        }

        private string GetValue(string key, string dataPoint)
        {
            if (!dataPoint.Contains(key))
            {
                return "0";
            }
            return dataPoint.Split($"{key}>")[1].Split("<")[0];
            //return dataPoint.Split($"{key}>")[1].Replace("<", "").Replace("/", "");
        }
    }
}
