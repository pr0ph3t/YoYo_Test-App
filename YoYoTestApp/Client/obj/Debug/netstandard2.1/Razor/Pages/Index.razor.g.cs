#pragma checksum "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3878e71c7d345e894facf9962eb87a72e949e42d"
// <auto-generated/>
#pragma warning disable 1591
namespace YoYoTestApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using YoYoTestApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\_Imports.razor"
using YoYoTestApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
using YoYoTestApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm-12");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"row d-sm-block text-center\">\r\n                <h4>YoYo Test</h4>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 157 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                 if (!yoyoService.IsProcessStarted)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "athlete-div-play-continer");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                     (e=> StartTimer())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n                        <img src=\"/images/play-button.png\" class=\"athlete-img-play\">\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 162 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                }
                else
                {


#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "id", "cont");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "svg");
            __builder.AddAttribute(24, "id", "svg");
            __builder.AddAttribute(25, "width", "200");
            __builder.AddAttribute(26, "height", "200");
            __builder.AddAttribute(27, "viewPort", "0 0 100 100");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "text");
            __builder.AddAttribute(30, "x", "50%");
            __builder.AddAttribute(31, "y", "50%");
            __builder.AddAttribute(32, "text-anchor", "middle");
            __builder.AddAttribute(33, "stroke", "#343a40");
            __builder.AddAttribute(34, "stroke-width", "1px");
            __builder.AddAttribute(35, "dy", ".3em");
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "tspan");
            __builder.AddAttribute(38, "x", "100");
            __builder.AddAttribute(39, "dy", "-20");
            __builder.AddContent(40, "Level ");
            __builder.AddContent(41, 
#nullable restore
#line 169 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                               yoyoService.Level

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.OpenElement(43, "tspan");
            __builder.AddAttribute(44, "x", "100");
            __builder.AddAttribute(45, "dy", "20");
            __builder.AddContent(46, "Shuttle ");
            __builder.AddContent(47, 
#nullable restore
#line 170 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                yoyoService.Shuttle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "tspan");
            __builder.AddAttribute(50, "x", "100");
            __builder.AddAttribute(51, "dy", "25");
            __builder.AddContent(52, 
#nullable restore
#line 171 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                        yoyoService.ShuttleSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " km/h");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            <circle r=\"90\" cx=\"100\" cy=\"100\" fill=\"transparent\" stroke-dasharray=\"565.48\" stroke-dashoffset=\"0\"></circle>\r\n                            ");
            __builder.OpenElement(56, "circle");
            __builder.AddAttribute(57, "id", "bar");
            __builder.AddAttribute(58, "r", "90");
            __builder.AddAttribute(59, "cx", "100");
            __builder.AddAttribute(60, "cy", "100");
            __builder.AddAttribute(61, "fill", "transparent");
            __builder.AddAttribute(62, "stroke-dasharray", "565.48");
            __builder.AddAttribute(63, "style", "stroke-dashoffset:" + " " + (
#nullable restore
#line 174 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                                                                                              strockDashOffSet

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 177 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "table");
            __builder.AddAttribute(73, "class", "table athlete-table-with-header");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, @"<thead>
                        <tr>
                            <td>
                                <label>Next Shuttle</label>
                            </td>
                            <td>
                                <label>Total Time</label>
                            </td>
                            <td>
                                <label>Total Distance</label>
                            </td>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(76, "tbody");
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 196 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                 nextShuttle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(82, " S");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "class", "athlete-add-border-rl");
            __builder.AddContent(86, 
#nullable restore
#line 197 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                               yoyoService.TotalTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, " S");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 198 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                 yoyoService.TotalDistance

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, " M");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                            <td></td>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "row");
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.AddMarkupContent(102, "<label>Track</label>\r\n        <hr>\r\n");
#nullable restore
#line 209 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
         if (yoyoService?.Athletes?.Any() == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "            ");
            __builder.OpenElement(104, "table");
            __builder.AddAttribute(105, "class", "table");
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 212 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                 foreach (var athlete in yoyoService.Athletes)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                    ");
            __builder.OpenElement(108, "tr");
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "td");
            __builder.OpenElement(111, "label");
            __builder.AddContent(112, 
#nullable restore
#line 215 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                    string.Format("{0}. {1}", athlete.Id, athlete.Name)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.OpenElement(114, "td");
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 217 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                             if (yoyoService.IsProcessStarted && !athlete.IsStopped)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "                                ");
            __builder.OpenElement(117, "label");
            __builder.AddAttribute(118, "class", "yoyo-warn");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 219 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                     e => Warn(athlete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(120, 
#nullable restore
#line 219 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                                           athlete.WarnText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                ");
            __builder.OpenElement(122, "label");
            __builder.AddAttribute(123, "class", "yoyo-danger");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 220 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                                       e => Stop(athlete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(125, "Stop");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 221 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                            }
                            else if (yoyoService.IsProcessStarted && athlete.IsStopped)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                                ");
            __builder.OpenElement(128, "label");
            __builder.AddContent(129, 
#nullable restore
#line 224 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                        athlete.Level

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(130, "/");
            __builder.AddContent(131, 
#nullable restore
#line 224 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                                                       athlete.Shuttle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 225 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n");
#nullable restore
#line 228 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 230 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(138, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(141, "<style>\r\n    label.yoyo-warn {\r\n        background-color: gray;\r\n        color: white;\r\n        padding: 0px 10px;\r\n        border-radius: 28%;\r\n        outline: none;\r\n        border: none;\r\n    }\r\n\r\n    label.yoyo-danger {\r\n        background-color: red;\r\n        color: white;\r\n        padding: 0px 10px;\r\n        border-radius: 28%;\r\n        outline: none;\r\n        border: none;\r\n    }\r\n\r\n    div.athlete-div-margin {\r\n        border-right: 1px solid gray;\r\n        border-left: 1px solid gray;\r\n        margin-bottom: 7px;\r\n    }\r\n\r\n    div.athletee-entry {\r\n        border-bottom: 1px solid #a0a0a0;\r\n        margin: 5px;\r\n    }\r\n\r\n    .athlete-div-play-continer {\r\n        margin: auto;\r\n    }\r\n\r\n    .athlete-img-play {\r\n        width: 180px;\r\n    }\r\n\r\n    .athlete-table-with-header {\r\n        text-align: center;\r\n        border: none;\r\n    }\r\n\r\n        .athlete-table-with-header td {\r\n            border-top: none !important;\r\n            border-collapse: collapse;\r\n        }\r\n\r\n    .athlete-add-border-rl {\r\n        border-right: 1px solid #ccc;\r\n        border-left: 1px solid #ccc;\r\n    }\r\n\r\n    #svg circle {\r\n        stroke-dashoffset: 0;\r\n        transition: stroke-dashoffset 1s linear;\r\n        stroke: #666;\r\n        stroke-width: 1em;\r\n    }\r\n\r\n    #svg #bar {\r\n        stroke: #b75819;\r\n    }\r\n\r\n    #cont {\r\n        display: block;\r\n        height: 200px;\r\n        width: 200px;\r\n        margin: 2em auto;\r\n        /*box-shadow: 0 0 1em black;*/\r\n        border-radius: 100%;\r\n        position: relative;\r\n    }\r\n\r\n        #cont:after {\r\n            position: absolute;\r\n            display: block;\r\n            height: 160px;\r\n            width: 160px;\r\n            left: 50%;\r\n            top: 50%;\r\n            /*box-shadow: inset 0 0 1em black;*/\r\n            margin-top: -80px;\r\n            margin-left: -80px;\r\n            border-radius: 100%;\r\n            line-height: 160px;\r\n            font-size: 2em;\r\n            /*text-shadow: 0 0 0.5em black;*/\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "E:\Projects\YoYoTestApp\YoYoTestApp\YoYoTestApp\Client\Pages\Index.razor"
       



    double strockDashOffSet = 565.2;

    double nextShuttle = 0;

    YoYoServiceModel yoyoService = new YoYoServiceModel();

    public async Task StartTimer()
    {
        strockDashOffSet = 565.2;
        double progress = 0;
        yoyoService.IsProcessStarted = true;

        foreach (TestModel testdata in yoyoService.Tests)
        {
            var shuttleno = 0;
            nextShuttle = Math.Round(testdata.LevelTime);
            while (shuttleno < testdata.ShuttleNo && yoyoService.Athletes.All(x => !x.IsStopped))
            {
                progress = 0;
                nextShuttle = Math.Round(testdata.LevelTime);
                var multipleFactor = 100 / nextShuttle;

                yoyoService.Level = testdata.Speedlevel;
                yoyoService.Shuttle = shuttleno;
                yoyoService.ShuttleSpeed = testdata.Speed;
                yoyoService.ShuttleTimeElapsed = 0;
                yoyoService.ShuttleTimeLeft = testdata.LevelTime;
                var actalDdistance = testdata.AccumulatedShuttleDistance / testdata.Speed;

                while (nextShuttle > 0)
                {
                    await Task.Delay(1000);
                    nextShuttle -= 1;
                    progress = progress + 1;
                    UpdateCounter(actalDdistance);
                    HandleProgress(progress * multipleFactor);
                    StateHasChanged();
                }
                UpdateAthleteInfo(testdata, shuttleno);
                shuttleno++;
                StateHasChanged();
            }

            StateHasChanged();

        }
    }


    public void HandleProgress(double val)
    {
        var r = 90;
        var c = Math.PI * (r * 2);

        if (val < 0)
        {
            val = 0;
        }
        if (val > 100)
        {
            val = 100;
        }

        var pct = ((100 - val) / 100) * c;
        strockDashOffSet = pct;
    }



    protected override async Task OnInitializedAsync()
    {
        yoyoService.Athletes = await GetAthletes().ConfigureAwait(false);
        yoyoService.Tests = await GetTests().ConfigureAwait(false);
        yoyoService.IsProcessStarted = false;
        yoyoService.IsStarted = false;


    }

    public async Task<List<Athlete>> GetAthletes()
    {
        var _athletes = await Http.GetFromJsonAsync<List<Athlete>>("YoYoTest/GetAthletes");
        return _athletes;
    }

    public async Task<List<TestModel>> GetTests()
    {
        var _tests = await Http.GetFromJsonAsync<List<TestModel>>("YoYoTest/GetTests");
        return _tests;
    }

    public async Task Warn(Athlete athlete)
    {
        if (!athlete.IsWarned)
        {
            athlete.IsWarned = true;
            athlete.WarnText = "Warned";

        }
        else
        {
            athlete.IsStopped = true;
        }
        var content = JsonConvert.SerializeObject(athlete.Id);
        await Http.PostAsJsonAsync($"YoYoTest/Warn", content).ConfigureAwait(false);
    }

    public async Task Stop(Athlete athlete)
    {
        athlete.IsStopped = true;
        var content = JsonConvert.SerializeObject(athlete.Id);
        await Http.PostAsJsonAsync($"YoYoTest/Stop", content).ConfigureAwait(false);
    }

    public async Task UpdateCounter(double actualdistance)
    {
        var content = JsonConvert.SerializeObject(actualdistance);
        await Http.PostAsJsonAsync($"YoYoTest/Stop", content).ConfigureAwait(false);
    }

    public async Task UpdateAthleteInfo(TestModel testdata, int shuttleNumber)
    {
        foreach (var athlete in yoyoService.Athletes.Where(x => !x.IsStopped))
        {
            athlete.Level = testdata.Speedlevel;
            athlete.Shuttle = shuttleNumber;
        }
        await Http.GetAsync($"YoYoTest/UpdateAthleteInfo").ConfigureAwait(false);
    }

    public async Task OnEditButtonClick(int id, int level, int shuttle)
    {

        var data = new { id = id, level = level, shuttle = shuttle };
        var content = JsonConvert.SerializeObject(data);
        await Http.PostAsJsonAsync($"YoYoTest/Edit", content).ConfigureAwait(false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
