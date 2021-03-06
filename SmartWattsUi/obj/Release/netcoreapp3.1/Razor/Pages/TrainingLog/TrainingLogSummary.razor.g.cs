#pragma checksum "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d48bfec91f148760d626b2b1dc1e5435b69ffd"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
using SmartWattsCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
using SmartWattsCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
using SmartWattsUi.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
using SmartWattsUi.Services;

#line default
#line hidden
#nullable disable
    public partial class TrainingLogSummary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "ride-card");
            __builder.AddMarkupContent(5, "\r\n\t\t");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "current-data");
            __builder.AddMarkupContent(8, "\r\n\t\t\t");
            __builder.AddMarkupContent(9, "<p>This Week</p>\r\n\t\t\t");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 15 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(thisWeekRides)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t\t");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                WeekPace(thisWeekRides)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " (pace for)");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t\t");
            __builder.OpenElement(17, "table");
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(thisWeekRides))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\t\t\t\t\t");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "style", "background-color:" + (
#nullable restore
#line 22 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 23 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 25 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\t\t");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "prev-data");
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.AddMarkupContent(35, "<p>This time last week </p>\r\n\t\t\t");
            __builder.OpenElement(36, "p");
            __builder.AddContent(37, 
#nullable restore
#line 31 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(prevWeekRides)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\t\t\t");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, 
#nullable restore
#line 32 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetLastWeekTotal()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " (total)");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\t\t\t");
            __builder.OpenElement(43, "table");
            __builder.AddMarkupContent(44, "\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(prevWeekRides))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "\t\t\t\t\t");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "style", "background-color:" + (
#nullable restore
#line 38 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 39 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 41 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n\r\n\t");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "ride-card");
            __builder.AddMarkupContent(61, "\r\n\t\t");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "current-data");
            __builder.AddMarkupContent(64, "\r\n\t\t\t");
            __builder.AddMarkupContent(65, "<p>This Month</p>\r\n\t\t\t");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, 
#nullable restore
#line 50 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(thisMonthRides)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\t\t\t");
            __builder.OpenElement(69, "p");
            __builder.AddContent(70, 
#nullable restore
#line 51 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetWeeklyAvg(thisMonthRides, current.Day)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " (per week)");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\t\t\t");
            __builder.OpenElement(73, "table");
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 53 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(thisMonthRides))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\t\t\t\t\t");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "style", "background-color:" + (
#nullable restore
#line 56 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 57 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 59 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n\t\t");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "prev-data");
            __builder.AddMarkupContent(90, "\r\n\t\t\t");
            __builder.AddMarkupContent(91, "<p>This time last Month</p>\r\n\t\t\t");
            __builder.OpenElement(92, "p");
            __builder.AddContent(93, 
#nullable restore
#line 65 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(prevMonthToDate)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\t\t\t");
            __builder.OpenElement(95, "p");
            __builder.AddContent(96, 
#nullable restore
#line 66 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(prevMonthRides)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(97, " (total)");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\t\t\t");
            __builder.OpenElement(99, "table");
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 68 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(prevMonthToDate))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, "\t\t\t\t\t");
            __builder.OpenElement(102, "tr");
            __builder.AddMarkupContent(103, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "style", "background-color:" + (
#nullable restore
#line 71 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(107, "td");
            __builder.AddContent(108, 
#nullable restore
#line 72 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 74 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(111, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n\t");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "ride-card");
            __builder.AddMarkupContent(117, "\r\n\t\t");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "current-data");
            __builder.AddMarkupContent(120, "\r\n\t\t\t");
            __builder.AddMarkupContent(121, "<p>This Year</p>\r\n\t\t\t");
            __builder.OpenElement(122, "p");
            __builder.AddContent(123, 
#nullable restore
#line 82 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(thisYearRides)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\t\t\t");
            __builder.OpenElement(125, "p");
            __builder.AddContent(126, 
#nullable restore
#line 83 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetWeeklyAvg(thisYearRides, current.DayOfYear)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(127, " (per week)");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\t\t\t");
            __builder.OpenElement(129, "table");
            __builder.AddMarkupContent(130, "\r\n");
#nullable restore
#line 85 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(thisYearRides))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(131, "\t\t\t\t\t");
            __builder.OpenElement(132, "tr");
            __builder.AddMarkupContent(133, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(134, "td");
            __builder.AddAttribute(135, "style", "background-color:" + (
#nullable restore
#line 88 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 89 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 91 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n\t\t");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "prev-data");
            __builder.AddMarkupContent(146, "\r\n\t\t\t");
            __builder.AddMarkupContent(147, "<p>This time last Year</p>\r\n\t\t\t");
            __builder.OpenElement(148, "p");
            __builder.AddContent(149, 
#nullable restore
#line 97 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetTime(prevYearRides)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n\t\t\t");
            __builder.OpenElement(151, "p");
            __builder.AddContent(152, 
#nullable restore
#line 98 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                GetWeeklyAvg(prevYearRides, current.DayOfYear)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(153, " (per week)");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n\t\t\t");
            __builder.OpenElement(155, "table");
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 100 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                 foreach (var intensity in GetIntensityOccourances(prevYearRides))
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(157, "\t\t\t\t\t");
            __builder.OpenElement(158, "tr");
            __builder.AddMarkupContent(159, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(160, "td");
            __builder.AddAttribute(161, "style", "background-color:" + (
#nullable restore
#line 103 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                                                     intensity.Key.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(163, "td");
            __builder.AddContent(164, 
#nullable restore
#line 104 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
                             intensity.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 106 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(167, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(172, "<style>\r\n\ttd {\r\n\t\twidth: 25px;\r\n\t\tmargin: 5px;\r\n\t\ttext-align: right;\r\n\t}\r\n\r\n\t.current-data {\r\n\t\tfloat: left;\r\n\t}\r\n\r\n\t.prev-data {\r\n\t\tfloat: right;\r\n\t}\r\n\r\n\t.ride-card {\r\n\t\twidth: 30%;\r\n\t}\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\TrainingLog\TrainingLogSummary.razor"
       
	DateTime current;

	List<Ride> thisWeekRides;
	List<Ride> prevWeekRides;

	List<Ride> thisMonthRides;
	List<Ride> prevMonthToDate;
	List<Ride> prevMonthRides;

	List<Ride> thisYearRides;
	List<Ride> prevYearRides;

	List<Ride> LastWeeksRides;


	protected override void OnInitialized()
	{

		_trainingLogController.AppendHighestIntensity(_appState.LoggedInUser.Rides);

		GetInitialRideLists();
	}

	private void GetInitialRideLists()
	{
		current = DateTime.Now;
		var weekStart = Helpers.StartOfWeek(current);

		thisWeekRides = _rideServices.FilterByWeek(current).ToList();
		thisMonthRides = _rideServices.FilterByMonth(current.Month, current.Year).ToList();
		thisYearRides = _rideServices.FilterByYear(current.Year).ToList();

		prevWeekRides = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date > weekStart.AddDays(-7) && r.RideMetaData.Date < current.AddDays(-7)).ToList();

		prevMonthRides = _rideServices.FilterByMonth(current.AddMonths(-1).Month, current.Month != 1 ? current.Year : current.Year - 1).ToList();
		prevMonthToDate = prevMonthRides.Where(r => r.RideMetaData.Date < current.AddMonths(-1)).ToList();
		prevYearRides = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date.Year == current.AddYears(-1).Year && r.RideMetaData.Date < current.AddYears(-1)).ToList();

		LastWeeksRides = _appState.LoggedInUser.Rides.Where(r => r.RideMetaData.Date > weekStart.AddDays(-7) && r.RideMetaData.Date < weekStart).ToList();
	}

	private Dictionary<Intensity, int> GetIntensityOccourances(List<Ride> rides)
	{
		Dictionary<Intensity, int> intensityOccourances = new Dictionary<Intensity, int>();
		foreach (var intensity in Constants.Intensities)
		{
			intensityOccourances.Add(intensity, 0);
		}

		foreach (var ride in rides)
		{
			intensityOccourances[ride.TopIntensity] += 1;
		}

		return intensityOccourances;

	}

	private string GetTime(List<Ride> rides)
	{
		var time = rides.Sum(r => r.RideMetaData.TimeSeconds);
		return Helpers.ConvertSecToReadableLong(time);
	}

	private string GetWeeklyAvg(List<Ride> rides, int weeksIn)
	{
		var weeksIntoMonth = (float)weeksIn / 7;
		var time = rides.Sum(r => r.RideMetaData.TimeSeconds);
		return Helpers.ConvertSecToReadableLong((int)(time / weeksIntoMonth));
	}

	private string GetLastWeekTotal()
	{
		var time = LastWeeksRides.Sum(r => r.RideMetaData.TimeSeconds);
		return Helpers.ConvertSecToReadableLong(time);
	}

	private string WeekPace(List<Ride> rides)
	{
		var time = rides.Sum(r => r.RideMetaData.TimeSeconds);
		var day = (int)current.DayOfWeek == 0 ? 7 : (int)current.DayOfWeek;
		var ratio = 7 / (float)day;
		return Helpers.ConvertSecToReadableLong((int)(ratio * time));
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RideServices _rideServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TrainingLogController _trainingLogController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RideController _rideController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
    }
}
#pragma warning restore 1591
