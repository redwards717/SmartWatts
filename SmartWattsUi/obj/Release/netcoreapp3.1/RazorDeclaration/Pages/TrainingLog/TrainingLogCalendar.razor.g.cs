#pragma checksum "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogCalendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "821dccd9903cff94cddc6dd4686aac78d98512c5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SmartWattsUi.Pages.TrainingLog
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using SmartWattsUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\_Imports.razor"
using SmartWattsUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogCalendar.razor"
using SmartWattsCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogCalendar.razor"
using SmartWattsCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogCalendar.razor"
using SmartWattsUi.Services;

#line default
#line hidden
#nullable disable
    public partial class TrainingLogCalendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogCalendar.razor"
       
	List<int> yearsToDisplay = new List<int>();
	int selectedYear;
	int selectedMonth;
	bool dayHoverOn = false;
	int dayHovered;
	List<Ride> hoveredRides;

	DateTime firstDay;
	DateTime lastDay;

	int daysBefore;
	int daysAfter;

	int daysInMonth;

	protected override void OnInitialized()
	{
		var currentDate = DateTime.Now;
		selectedYear = currentDate.Year;
		selectedMonth = currentDate.Month;

		GetYearsWithRides();

		RenderCalendar(selectedYear, selectedMonth);

	}


	private void RenderCalendar(int year, int month)
	{
		firstDay = new DateTime(year, month, 1);
		lastDay = firstDay.AddMonths(1).AddSeconds(-1);

		var firstDayDayOfWeek = (int)firstDay.DayOfWeek;
		var lastDayDayOfWeek = (int)lastDay.DayOfWeek;

		daysBefore = (firstDayDayOfWeek == 0 ? 7 : firstDayDayOfWeek) - 1;
		daysAfter = -((lastDayDayOfWeek == 0 ? 7 : lastDayDayOfWeek) - 7);

		daysInMonth = DateTime.DaysInMonth(year, month);
	}

	private void GetYearsWithRides()
	{
		var uniqueYearRides = _appState.LoggedInUser.Rides.GroupBy(r => r.RideMetaData.Date.Year).Select(g => g.First());
		foreach (var ride in uniqueYearRides)
		{
			yearsToDisplay.Add(ride.RideMetaData.Date.Year);
		}
	}

	private void ViewRide(int day)
	{
		var ride = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date.Month == selectedMonth
												&& r.RideMetaData.Date.Year == selectedYear
												&& r.RideMetaData.Date.Day == day);

		if (ride == null || ride.Count() == 0)
		{
			return;
		}

		var bestEffort = ride.Max(r => r.TopIntensity.EffortIndex);
		var topRide = ride.First(r => r.TopIntensity.EffortIndex == bestEffort);

		_appState.ToggleRideViewWindow(true, topRide);
	}

	private string GetIntensity(int day)
	{
		var rides = GetRidesForTheDay(day);

		if (rides == null || rides.Count() == 0)
		{
			return "white";
		}

		var topIntensity = rides.Max(r => r.TopIntensity.EffortIndex);
		return Constants.Intensities.Find(i => i.EffortIndex == topIntensity).Color;
	}

	private List<Ride> GetRidesForTheDay(int day)
	{
		return _appState.LoggedInUser.Rides.Where(r =>
		r.RideMetaData.Date.Month == selectedMonth && r.RideMetaData.Date.Year == selectedYear && r.RideMetaData.Date.Day == day).ToList();
	}

	private string GetDurationForDay(int day)
	{
		var rides = GetRidesForTheDay(day);
		var sum = rides.Sum(r => r.RideMetaData.TimeSeconds);

		return Helpers.ConvertSecToReadable(sum, false);
	}


	private void ChangeYear(int year)
	{
		selectedYear = year;

		RenderCalendar(selectedYear, selectedMonth);
	}

	private void ChangeMonth(int change)
	{
		var prevMon = selectedMonth;

		var newMonth = prevMon + change;
		if (newMonth == 0)
		{
			selectedMonth = 12;
			selectedYear--;
		}
		else if (newMonth == 13)
		{
			selectedMonth = 1;
			selectedYear++;
		}
		else
		{
			selectedMonth = newMonth;
		}

		RenderCalendar(selectedYear, selectedMonth);
	}

	private void ShowRides(int day)
	{
		hoveredRides = new List<Ride>();
		dayHovered = day;
		dayHoverOn = true;
		hoveredRides = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date.Month == selectedMonth
												&& r.RideMetaData.Date.Year == selectedYear
												&& r.RideMetaData.Date.Day == day).ToList();
	}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RideServices _rideServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
    }
}
#pragma warning restore 1591