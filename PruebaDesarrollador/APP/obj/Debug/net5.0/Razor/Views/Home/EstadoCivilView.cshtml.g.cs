#pragma checksum "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\EstadoCivilView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8b6692738138156be2df3adc421836bc585763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EstadoCivilView), @"mvc.1.0.view", @"/Views/Home/EstadoCivilView.cshtml")]
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
#line 1 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\_ViewImports.cshtml"
using APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\_ViewImports.cshtml"
using APP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c8b6692738138156be2df3adc421836bc585763", @"/Views/Home/EstadoCivilView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c345eb9c2046d08d98388eacd67f74422e01532e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EstadoCivilView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuarioDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"container row\">\r\n\r\n        <div class=\"form-check col\">\r\n            ");
#nullable restore
#line 7 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\EstadoCivilView.cshtml"
       Write(Html.RadioButtonFor(Model => Model.EstadoCivil, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Soltero\r\n        </div>\r\n        <div class=\"form-check col\">\r\n            ");
#nullable restore
#line 10 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\EstadoCivilView.cshtml"
       Write(Html.RadioButtonFor(Model => Model.EstadoCivil, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Casado\r\n        </div> \r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuarioDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
