#pragma checksum "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f669b3eac0f8b5b07fc0083010f65bf456d6e598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/_ViewImports.cshtml"
using Bitmoonfasttrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/_ViewImports.cshtml"
using Bitmoonfasttrade.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/_ViewImports.cshtml"
using Bitmoonfasttrade.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/_ViewImports.cshtml"
using Bitmoonfasttrade.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using Bitmoonfasttrade.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f669b3eac0f8b5b07fc0083010f65bf456d6e598", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddb3c9831caa398048d1edb2f7f87a038014656", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8abbfe69f427683535d7000fa0881fc7479801", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"wrapper\" style=\"margin-top: 200px; margin-bottom:100px\">\r\n    <h1>");
#nullable restore
#line 10 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Click <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 330, 1);
#nullable restore
#line 15 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
WriteAttributeValue("", 303, Model.EmailConfirmationUrl, 303, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">here </a>to confirm your account\r\n</p>\r\n");
#nullable restore
#line 17 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 23 "/home/proper/softwareProjects/dotnetProjects/2021/UGO/Bitmoonfasttrade/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
