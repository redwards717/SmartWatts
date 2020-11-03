using Blazor.FileReader;
using SmartWattsCore.Models;
using SmartWattsCore.Services;
using SmartWattsDataAccess.DbModels;
using SmartWattsDataAccess.TableData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWattsUi.Controllers
{
    public class RideController
    {
        private readonly IXmlServices _xmlServices;
        private readonly IPowerCurveServices _powerCurveServices;
        private readonly IIntensityService _intensityService;
        private readonly IRideData _rideData;
        private readonly AppState _appState;

        public RideController(IXmlServices xmlServices, IPowerCurveServices powerCurveServices, IIntensityService intensityService, IRideData rideData, AppState appState)
        {
            _xmlServices = xmlServices;
            _powerCurveServices = powerCurveServices;
            _intensityService = intensityService;
            _rideData = rideData;
            _appState = appState;
        }

        public async Task<Ride> ParseRideFile(IFileReference fileRef)
        {
			var ride = new Ride();

			var fileInfo = await fileRef.ReadFileInfoAsync();
			var fileInRam = await fileRef.CreateMemoryStreamAsync(4096);

			if (fileInfo.Name.Contains(".tcx"))
			{
				ride = _xmlServices.ParseTcx(fileInRam);
			}
			else if (fileInfo.Name.Contains(".gpx"))
			{
				ride = _xmlServices.ParseGpx(fileInRam);
			}

			ride.RideMetaData.RideName = String.IsNullOrWhiteSpace(ride.RideMetaData.RideName) ? fileInfo.Name : ride.RideMetaData.RideName;
			ride.RideMetaData.TimeSeconds = ride.DataPoints.Count();

			ride.PowerCurve = _powerCurveServices.CalculatePowerCurve(ride.DataPoints);

			return ride;
		}

		public async Task InsertRide(Ride ride)
        {
			await _rideData.InsertRide(ride);
        }

		public async Task InsertRides(List<Ride> rides)
		{
			await _rideData.InsertRides(rides);
		}

		public async Task<List<Ride>> GetRides(int userId)
        {
			return await _rideData.GetRides(userId);
        }

		public async Task UpdateRide(Ride ride)
        {
			ride.Cyclist = _appState.LoggedInUser;
			await _rideData.UpdateRide(ride);
        }

		public async Task UpdatePowerCurve(List<Ride> rides)
		{
			await _rideData.UpdatePowerCurve(rides);
		}

		public async Task DeleteRide(Ride ride)
        {
			await _rideData.DeleteRide(ride);
        }

		public Intensity GetIntensity(KeyValuePair<int, int> powerPoint, Ride ride, int timeFrame)
        {
			return _intensityService.CalculateIntensity(powerPoint, ride, timeFrame);
        }

		public Ride GetPowerCurveHistory(Ride ride)
        {
			return _powerCurveServices.AddPowerCurveHistoryToRide(_appState.LoggedInUser.Rides, ride);
        }
    }
}
