#pragma checksum "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51377ff5bf2ac9b238d6d62094506a4f07357f0b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHousePriceApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 3 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
using BlazorHousePriceApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/predictmelbourne")]
    public partial class PredictHousePriceMelbourne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Predict House Price Melbourne</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12");
            __builder.AddMarkupContent(3, "<h3><b>Enter House Information</b></h3>\r\n    <hr>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                      house

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                             PredictPrice

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-12 row");
                __builder2.AddMarkupContent(14, "<label class=\"col-2 font-weight-bold\">Rooms :</label>\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "number");
                __builder2.AddAttribute(17, "class", "form-control col-3");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Rooms

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Rooms = __value, house.Rooms, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-12 row");
                __builder2.AddMarkupContent(23, "<label class=\"col-2 font-weight-bold\">Price :</label>\r\n            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "number");
                __builder2.AddAttribute(26, "class", "form-control col-3");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Price

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Price = __value, house.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-12 row");
                __builder2.AddMarkupContent(32, "<label class=\"col-2 font-weight-bold\">Distance :</label>\r\n            ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "number");
                __builder2.AddAttribute(35, "class", "form-control col-3");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Distance

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Distance = __value, house.Distance, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-12 row");
                __builder2.AddMarkupContent(41, "<label class=\"col-2 font-weight-bold\">Postcode :</label>\r\n            ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "number");
                __builder2.AddAttribute(44, "class", "form-control col-3");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Postcode

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Postcode = __value, house.Postcode, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-12 row");
                __builder2.AddMarkupContent(50, "<label class=\"col-2 font-weight-bold\">Bedrooms :</label>\r\n            ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "type", "number");
                __builder2.AddAttribute(53, "class", "form-control col-3");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Bedroom2

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Bedroom2 = __value, house.Bedroom2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-12 row");
                __builder2.AddMarkupContent(59, "<label class=\"col-2 font-weight-bold\">Bathrooms :</label>\r\n            ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "type", "number");
                __builder2.AddAttribute(62, "class", "form-control col-3");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Bathroom

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Bathroom = __value, house.Bathroom, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.BlazorHousePriceApp.Client.Pages.PredictHousePriceMelbourne.TypeInference.CreateValidationMessage_0(__builder2, 66, 67, 
#nullable restore
#line 43 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                      ()=> house.Bathroom

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-12 row");
                __builder2.AddMarkupContent(71, "<label class=\"col-2 font-weight-bold\">Land Size :</label>\r\n            ");
                __builder2.OpenElement(72, "input");
                __builder2.AddAttribute(73, "type", "number");
                __builder2.AddAttribute(74, "class", "form-control col-3");
                __builder2.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.Landsize

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Landsize = __value, house.Landsize, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-12 row");
                __builder2.AddMarkupContent(80, "<label class=\"col-2 font-weight-bold\">Building Area :</label>\r\n            ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "number");
                __builder2.AddAttribute(83, "class", "form-control col-3");
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.BuildingArea

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.BuildingArea = __value, house.BuildingArea, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-12 row");
                __builder2.AddMarkupContent(89, "<label class=\"col-2 font-weight-bold\">Year Built :</label>\r\n            ");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "type", "number");
                __builder2.AddAttribute(92, "class", "form-control col-3");
                __builder2.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                   house.YearBuilt

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.YearBuilt = __value, house.YearBuilt, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-12 row");
                __builder2.AddMarkupContent(98, "<label class=\"col-2 font-weight-bold\">Council Area :</label>\r\n            ");
                __builder2.OpenElement(99, "input");
                __builder2.AddAttribute(100, "type", "text");
                __builder2.AddAttribute(101, "class", "form-control col-3");
                __builder2.AddAttribute(102, "placeholder", "string");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                 house.CouncilArea

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.CouncilArea = __value, house.CouncilArea));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-12 row");
                __builder2.AddMarkupContent(108, "<label class=\"col-2 font-weight-bold\">Region Name :</label>\r\n            ");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "type", "text");
                __builder2.AddAttribute(111, "class", "form-control col-3");
                __builder2.AddAttribute(112, "placeholder", "string");
                __builder2.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                 house.Regionname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Regionname = __value, house.Regionname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n        <br>\r\n        \r\n        ");
                __builder2.AddMarkupContent(116, "<div class=\"col-12 row\"><span class=\"col-2\"></span>\r\n            <input type=\"submit\" class=\"form-control col-1 btn btn-primary\" value=\"Predict\"></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 81 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
 if (predictedPrice == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "<p><em>Please fill in the house data...</em></p>");
#nullable restore
#line 84 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(118, "h2");
            __builder.AddContent(119, "Price prediction : $");
            __builder.AddContent(120, 
#nullable restore
#line 87 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                             Math.Round(predictedPrice.Score, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.OpenElement(122, "h3");
            __builder.AddContent(123, "1 sq. ft.: ");
            __builder.AddContent(124, 
#nullable restore
#line 88 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                    Math.Round(m2, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(125, ";");
            __builder.CloseElement();
#nullable restore
#line 90 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
     if (predictedPrice.Score - askingPrice > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(126, "h3");
            __builder.AddContent(127, "Underpriced by ");
            __builder.AddContent(128, 
#nullable restore
#line 92 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                            Math.Round(Math.Abs(predictedPrice.Score - askingPrice), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 93 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(129, "h3");
            __builder.AddContent(130, "Overpriced by ");
            __builder.AddContent(131, 
#nullable restore
#line 96 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                           Math.Round(Math.Abs(predictedPrice.Score - askingPrice), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 97 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "select");
            __builder.AddAttribute(133, "class", "form-control selectpicker");
            __builder.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                     choice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choice = __value, choice));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(136, "option");
            __builder.AddContent(137, "--select currency--");
            __builder.CloseElement();
#nullable restore
#line 101 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
         foreach (var item in converter.conversion_rates.GetType().GetProperties())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", 
#nullable restore
#line 103 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                            item.GetValue(converter.conversion_rates, null)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(140, 
#nullable restore
#line 103 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                              item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 104 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 108 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
     if (choice == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "<h4>Please select your currency</h4>");
#nullable restore
#line 111 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "h4");
            __builder.AddContent(143, "Price in specified currency: ");
            __builder.AddContent(144, 
#nullable restore
#line 114 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                          Math.Round((predictedPrice.Score * choice), 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 115 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "row");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-md-12 col-sm-12 p-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(149);
            __builder.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.BlazorHousePriceApp.Client.Pages.PredictHousePriceMelbourne.TypeInference.CreateRadzenBarSeries_1(__builder2, 151, 152, 
#nullable restore
#line 120 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                        blueChart

#line default
#line hidden
#nullable disable
                , 153, "Text", 154, "PredictedPrice/AverageMelbournePrice", 155, 
#nullable restore
#line 120 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                                                                                                                  LineType.Dashed

#line default
#line hidden
#nullable disable
                , 156, "Value");
                __builder2.AddMarkupContent(157, "\r\n                ");
                __Blazor.BlazorHousePriceApp.Client.Pages.PredictHousePriceMelbourne.TypeInference.CreateRadzenBarSeries_2(__builder2, 158, 159, 
#nullable restore
#line 121 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                        greenChart

#line default
#line hidden
#nullable disable
                , 160, "Text", 161, "PredictedPrice/AskingPrice", 162, "Value");
                __builder2.AddMarkupContent(163, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(164);
                __builder2.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(166);
                    __builder3.AddAttribute(167, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 123 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(168, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(169);
                    __builder3.AddAttribute(170, "Text", "Visual Representation");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(171, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenBarOptions>(172);
                __builder2.AddAttribute(173, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 126 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
                                          5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "E:\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\PredictHousePriceMelbourne.razor"
       

    double choice = 0;

    public Melbourne house { get; set; }
    public Prediction predictedPrice;
    public Data.MelbourneStatistics stats;
    public Data.CurrencyAPIResponse converter;

    DataItem[] blueChart;
    DataItem[] greenChart;

    public double m2;
    public double askingPrice;




    string result;

    public HttpResponseMessage response { get; set; }

    private string apiUrl = "http://localhost:5000/api/v1/Melbourne";
    private string conversionUrl = "https://v6.exchangerate-api.com/v6/6adc721f7fb5b27c1916c938/latest/USD";
    private string apiStats = "http://localhost:5000/api/v1/statistics/Melbourne";

    protected async override Task OnInitializedAsync()
    {
        house = new Melbourne();
        converter = await Http.GetFromJsonAsync<Data.CurrencyAPIResponse>(conversionUrl);

        stats = await Http.GetFromJsonAsync<Data.MelbourneStatistics>(apiStats);

    }

    private async Task PredictPrice()

    {
        predictedPrice = null;
        response = await Http.PostAsJsonAsync(apiUrl, house);
        result = response.Content.ReadAsStringAsync().Result;
        predictedPrice = JsonSerializer.Deserialize<Prediction>(result);

        blueChart = new DataItem[]
        {
        new DataItem
        {
            Text = "AvgPrice",
            Value = stats.price
        },
        new DataItem
        {
            Text = "PredictedPrice",
            Value = predictedPrice.Score
        }
                };
        greenChart = new DataItem[]
        {
            new DataItem
        {
            Text = "AskingPrice",
            Value = house.Price
        },
        new DataItem
        {
            Text = "PredictedPrice",
            Value = predictedPrice.Score
        }

                };

        m2 = predictedPrice.Score / house.Landsize;
        house = new Melbourne();

    }

    public class Prediction
    {
        public double Score { get; set; }
    }


    class DataItem
    {
        public string Text { get; set; }
        public double Value { get; set; }

    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorHousePriceApp.Client.Pages.PredictHousePriceMelbourne
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateRadzenBarSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Radzen.Blazor.LineType __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenBarSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "LineType", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenBarSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenBarSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
