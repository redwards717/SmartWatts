#pragma checksum "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d0d8153f6625ea1e16973a092e55dac85fe8cb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SmartWattsUi.Shared
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
#line 2 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Shared\MainLayout.razor"
using SmartWattsUi.Pages.User;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Rhys\source\repos\SmartWatts\SmartWattsUi\Shared\MainLayout.razor"
 

	protected override void OnInitialized()
	{
		_appState.OnChange += StateHasChanged;
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
    }
}
#pragma warning restore 1591
