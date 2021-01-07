// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorHousePriceApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 9 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorHousePriceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\StatistiscData.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\StatistiscData.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\StatistiscData.razor"
using BlazorHousePriceApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\StatistiscData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statisticsdata")]
    public partial class StatistiscData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\StatistiscData.razor"
       


    private Statistics[] houses;
    private Statistics[] texas_houses;

    private string apiUrl = "http://localhost:5000/api/v1/statistica";

    protected override async Task OnInitializedAsync()
    {
        houses = await Http.GetFromJsonAsync<Statistics[]>(apiUrl);
        /*
        foreach (var house in houses)
        {
            if (String.Equals(house.NumeOras, "Singapore") == true)
            {
                texas_houses.Append<Statistics>(house);
            }
        }
        */
    }

    public class Statistics
    {
        public string NumeOras { get; set; }
        public double? MediaPret { get; set; }
        public double? MediaSuprafata { get; set; }
        public double? MediaRating { get; set; }
        public double? MaxPret { get; set; }
        public double? MinPret { get; set; }
        public string DateOfStatistic { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
