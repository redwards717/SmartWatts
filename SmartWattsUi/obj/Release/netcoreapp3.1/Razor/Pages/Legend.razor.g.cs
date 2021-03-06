#pragma checksum "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2694351ff361310e12c0d294e792f099542451"
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
#line 1 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
using SmartWattsCore;

#line default
#line hidden
#nullable disable
    public partial class Legend : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "legend");
            __builder.AddMarkupContent(2, "\r\n\t\t");
            __builder.AddMarkupContent(3, "<h5>Legend</h5>\r\n");
#nullable restore
#line 5 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
         if (legend)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\t\t\t");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", "oi oi-collapse-up legend-collapse");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
                                                                      CollapseExpand

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\t\t\t<hr>\r\n");
#nullable restore
#line 9 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
             foreach (var intensity in Constants.Intensities)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\t\t\t\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "legend-color-square");
            __builder.AddAttribute(12, "style", "background-color:" + " " + (
#nullable restore
#line 11 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
                                                                           intensity.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\t\t\t\t");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "legend-description");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
                                                  intensity.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 13 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
             
		}
		else
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\t\t\t");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "oi oi-collapse-down legend-collapse");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
                                                                        CollapseExpand

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 18 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(25, @"<style>
	.legend {
		position: fixed;
		bottom: 5%;
		right: 2%;
		width: auto;
		height: auto;
		border-radius: 10px;
		background-color: lightblue;
		padding: 10px 35px 0px 10px;
	}

	.legend-color-square {
		width: 20px;
		height: 20px;
	}

	.legend-description {
		position: relative;
		bottom: 21px;
		left: 23px;
		font-size: 12px;
	}

	.legend-collapse {
		position: relative;
		left: 10%;
		cursor: pointer;
		float: right;
	}

	.legend h5 {
		display: inline-block;
	}
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Pages\Legend.razor"
       
	bool legend = true;

	private void CollapseExpand()
	{
		legend = !legend;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
