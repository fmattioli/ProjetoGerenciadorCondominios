#pragma checksum "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8344454031a18e335954cd00ac9009c02b0c0e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_MinhasInformacoes), @"mvc.1.0.view", @"/Views/Usuarios/MinhasInformacoes.cshtml")]
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
#line 1 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8344454031a18e335954cd00ac9009c02b0c0e8f", @"/Views/Usuarios/MinhasInformacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0cfb221ef3ab357afb8a1c2acf66aa8d50e076", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MinhasInformacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GerenciadorCondominios.BLL.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small purple darken-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
  
    ViewData["Title"] = "Minhas Informacoes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"card horizontal\">\r\n    <div class=\"card-image\">\r\n        <i><img");
            BeginWriteAttribute("src", " src=\"", 222, "\"", 252, 1);
#nullable restore
#line 10 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
WriteAttributeValue("", 228, Url.Content(Model.Foto), 228, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\"/></i>\r\n    </div>\r\n\r\n    <div class=\"card-stacked\">\r\n        <div class=\"card-content\">\r\n            <div class=\"row\">\r\n                <div class=\"col s6\">\r\n                    <span class=\"card-text purple-text darken-3\">Nome - ");
#nullable restore
#line 17 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
                                                                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col s6\">\r\n                    <span class=\"card-text purple-text darken-3\">Email - ");
#nullable restore
#line 20 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
                                                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col s6\">\r\n                    <span class=\"card-text purple-text darken-3\">Cpf - ");
#nullable restore
#line 27 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
                                                                  Write(Model.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col s6\">\r\n                    <span class=\"card-text purple-text darken-3\">Telefone - ");
#nullable restore
#line 30 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
                                                                       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"card-action\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8344454031a18e335954cd00ac9009c02b0c0e8f7077", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\BackEnd\GerenciadorCondominios\GerenciadorCondominios\Views\Usuarios\MinhasInformacoes.cshtml"
                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n");
            WriteLiteral("</div>\r\n\r\n<div>\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GerenciadorCondominios.BLL.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
