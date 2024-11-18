#pragma checksum "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2144714f7dd921066bdf0e354b0479dcf7ac745"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2144714f7dd921066bdf0e354b0479dcf7ac745", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c345eb9c2046d08d98388eacd67f74422e01532e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuarioDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post, new { Id = "formulario" }))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" style=\"width:30%;\">\r\n\r\n        <div class=\"mb-3\">\r\n            <label for=\"exampleFormControlInput1\" class=\"form-label\">Nombre</label>\r\n            ");
#nullable restore
#line 11 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(Model => Model.Nombre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"exampleFormControlInput1\" class=\"form-label\">Apellido</label>\r\n            ");
#nullable restore
#line 15 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(Model => Model.Apellido, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"exampleFormControlInput1\" class=\"form-label\">Tipo de Documento</label>\r\n");
#nullable restore
#line 19 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
              
                var items = new SelectList(ViewBag.ListaTipos, "Id", "Nombre");
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(Model => Model.TipoDocumento, items, "Seleccione ...", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"exampleFormControlInput1\" class=\"form-label\">Fecha de Nacimiento</label>\r\n            ");
#nullable restore
#line 27 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(Model => Model.FechaNacimiento, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"exampleFormControlInput1\" class=\"form-label\">Valor a Ganar</label>\r\n            ");
#nullable restore
#line 31 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(Model => Model.ValorGanar, new { @class = "form-control validar" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 34 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
          
            Html.RenderPartial("EstadoCivilView");
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <input type=\"submit\" name=\"name\" value=\"Guardar\" />\r\n\r\n         <br />\r\n           <br />\r\n        <input type=\"submit\" name=\"name\" value=\"Consultar\" />\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\DanielAndresDavilaAr\source\repos\PruebaDesarrollador\APP\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            $(""#FechaNacimiento"").datepicker({
                dateFormat: ""dd/mm/yy"",  // Formato de fecha
                changeMonth: true,      // Permitir cambiar de mes
                changeYear: true,       // Permitir cambiar de año
                yearRange: ""1900:2100"", // Rango de años
                showAnim: ""fadeIn"",     // Animación al mostrar
                showOtherMonths: true,  // Mostrar días de otros meses
                selectOtherMonths: true // Permitir seleccionar días de otros meses
            });
       

            $("".validar"").keydown(function (event) {
                //alert(event.keyCode);
                if ((event.keyCode < 48 || event.keyCode > 57) && (event.keyCode < 96 || event.keyCode > 105) && event.keyCode !== 190 && event.keyCode !== 110 && event.keyCode !== 8 && event.keyCode !== 9) {
                    return false;
                }
            });

            $(""#Fech");
                WriteLiteral("aNacimiento\").keydown(function (event) {\r\n                   return false;\r\n                \r\n            });\r\n        })\r\n       \r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuarioDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
