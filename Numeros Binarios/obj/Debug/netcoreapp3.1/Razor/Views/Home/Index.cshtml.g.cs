#pragma checksum "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dfe5d8f663d8ef3145c1d8508aabd926d325ddd"
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
#line 1 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\_ViewImports.cshtml"
using Numeros_Binarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\_ViewImports.cshtml"
using Numeros_Binarios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfe5d8f663d8ef3145c1d8508aabd926d325ddd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18972f9d4382ec5147112e905f0077ff9834532", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>EJERCICIO 1: Numeros Binarios</h1>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 188, "\"", 196, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 9 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number1,
               new { @class = "form-control", placeholder = "Numero 1", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number1, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 13 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number2,
               new { @class = "form-control", placeholder = "Numero 2", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number2, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 17 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number3,
                   new { @class = "form-control", placeholder = "Numero 3", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number3, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 21 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number4,
                   new { @class = "form-control", placeholder = "Numero 4", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number4, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 25 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number5,
                   new { @class = "form-control", placeholder = "Numero 5", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number5, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 29 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number6,
                   new { @class = "form-control", placeholder = "Numero 6", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number6, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 33 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number7,
                   new { @class = "form-control", placeholder = "Numero 7", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 35 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number7, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 37 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number8,
                   new { @class = "form-control", placeholder = "Numero 8", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number8, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 41 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number9,
                   new { @class = "form-control", placeholder = "Numero 9", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number9, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 45 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.number10,
                   new { @class = "form-control", placeholder = "Numero 10", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 47 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.number10, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <button class=\"btn btn-primary\" type=\"submit\">\r\n                Enviar numeros\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin: 2%;\">\r\n    <h4>Los numeros convertidos a binario son:</h4>\r\n    <table style=\"border:inset\" class=\"table table-dark\">\r\n        <tr style=\"border:black 3px;\">\r\n");
#nullable restore
#line 59 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
             for (int i = 0; i <= 9; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"border:black 2px solid;\">");
#nullable restore
#line 61 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
                                               Write(ViewData["numIngresado" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 62 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr style=\"border:black 3px;\">\r\n");
#nullable restore
#line 66 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
             for (int i = 0; i <= 9; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"border:black 2px solid;\">");
#nullable restore
#line 68 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"
                                               Write(ViewData["num" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "C:\Users\chris\source\repos\Numeros Binarios\Numeros Binarios\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n    </table>\r\n      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
