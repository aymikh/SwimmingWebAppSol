#pragma checksum "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17c1d60e8aec88979e2c531af79f38c82a789724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results__ListItemPartial), @"mvc.1.0.view", @"/Views/Results/_ListItemPartial.cshtml")]
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
#line 1 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\_ViewImports.cshtml"
using SwimmingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\_ViewImports.cshtml"
using SwimmingWebApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\_ViewImports.cshtml"
using SwimmingWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\_ViewImports.cshtml"
using SwimmingWebApp.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\_ViewImports.cshtml"
using SwimmingWebApp.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c1d60e8aec88979e2c531af79f38c82a789724", @"/Views/Results/_ListItemPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4b2fa8d26bc60bfa246b279a23eff6ae5efcd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Results__ListItemPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Result>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\'card m-2 p-1 text-center col-4\'>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">\r\n            ");
#nullable restore
#line 5 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml"
       Write(Model.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h5>\r\n        <div class=\"card-text badge badge-secondary\">\r\n            <h6>");
#nullable restore
#line 8 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml"
           Write(Model.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>    \r\n        </div>\r\n        <p class=\"card-text\">\r\n            Время:   ");
#nullable restore
#line 11 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml"
                Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p class=\"card-text\">\r\n            Место: ");
#nullable restore
#line 14 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml"
              Write(Model.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>        \r\n");
#nullable restore
#line 16 "F:\Repos\SwimmingWebAppSol\SwimmingWebApp\Views\Results\_ListItemPartial.cshtml"
           // Получение текущего адреса
            var request = ViewContext.HttpContext.Request;
            var returnUrl = request.Path +
            request.QueryString.ToUriComponent();
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Result> Html { get; private set; }
    }
}
#pragma warning restore 1591
