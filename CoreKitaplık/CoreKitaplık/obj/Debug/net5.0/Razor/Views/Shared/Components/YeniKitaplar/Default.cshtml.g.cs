#pragma checksum "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1b19d3e5f8c0378e59d19eb7b36e23e3c31a145452ad2443aac2f67500afafc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YeniKitaplar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1b19d3e5f8c0378e59d19eb7b36e23e3c31a145452ad2443aac2f67500afafc0", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
    #nullable restore
    public class Views_Shared_Components_YeniKitaplar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreKitaplık.Models.Kitaplar>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>AD</th>\r\n            <th>YAZAR</th>\r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml"
         foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 17 "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                 x.ID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 18 "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                 x.KitapAd

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 19 "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                 x.Yazar

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Dell\source\repos\CoreKitaplık\CoreKitaplık\Views\Shared\Components\YeniKitaplar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreKitaplık.Models.Kitaplar>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
