#pragma checksum "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Log in.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cee260ca70627a6c6adbf61485f98584d03a48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Log_in), @"mvc.1.0.razor-page", @"/Pages/Log in.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cee260ca70627a6c6adbf61485f98584d03a48", @"/Pages/Log in.cshtml")]
    public class Pages_Log_in : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Log in.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cee260ca70627a6c6adbf61485f98584d03a482949", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Log in</title>
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400&amp;subset=cyrillic"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""css/Login.css"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cee260ca70627a6c6adbf61485f98584d03a484239", async() => {
                WriteLiteral("\r\n\r\n<script>var articleLink = \'/scripts/forms/499-veb-forma-avtorizacii-i-registracii-na-sayte.html\';</script>\r\n<div class=\"cotn_principal\">\r\n\r\n    <a class=\"Back_button\"");
                BeginWriteAttribute("href", " href=\"", 611, "\"", 637, 1);
#nullable restore
#line 22 "C:\Users\User\Desktop\WORK\Сема\Retro-Usa-Cars\RetroUsaCars\RetroUsaCars\Pages\Log in.cshtml"
WriteAttributeValue("", 618, Url.Page("/index"), 618, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <button>Back</button>
    </a>

    <div class=""cont_centrar"">
        <div class=""cont_login"">
            <div class=""cont_info_log_sign_up"">
                <div class=""col_md_login"">
                    <div class=""cont_ba_opcitiy"">
                        <h2>Log in</h2>
                        <p>Already have a login?</p>
                        <button class=""btn_login"" onclick=""cambiar_login()"">Log in</button>
                    </div>
                </div>
                <div class=""col_md_sign_up"">
                    <div class=""cont_ba_opcitiy"">
                        <h2>Registartion</h2>
                        <p>No login?</p>
                        <button class=""btn_sign_up"" onclick=""cambiar_sign_up()"">Registration</button>
                    </div>
                </div>
            </div>
            <div class=""cont_back_info"">
                <div class=""cont_img_back_grey"">
                    <img src=""img/bg.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 1628, "\"", 1634, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n            <div class=\"cont_forms\">\r\n                <div class=\"cont_img_back_\">\r\n                    <img src=\"img/bg.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1808, "\"", 1814, 0);
                EndWriteAttribute();
                WriteLiteral(@"/>
                </div>
                <div class=""cont_form_login"">
                    <a href=""#"" onclick=""ocultar_login_sign_up()"">
                        <i class=""material-icons"">&#xE5C4;</i>
                    </a>
                    <h2>Log in</h2>
                    <input style=""color: black;"" type=""text"" placeholder=""E-mail""/>
                    <input style=""color: black;"" type=""password"" placeholder=""Password""/>
                    <button class=""btn_login"" onclick=""cambiar_login()"">Log in</button>
                </div>
                <div class=""cont_form_sign_up"">
                    <a href=""#"" onclick=""ocultar_login_sign_up()"">
                        <i class=""material-icons"">&#xE5C4;</i>
                    </a>
                    <h2>Registartion</h2>
                    <input style=""color: black;"" type=""text"" placeholder=""E-mail""/>
                    <input style=""color: black;"" type=""text"" placeholder=""Login""/>
                    <input style=""color: black");
                WriteLiteral(@";"" type=""password"" placeholder=""Password""/>
                    <input style=""color: black;"" type=""password"" placeholder=""Repeat password""/>
                    <button class=""btn_sign_up"" onclick=""cambiar_sign_up()"">Register</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""js/index.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetroUsaCars.Pages.Log_in> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetroUsaCars.Pages.Log_in> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetroUsaCars.Pages.Log_in>)PageContext?.ViewData;
        public RetroUsaCars.Pages.Log_in Model => ViewData.Model;
    }
}
#pragma warning restore 1591
