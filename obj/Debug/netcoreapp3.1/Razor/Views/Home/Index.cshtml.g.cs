#pragma checksum "C:\Users\thiag\source\repos\CalculaFreela\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b06517ebef40ae71db5cd81cc7253c58b4bfdef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\thiag\source\repos\CalculaFreela\Views\_ViewImports.cshtml"
using CalculaFreela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thiag\source\repos\CalculaFreela\Views\_ViewImports.cshtml"
using CalculaFreela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b06517ebef40ae71db5cd81cc7253c58b4bfdef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d182da658d1588b726a307979c1277ac42e3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thiag\source\repos\CalculaFreela\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""corpo"" class=""hero is-black is-bold is-fullheight"">
    <!-- Hero head: will stick at the top -->
    <div class=""hero-head"">
        <header class=""navbar"">
            <div class=""container"">
                <div class=""navbar-brand"">
                    <a class=""navbar-item is-active"">
                        <span class=""icon"">
                            <i class=""fas fa-home""></i>
                        </span>
                    </a>
                    <span class=""navbar-burger burger"" data-target=""navbarMenuHeroC"">
                        <span></span>
                    </span>
                </div>
                <div id=""navbarMenuHeroC"" class=""navbar-menu"">
                    <div class=""navbar-end"">

                        <a id=""abrirModal"" class=""navbar-item"" href=""#"">
                            <svg style=""width:2em;height:2em"" viewBox=""0 0 24 24"">
                                <path fill=""currentColor"" d=""M7,2H17A2,2 0 0,1 19,4V20A2,2 0 0,1 17,2");
            WriteLiteral(@"2H7A2,2 0 0,1 5,20V4A2,2 0 0,1 7,2M7,4V8H17V4H7M7,10V12H9V10H7M11,10V12H13V10H11M15,10V12H17V10H15M7,14V16H9V14H7M11,14V16H13V14H11M15,14V16H17V14H15M7,18V20H9V18H7M11,18V20H13V18H11M15,18V20H17V18H15Z"" />
                            </svg>

                            Calcule sua hora
                        </a>
                        <a id=""modoWhite"" class=""navbar-item modoWhite"" href=""#"">
                            <svg id=""icone"" style=""width:2em;height:2em"" viewBox=""0 0 24 24"">
                                <path fill=""currentColor"" d=""M20,11H23V13H20V11M1,11H4V13H1V11M13,1V4H11V1H13M4.92,3.5L7.05,5.64L5.63,7.05L3.5,4.93L4.92,3.5M16.95,5.63L19.07,3.5L20.5,4.93L18.37,7.05L16.95,5.63M12,6A6,6 0 0,1 18,12C18,14.22 16.79,16.16 15,17.2V19A1,1 0 0,1 14,20H10A1,1 0 0,1 9,19V17.2C7.21,16.16 6,14.22 6,12A6,6 0 0,1 12,6M14,21V22A1,1 0 0,1 13,23H11A1,1 0 0,1 10,22V21H14M11,18H13V15.87C14.73,15.43 16,13.86 16,12A4,4 0 0,0 12,8A4,4 0 0,0 8,12C8,13.86 9.27,15.43 11,15.87V18Z"" />
                         ");
            WriteLiteral(@"   </svg>
                            White mode
                        </a>
                        <a id=""modoDark"" class=""navbar-item modoDark"" href=""#"">
                            <svg id=""icone"" style=""width:2em;height:2em"" viewBox=""0 0 24 24"">
                                <path fill=""currentColor"" d=""M12,2A7,7 0 0,0 5,9C5,11.38 6.19,13.47 8,14.74V17A1,1 0 0,0 9,18H15A1,1 0 0,0 16,17V14.74C17.81,13.47 19,11.38 19,9A7,7 0 0,0 12,2M9,21A1,1 0 0,0 10,22H14A1,1 0 0,0 15,21V20H9V21Z"" />
                            </svg>
                            Dark mode
                        </a>
                    </div>
                </div>
            </div>
        </header>
    </div>
    <!-- Hero content: will be in the middle -->
    <div class=""hero-body"">
        <div class=""container has-text-centered"">
            <h1 class=""title"">
                Calculadora de hora p/ Freelas
            </h1>
            <h2 class=""subtitle"">
                Uma calculadora que irá te mostra");
            WriteLiteral(@"r o valor da sua hora perante o freelance cotado.
            </h2>
        </div>
    </div>

    <!-- Hero footer: will stick at the bottom -->
    <div class=""hero-foot"">
        <nav class=""tabs is-boxed is-fullwidth level is-mobile"">
            <div class=""level-item has-text-centered"">
                <div>

                </div>
            </div>
            <div class=""level-item has-text-centered"">
                <div>

                </div>
            </div>
            <div class=""level-item has-text-centered"">
                <div>

                </div>
            </div>
            <div class=""level-item has-text-centered"">
                <div>

                </div>
            </div>
        </nav>
    </div>
</section>
");
#nullable restore
#line 86 "C:\Users\thiag\source\repos\CalculaFreela\Views\Home\Index.cshtml"
  
   await Html.RenderPartialAsync("_CalcFreelas");

#line default
#line hidden
#nullable disable
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
