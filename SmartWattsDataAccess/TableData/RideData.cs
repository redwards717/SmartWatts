using Newtonsoft.Json;
using SmartWattsCore.Models;
using SmartWattsCore.Services;
using SmartWattsDataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartWattsDataAccess.TableData
{
    public class RideData : IRideData
    {
        private readonly ISqlDataAccess _db;
        private readonly IPowerCurveServices _powerCurveServices;

        public RideData(ISqlDataAccess db, IPowerCurveServices powerCurveServices)
        {
            _db = db;
            _powerCurveServices = powerCurveServices;
        }

        public async Task InsertRide(Ride ride)
        {
            RideDb rideDb = ConvertRidetoRideDb(ride);

            string sql = @"insert into dbo.Rides (Date, DistanceMeters, TimeSeconds, AvgWatts, AvgCadence, AvgHeartRate, CyclistId, PowerCurveJson, RideName)
                            values (@Date, @DistanceMeters, @TimeSeconds, @AvgWatts, @AvgCadence, @AvgHeartRate, @CyclistId, @PowerCurveJson, @RideName)";

            await _db.SaveData(sql, rideDb);
        }
        public async Task InsertRides(List<Ride> rides)
        {
            var dbRides = new List<RideDb>();

            foreach(var ride in rides)
            {
                dbRides.Add(ConvertRidetoRideDb(ride));
            }

            string sql = @"insert into dbo.Rides (Date, DistanceMeters, TimeSeconds, AvgWatts, AvgCadence, AvgHeartRate, CyclistId, PowerCurveJson, RideName)
                            values (@Date, @DistanceMeters, @TimeSeconds, @AvgWatts, @AvgCadence, @AvgHeartRate, @CyclistId, @PowerCurveJson, @RideName)";

            await _db.SaveData(sql, dbRides);
        }

        public async Task UpdateRide(Ride ride)
        {
            RideDb rideDb = ConvertRidetoRideDb(ride);

            string sql = $@"update dbo.Rides set RideName = @RideName
                            where RideId = @RideId";

            await _db.SaveData(sql, rideDb);
        }

        public async Task UpdatePowerCurve(List<Ride> rides)
        {
            var dbrides = new List<RideDb>();
            foreach(var ride in rides)
            {
                RideDb rideDb = ConvertRidetoRideDb(ride);
                dbrides.Add(rideDb);
            }

            string sql = $@"update dbo.Rides set PowerCurveJson = @PowerCurveJson
                            where RideId = @RideId";

            await _db.SaveData(sql, dbrides);
        }


        public async Task<List<Ride>> GetRides(int userId, bool withHistory = true)
        {
            string sql = $@"select RideId, Date, DistanceMeters, TimeSeconds, AvgWatts, AvgCadence,AvgHeartRate,CyclistId, RideName, PowerCurveJson from dbo.Rides
                            WHERE CyclistId = {userId}";

            var dbRides = await _db.LoadData<RideDb, dynamic>(sql, new { });

            var rides = new List<Ride>();

            foreach(var dbRide in dbRides)
            {
                var ride = ConvertRideDbtoRide(dbRide);
                rides.Add(ride);
            }

            if (withHistory)
            {
                foreach (var ride in rides)
                {
                    _powerCurveServices.AddPowerCurveHistoryToRide(rides, ride);          
                }
            }

            rides.Sort((x, y) => DateTime.Compare(y.RideMetaData.Date, x.RideMetaData.Date));

            return rides;
        }

        public async Task DeleteRide(Ride ride)
        {
            string sql = @"delete from dbo.rides
                            where RideId = @RideId";

            await _db.SaveData(sql, ride);


        }

        private RideDb ConvertRidetoRideDb(Ride ride)
        {
            var rideDb = new RideDb();

            rideDb.RideId = ride.RideId;
            rideDb.AvgCadence = ride.RideMetaData.AvgCadence;
            rideDb.AvgHeartRate = ride.RideMetaData.AvgHeartRate;
            rideDb.AvgWatts = ride.RideMetaData.AvgWatts;
            rideDb.Date = ride.RideMetaData.Date;
            rideDb.DistanceMeters = ride.RideMetaData.DistanceMeters;
            rideDb.TimeSeconds = ride.RideMetaData.TimeSeconds;
            rideDb.RideName = ride.RideMetaData.RideName;
            rideDb.CyclistId =  ride.Cyclist.CyclistId;
            rideDb.PowerCurveJson = JsonConvert.SerializeObject(ride.PowerCurve);
            rideDb.RawXml = ride.RawXml;

            return rideDb;
        }

        private Ride ConvertRideDbtoRide(RideDb dbRide)
        {
            var ride = new Ride();
            ride.RideMetaData = new RideMetaData();

            ride.RideId = dbRide.RideId;
            ride.RideMetaData.AvgCadence = dbRide.AvgCadence;
            ride.RideMetaData.AvgHeartRate = dbRide.AvgHeartRate;
            ride.RideMetaData.AvgWatts = dbRide.AvgWatts;
            ride.RideMetaData.Date = dbRide.Date;
            ride.RideMetaData.DistanceMeters = dbRide.DistanceMeters;
            ride.RideMetaData.TimeSeconds = dbRide.TimeSeconds;
            ride.RideMetaData.RideName = dbRide.RideName;
            ride.PowerCurve = JsonConvert.DeserializeObject<Dictionary<int, int>>(dbRide.PowerCurveJson);
            ride.RawXml = dbRide.RawXml;

            return ride;
        }
    }
}
