#pragma checksum "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f729a2c7360b7cf8f4457ea473201e2fb4cfc8f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/_ViewImports.cshtml"
using Bitmoonfasttrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/_ViewImports.cshtml"
using Bitmoonfasttrade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f729a2c7360b7cf8f4457ea473201e2fb4cfc8f9", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57fe951f504ef3c2a7f74e573b588296d8bd2353", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml"
      
        ViewData["Title"] = "Dashboard";
        Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"row\">\n");
            WriteLiteral(@"        <div class=""col-xl-3"">
            <div class=""card card-profile"" style=""box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2); !important"">
                <div class=""card-body pt-0"" style=""padding: 0px !important"" >
                    <div class=""icon"" style=""display: inline-block; text-align: center; background-color: rgba(0, 0, 0, 0.12); width: 80px; height:60px; padding-top: 25px; padding-bottom: 70px;"">
                    <i class=""material-icons"" style=""color: #fff;"">money</i>
                    </div>
                    <div class=""content"" style=""display: inline-block; padding: 7px 10px;"">
                            <div class=""text"" style=""font-size:15px;color: #242424;""> <b>Account Balance</b></div>
                            <div class=""text"" style=""font-size:20px;color: #242424;""><b>$");
#nullable restore
#line 17 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml"
                                                                                    Write(ViewBag.balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
            WriteLiteral(@"        <div class=""col-xl-3"">
            <div class=""card card-profile"" style=""box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2); !important"">
                <div class=""card-body pt-0"" style=""padding: 0px !important"">
                    <div class=""icon"" style=""display: inline-block; text-align: center; background-color: rgba(0, 0, 0, 0.12); width: 80px; height:60px; padding-top: 25px; padding-bottom: 70px;"">
                    <i class=""material-icons"" style=""color: #fff;"">money</i>
                    </div>
                    <div class=""content"" style=""display: inline-block; padding: 7px 10px;"">
                            <div class=""text"" style=""font-size:15px;color: #242424;""> <b>Amount Invested</b></div>
                            <div class=""text"" style=""font-size:20px;color: #242424;""><b>$");
#nullable restore
#line 31 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml"
                                                                                    Write(ViewBag.invested);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n");
            WriteLiteral(@"        <div class=""col-xl-3"">
            <div class=""card card-profile"" style=""box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2); !important"">
                <div class=""card-body pt-0"" style=""padding: 0px !important"" >
                    <div class=""icon"" style=""display: inline-block; text-align: center; background-color: rgba(0, 0, 0, 0.12); width: 80px; height:60px; padding-top: 25px; padding-bottom: 70px;"">
                    <i class=""material-icons"" style=""color: #fff;"">money</i>
                    </div>
                    <div class=""content"" style=""display: inline-block; padding: 7px 10px;"">
                            <div class=""text"" style=""font-size:15px;color: #242424;""> <b>Bonus</b></div>
                            <div class=""text"" style=""font-size:20px;color: #242424;""><b>$");
#nullable restore
#line 46 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml"
                                                                                    Write(ViewBag.bonus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n");
            WriteLiteral(@"        <div class=""col-xl-3"">
            <div class=""card card-profile"" style=""box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2); !important"">
               
                <div class=""card-body pt-0"" style=""padding: 0px !important"">
                    <div class=""icon"" style=""display: inline-block; text-align: center; background-color: rgba(0, 0, 0, 0.12); width: 80px; height:60px; padding-top: 25px; padding-bottom: 70px;"">
                    <i class=""material-icons"" style=""color: #fff;"">money</i>
                    </div>
                    <div class=""content"" style=""display: inline-block; padding: 7px 10px;"">
                            <div class=""text"" style=""font-size:15px;color: #242424;""> <b>Total Withdrawal</b></div>
                            <div class=""text"" style=""font-size:20px;color: #242424;""><b>$");
#nullable restore
#line 62 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Views/Dashboard/Index.cshtml"
                                                                                    Write(ViewBag.withdrawal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class=""row"">
        <div class=""col-xl-12"">
            <div class=""card"">
                    <div class=""card-body"">
                        <!-- TradingView Widget BEGIN -->
                        <div class=""tradingview-widget-container"" style=""position: relative;box-sizing: content-box;width: auto;height: 700px;margin: 0 auto !important;padding: 0 !important;"">
                            <div id=""tradingview_87e04"" style=""width: auto !important; height: 700px !important;""></div>
                                    <script type=""text/javascript"" src=""https://s3.tradingview.com/tv.js""></script>
                                    <script type=""text/javascript"">
                                    new TradingView.widget(
                                    {
                                    ""autosize"": true,
                                    ""symbol"": ""COINBASE:BTCUSD"",
               ");
            WriteLiteral(@"                     ""timezone"": ""Etc/UTC"",
                                    ""theme"": ""dark"",
                                    ""style"": ""1"",
                                    ""locale"": ""en"",
                                    ""toolbar_bg"": ""#f1f3f6"",
                                    ""enable_publishing"": false,
                                    ""withdateranges"": true,
                                    ""range"": ""YTD"",
                                    ""hide_side_toolbar"": false,
                                    ""allow_symbol_change"": true,
                                    ""details"": true,
                                    ""hotlist"": true,
                                    ""calendar"": true,
                                    ""container_id"": ""tradingview_87e04""
                                    }
                                    );
                                    </script>
                                </div>
                        </div>
                        <!-- Tradi");
            WriteLiteral("ngView Widget END -->\n                    </div>\n            </div>\n        </div>\n    </div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f729a2c7360b7cf8f4457ea473201e2fb4cfc8f911174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
