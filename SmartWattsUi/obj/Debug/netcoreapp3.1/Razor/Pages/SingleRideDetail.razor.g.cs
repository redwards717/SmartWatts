#pragma checksum "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2482b8e0fdc1c87e8764d0cfa03757eadaa8110"
// <auto-generated/>
#pragma warning disable 1591
namespace SmartWattsUi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 2 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
using SmartWattsCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
using SmartWattsCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
using SmartWattsUi.Controllers;

#line default
#line hidden
#nullable disable
    public partial class SingleRideDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n\t\t\t");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                            timeFrame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => timeFrame = __value, timeFrame));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n\t\t\t\t");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "30");
            __builder.AddContent(9, "30 Days");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\t\t\t\t");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "90");
            __builder.AddContent(13, "90 Days");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\t\t\t\t");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "365");
            __builder.AddContent(17, "1 Year");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\t\t\t\t");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "9999");
            __builder.AddContent(21, "All Time");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\t\t\t");
            __builder.OpenElement(24, "h5");
            __builder.AddContent(25, 
#nullable restore
#line 19 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                 Ride.RideMetaData.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 20 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
         if (!editMode)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "\t\t\t");
            __builder.OpenElement(28, "h5");
            __builder.AddContent(29, 
#nullable restore
#line 22 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                 Ride.RideMetaData.RideName

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "oi oi-pencil edit-ride");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                                                                          e => editMode = !editMode

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 23 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
		}
		else
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\t\t\t");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "placeholder", 
#nullable restore
#line 26 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                             Ride.RideMetaData.RideName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                                                                newName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newName = __value, newName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t\t\t");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-outline-success");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                                              ChangeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 28 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "\t\t\t");
            __builder.OpenElement(47, "ul");
            __builder.AddMarkupContent(48, "\r\n\t\t\t\t");
            __builder.OpenElement(49, "li");
            __builder.AddContent(50, "Miles: ");
            __builder.AddContent(51, 
#nullable restore
#line 30 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                            Helpers.ConvertMetersToMiles(Ride.RideMetaData.DistanceMeters)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t\t\t");
            __builder.OpenElement(53, "li");
            __builder.AddContent(54, "Time: ");
            __builder.AddContent(55, 
#nullable restore
#line 31 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                           Helpers.ConvertSecToReadable(Ride.RideMetaData.TimeSeconds)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t");
            __builder.OpenElement(57, "li");
            __builder.AddContent(58, "Average Watts: ");
            __builder.AddContent(59, 
#nullable restore
#line 32 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                    Ride.RideMetaData.AvgWatts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\t\t\t\t");
            __builder.OpenElement(61, "li");
            __builder.AddContent(62, "Average Heart Rate:");
            __builder.AddContent(63, 
#nullable restore
#line 33 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                        Ride.RideMetaData.AvgHeartRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\t\t\t\t");
            __builder.OpenElement(65, "li");
            __builder.AddContent(66, "Average Cadence: ");
            __builder.AddContent(67, 
#nullable restore
#line 34 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                      Ride.RideMetaData.AvgCadence

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n\t\t\t");
            __builder.OpenComponent<SmartWattsUi.Pages.PowerTable>(70);
            __builder.AddAttribute(71, "Ride", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SmartWattsCore.Models.Ride>(
#nullable restore
#line 38 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                              Ride

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "TimeFrame", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
                                               timeFrame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(75, "<style>\r\n\t.edit-ride {\r\n\t\tcolor: orange;\r\n\t}\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Projects\SmartWatts\SmartWattsUi\Pages\SingleRideDetail.razor"
       
	[Parameter]
	public Ride Ride { get; set; }

	int timeFrame = 30;
	bool editMode = false;
	string newName;

	private async Task ChangeName()
	{
		Ride.RideMetaData.RideName = newName;
		await _rideController.UpdateRide(Ride);
		editMode = false;
		StateHasChanged();
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RideController _rideController { get; set; }
    }
}
#pragma warning restore 1591