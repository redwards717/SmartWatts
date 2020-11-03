#pragma checksum "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108906f4b2b83e59fd2cee1d4e753a3b6e3b4eec"
// <auto-generated/>
#pragma warning disable 1591
namespace SmartWattsUi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using SmartWattsUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\SmartWatts\SmartWattsUi\_Imports.razor"
using SmartWattsUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using SmartWattsCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using SmartWattsCore.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using SmartWattsCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using SmartWattsUi.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
using SmartWattsUi.Pages.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/feed")]
    public partial class Feed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "time-frame-selector");
            __builder.AddMarkupContent(2, "\r\n\t\tComparison:\r\n\t\t");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                        timeFrame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => timeFrame = __value, timeFrame));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n\t\t\t");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "30");
            __builder.AddContent(9, "30 Days");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\t\t\t");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "90");
            __builder.AddContent(13, "90 Days");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\t\t\t");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "365");
            __builder.AddContent(17, "1 Year");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\t\t\t");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "9999");
            __builder.AddContent(21, "All Time");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 53 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
     if (_appState.LoggedInUser != null && _appState.LoggedInUser.Rides != null && String.IsNullOrWhiteSpace(loadingMsg))
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\t\t");
            __builder.OpenElement(26, "h5");
            __builder.AddContent(27, " Welcome ");
            __builder.AddContent(28, 
#nullable restore
#line 55 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                      _appState.LoggedInUser.Username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " !");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\t\t");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 57 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
             foreach (var year in yearsToDisplay)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\t\t\t\t");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", 
#nullable restore
#line 59 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                               year == selectedYear ? "month-year-selected" : "month-year"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                                                                       e => ChangeYear(year)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, 
#nullable restore
#line 59 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                                                                                               year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 60 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t\t");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "month-year-select");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 63 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
             foreach (var month in Enum.GetNames(typeof(Constants.Months)))
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\t\t\t\t");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", 
#nullable restore
#line 65 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                               month ==  Enum.GetName(typeof(Constants.Months), selectedMonth)? "month-year-selected" : "month-year"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                e => ChangeMonth(month)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, 
#nullable restore
#line 66 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                          month

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 67 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 70 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
         if (displayedRides == null || displayedRides.Count() == 0)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "\t\t\t");
            __builder.OpenElement(53, "h3");
            __builder.AddContent(54, "There are no rides logged for ");
            __builder.AddContent(55, 
#nullable restore
#line 72 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                Enum.GetName(typeof(Constants.Months), selectedMonth)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(56, " ");
            __builder.AddContent(57, 
#nullable restore
#line 72 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                                                                        selectedYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 73 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
		}
		else
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
             foreach (var ride in displayedRides)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\t\t\t\t");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "ride-card");
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t");
            __builder.OpenElement(63, "h6");
            __builder.AddContent(64, 
#nullable restore
#line 79 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                         ride.RideMetaData.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\t\t\t\t\t");
            __builder.OpenElement(66, "h6");
            __builder.OpenElement(67, "b");
            __builder.AddContent(68, 
#nullable restore
#line 80 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                            ride.RideMetaData.RideName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "<span class=\"oi oi-pencil edit-ride\"></span>");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "class", "oi oi-trash delete-ride");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                                                                                                                      e => DeleteRide(ride)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\t\t\t\t\t");
            __builder.OpenElement(74, "ul");
            __builder.AddMarkupContent(75, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(76, "li");
            __builder.AddContent(77, "Miles: ");
            __builder.AddContent(78, 
#nullable restore
#line 82 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                    Helpers.ConvertMetersToMiles(ride.RideMetaData.DistanceMeters)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(80, "li");
            __builder.AddContent(81, "Time: ");
            __builder.AddContent(82, 
#nullable restore
#line 83 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                   Helpers.ConvertSecToReadable(ride.RideMetaData.TimeSeconds)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(84, "li");
            __builder.AddContent(85, "Average Watts: ");
            __builder.AddContent(86, 
#nullable restore
#line 84 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                            ride.RideMetaData.AvgWatts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(88, "li");
            __builder.AddContent(89, "Average Heart Rate:");
            __builder.AddContent(90, 
#nullable restore
#line 85 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                ride.RideMetaData.AvgHeartRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(92, "li");
            __builder.AddContent(93, "Average Cadence: ");
            __builder.AddContent(94, 
#nullable restore
#line 86 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                              ride.RideMetaData.AvgCadence

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n\t\t\t\t\t");
            __builder.OpenComponent<SmartWattsUi.Pages.PowerTable>(97);
            __builder.AddAttribute(98, "Ride", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SmartWattsCore.Models.Ride>(
#nullable restore
#line 89 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                      ride

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "TimeFrame", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 89 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                                                       timeFrame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 92 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
             
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "\t\t");
            __builder.OpenComponent<SmartWattsUi.Pages.Legend>(103);
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 97 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
		
	}
	else 
	{ 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(105, "\t\t");
            __builder.OpenComponent<SmartWattsUi.Shared.Loader>(106);
            __builder.AddAttribute(107, "Msg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 101 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
                     loadingMsg

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 102 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(109, "\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(110, @"<style>
	
	.close {
		color: orangered;
		width: 20px;
		height: 20px;
		border-radius: 100%;
		cursor: pointer;
	}

	.ride-card {
		background: #e8f8f8;
		box-shadow: #ade6e6 2px 4px;
		padding: 10px;
		margin: 20px;
	}

	.time-frame-selector {
		position: fixed;
		top: 3%;
		left: 40%;
		z-index: 3;
	}

	.month-year-selected {
		color: purple;
		font-size: 16px;
	}

	.month-year {
		color: blue;
		text-decoration: underline;
		font-size: 14px;
		cursor: pointer;
	}

	.edit-ride {
		color: orange;
		padding: 5px;
		cursor: pointer;
	}

	.delete-ride {
		font-size: 20px;
		color: red;
		cursor: pointer;
	}

</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Projects\SmartWatts\SmartWattsUi\Pages\Feed.razor"
       

	List<Ride> displayedRides;
	int timeFrame = 30;
	bool legend = true;
	string loadingMsg;
	int selectedMonth;
	int selectedYear;
	List<int> yearsToDisplay = new List<int>();



	protected override async Task OnInitializedAsync()
	{
		if (_appState.LoggedInUser == null)
		{
			NavigationManager.NavigateTo("splash");
		}
		else
		{
			var currentDate = DateTime.Now;
			selectedMonth = currentDate.Month;
			selectedYear = currentDate.Year;

			loadingMsg = $"Hang Tight {_appState.LoggedInUser.Username}, we are fetching your rides!";
			_appState.LoggedInUser.Rides = await _rideController.GetRides(_appState.LoggedInUser.CyclistId);

			GetYearsWithRides();
			GetRidesToDisplay();
			loadingMsg = "";
		}
	}

	private void GetYearsWithRides()
	{
		var uniqueYearRides = _appState.LoggedInUser.Rides.GroupBy(r => r.RideMetaData.Date.Year).Select(g => g.First());
		foreach (var ride in uniqueYearRides)
		{
			yearsToDisplay.Add(ride.RideMetaData.Date.Year);
		}
	}

	private void GetRidesToDisplay()
	{
		displayedRides = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date.Year == selectedYear && r.RideMetaData.Date.Month == selectedMonth).ToList();
	}

	private void ChangeYear(int year)
	{
		selectedYear = year;
		GetRidesToDisplay();
	}

	private void ChangeMonth(string month)
	{
		selectedMonth = (int)Enum.Parse(typeof(Constants.Months), month);
		GetRidesToDisplay();
	}

	private string GetReadableTime(int time)
	{
		return Helpers.ConvertSecToReadable(time);
	}


	private async Task DeleteRide(Ride ride)
	{
		await _rideController.DeleteRide(ride);

		displayedRides.Remove(ride);
		_appState.LoggedInUser.Rides.Remove(ride);
	}

	private void CollapseExpand()
	{
		legend = !legend;
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RideController _rideController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPowerCurveServices powerCurveServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IXmlServices xmlServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
