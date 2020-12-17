#pragma checksum "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d3b089b33913179a4bb9abd7951d1a24860879"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHousePriceApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorHousePriceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorHousePriceApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/texaslateststats")]
    public partial class TexasLatestStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TexasLatestStats</h3>");
#nullable restore
#line 6 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
 if (stats == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorPro.Spinkit.Wave>(1);
            __builder.AddAttribute(2, "Size", "70px");
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Price</th>\r\n                <th>Grade</th>\r\n                <th>SqftLot</th>\r\n                <th>MaxPrice</th>\r\n                <th>MinPrice</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "th");
            __builder.AddContent(9, 
#nullable restore
#line 26 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                         stats.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "th");
            __builder.AddContent(12, 
#nullable restore
#line 27 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                         stats.grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "th");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                         stats.sqftLot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "th");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                         stats.maxPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "th");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                         stats.minPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-6 col-sm-12 p-4");
            __builder.AddMarkupContent(26, "<h2>Average Price</h2>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenRadialGauge>(27);
            __builder.AddAttribute(28, "Style", "width: 100%; height: 300px;");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScale>(30);
                __builder2.AddAttribute(31, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                -150

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                150

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                           20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                    0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                            stats.maxPrice/10000

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "TickPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.GaugeTickPosition>(
#nullable restore
#line 40 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                                                               GaugeTickPosition.Inside

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScalePointer>(38);
                    __builder3.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 41 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                       (int)stats.price/10000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 41 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                       0.6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenRadialGaugeScalePointer>)((pointer) => (__builder4) => {
                        __builder4.OpenElement(43, "h4");
                        __builder4.AddContent(44, 
#nullable restore
#line 44 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                             pointer.Value

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(45, " ");
                        __builder4.AddMarkupContent(46, "<sup>* 10,000$</sup>");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScaleRange>(48);
                    __builder3.AddAttribute(49, "From", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 48 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                   0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "To", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 48 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                          (int)stats.maxPrice/30000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Fill", "green");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScaleRange>(53);
                    __builder3.AddAttribute(54, "From", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 49 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                   (int)stats.maxPrice/30000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "To", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 49 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                  (int)stats.maxPrice/15000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Fill", "orange");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScaleRange>(58);
                    __builder3.AddAttribute(59, "From", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 50 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                   (int)stats.maxPrice/15000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "To", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 50 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
                                                                                  (int)stats.maxPrice/10000

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "Fill", "red");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Florentin\Documents\GitHub\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\TexasLatestStats.razor"
       

    bool showValue = true;
    double value = 100;
    IEnumerable<GaugeTickPosition> tickPositions = Enum.GetValues(typeof(GaugeTickPosition)).Cast<GaugeTickPosition>();
    GaugeTickPosition tickPosition = GaugeTickPosition.Inside;

    private TexasStatistics stats;

    private string apiUrl = "http://localhost:5000/api/v1/statistica/Texas";

    protected override async Task OnInitializedAsync()
    {
        stats = await Http.GetFromJsonAsync<TexasStatistics>(apiUrl);
    }

    public class TexasStatistics
    {
        public double price { get; set; }
        public double grade { get; set; }
        public double sqftLot { get; set; }
        public double maxPrice { get; set; }
        public double minPrice { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
