#pragma checksum "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e4caa05f50c042a8a87d1cfb8c4472ed077ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Car), @"mvc.1.0.razor-page", @"/Pages/Car.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using RetroUsaCars.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using RetroUsaCars.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using static RetroUsaCars.models.Photo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using static RetroUsaCars.models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using static System.Web.Helpers.WebImage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e4caa05f50c042a8a87d1cfb8c4472ed077ee4", @"/Pages/Car.cshtml")]
    public class Pages_Car : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
  
    RetroUsaCars.models.User user = new User();
    user = CheckLoginAndLogin(HttpContext.Request.Cookies["Email"], HttpContext.Request.Cookies["Pass"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e4caa05f50c042a8a87d1cfb8c4472ed077ee44450", async() => {
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css?family=Shadows+Into+Light+Two&display=swap\" rel=\"stylesheet\" />\r\n    <link href=\"./css/Chevrolet_ZR.css\" rel=\"stylesheet\" />\r\n    <title>Document</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e4caa05f50c042a8a87d1cfb8c4472ed077ee45634", async() => {
                WriteLiteral("\r\n<div class=\"v64_0\">\r\n    <div class=\"v36_39\"></div>\r\n    <span class=\"v14_3\"><a class = \"aq\" ");
#nullable restore
#line 30 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                                   Write(Url.Page("/index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" >Retro USA Cars</a></span>
    <div class=""v36_41""></div>
    <span class=""v42_9""></span>
    <div class=""v36_42""></div>

    <span class=""v23_6""><a class = ""aq"" href=""Account.html"" >Support</a></span>
    <span class=""v25_0""><a class = ""aq"" href=""FAQ.html"" >FAQ</a></span>
    <span class=""v23_4""><a class = ""aq"" ");
#nullable restore
#line 37 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                                   Write(Url.Page("/SearchCar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" >Search Cars</a></span>\r\n    <div class=\"v42_7\"></div>\r\n    <span class=\"v42_8\"> \r\n        <table>\r\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
          
            foreach (var car in Model.list)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td><img width=\"100px\" height=\"100px\"");
                BeginWriteAttribute("src", " src=\"", 1451, "\"", 1482, 2);
                WriteAttributeValue("", 1457, "PhotosCars/", 1457, 11, true);
#nullable restore
#line 45 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
WriteAttributeValue("", 1468, car.photoname, 1468, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                   Write(car.brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                   Write(car.models);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                   Write(car.color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1641, "\"", 1661, 1);
#nullable restore
#line 49 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
WriteAttributeValue("", 1648, Url.Page(""), 1648, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
                                           Write(car.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Car.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n    </span>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetroUsaCars.Pages.Car> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetroUsaCars.Pages.Car> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetroUsaCars.Pages.Car>)PageContext?.ViewData;
        public RetroUsaCars.Pages.Car Model => ViewData.Model;
    }
}
#pragma warning restore 1591