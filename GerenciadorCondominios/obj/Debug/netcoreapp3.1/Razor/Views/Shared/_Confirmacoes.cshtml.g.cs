#pragma checksum "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c12a5459b600dba37aec4ccb60ca48cc84f663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Confirmacoes), @"mvc.1.0.view", @"/Views/Shared/_Confirmacoes.cshtml")]
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
#line 1 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c12a5459b600dba37aec4ccb60ca48cc84f663", @"/Views/Shared/_Confirmacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0cfb221ef3ab357afb8a1c2acf66aa8d50e076", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Confirmacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["NovoRegistro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel green darken-3 valign-wrapper white-text\">\r\n        <div class=\"col s1\">\r\n            <i class=\"material-icons\">check_box</i>\r\n        </div>\r\n\r\n        <div class=\"col s11\">\r\n            ");
#nullable restore
#line 9 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["NovoRegistro"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["Atualizacao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel blue darken-3 valign-wrapper white-text\">\r\n        <div class=\"col s1\">\r\n            <i class=\"material-icons\">check_box</i>\r\n        </div>\r\n\r\n        <div class=\"col s11\">\r\n            ");
#nullable restore
#line 23 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["Atualizacao"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["Exclusao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel red darken-3 valign-wrapper white-text\">\r\n        <div class=\"col s1\">\r\n            <i class=\"material-icons\">check_box</i>\r\n        </div>\r\n\r\n        <div class=\"col s11\">\r\n            ");
#nullable restore
#line 36 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["Exclusao"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

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
