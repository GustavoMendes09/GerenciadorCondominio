#pragma checksum "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83846fd304cc541d847c8f2a0919eea6a64910d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#nullable restore
#line 6 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
using GerenciadorCondominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83846fd304cc541d847c8f2a0919eea6a64910d3", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0cfb221ef3ab357afb8a1c2acf66aa8d50e076", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/OperacoesUsuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerenciarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83846fd304cc541d847c8f2a0919eea6a64910d35079", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""tabelas"">
    <div class=""collection with-header"">
        <div class=""collection-header grey darken-1"">
            <div class=""row"">
                <div class=""col s10"">
                    <h6 class=""white-text"">Moradores cadastrados</h6>
                </div>
            </div>
        </div>

        <div class=""collection-item"">
            <table class=""table-striped highlight"">
                <thead>
                    <tr>
                        <th>
                            Nome
                        </th>
                        <th>
                            CPF
                        </th>
                        <th>
                            Email
                        </th>
                        <th>
                            Telefone
                        </th>

                        <th>
                            Status
                        </th>

                        <th></th>
                    </tr>
         ");
            WriteLiteral("       </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 47 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n");
#nullable restore
#line 63 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                             if (item.Status == StatusConta.Analisando)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge purple darken-3\" data-badge-caption=\"\"");
            BeginWriteAttribute("id", " id=\"", 2220, "\"", 2233, 1);
#nullable restore
#line 66 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2225, item.Id, 2225, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td");
            BeginWriteAttribute("class", " class=\"", 2362, "\"", 2378, 1);
#nullable restore
#line 69 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2370, item.Id, 2370, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"btn-floating blue darken-4 btnAprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2466, "\"", 2520, 6);
            WriteAttributeValue("", 2476, "AprovarUsuario(\'", 2476, 16, true);
#nullable restore
#line 70 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2492, item.Id, 2492, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2500, "\',", 2500, 2, true);
            WriteAttributeValue(" ", 2502, "\'", 2503, 2, true);
#nullable restore
#line 70 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2504, item.UserName, 2504, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2518, "\')", 2518, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_up</i></a>\r\n                                    <a class=\"btn-floating red darken-4 btnReprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2650, "\"", 2705, 6);
            WriteAttributeValue("", 2660, "ReprovarUsuario(\'", 2660, 17, true);
#nullable restore
#line 71 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2677, item.Id, 2677, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2685, "\',", 2685, 2, true);
            WriteAttributeValue(" ", 2687, "\'", 2688, 2, true);
#nullable restore
#line 71 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2689, item.UserName, 2689, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2703, "\')", 2703, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_down</i></a>\r\n                                </td>\r\n");
#nullable restore
#line 73 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                            }
                            else if (item.Status == StatusConta.Aprovado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge green darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 77 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83846fd304cc541d847c8f2a0919eea6a64910d314733", async() => {
                WriteLiteral("<i class=\"material-icons\">group</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-usuarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-usuarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                                                                                     WriteLiteral(item.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 83 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge orange darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 87 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
#nullable restore
#line 89 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 92 "D:\Projetos\VisualStudio\GerenciadorCondominio\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
