#pragma checksum "C:\Users\Julio Bindandi\Desktop\e-commerce\e-commerce\e-commerce\e-commerce\Views\Produto\CatalogoProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3338d89c9fb5574208f6ac96afa16690f20f75b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_CatalogoProduto), @"mvc.1.0.view", @"/Views/Produto/CatalogoProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/CatalogoProduto.cshtml", typeof(AspNetCore.Views_Produto_CatalogoProduto))]
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
#line 1 "C:\Users\Julio Bindandi\Desktop\e-commerce\e-commerce\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce;

#line default
#line hidden
#line 2 "C:\Users\Julio Bindandi\Desktop\e-commerce\e-commerce\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3338d89c9fb5574208f6ac96afa16690f20f75b0", @"/Views/Produto/CatalogoProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89f65dd6894ee13e717bed8c15fd34f1952c3ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_CatalogoProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/Produto/catalogoProduto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Julio Bindandi\Desktop\e-commerce\e-commerce\e-commerce\e-commerce\Views\Produto\CatalogoProduto.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 819, true);
            WriteLiteral(@"    <div class=""d-flex align-items-center flex-column bd-highlight mb-3"">
        <div class=""p-2 bd-highlight"">
            <h1>Catalogo de Produtos</h1>
        </div>
        <div id=""produtos"" class=""p-2 bd-highlight"">

        </div>
        <!--
    <div style=""width:500px; background-color:#e8e8e8"">
        <div class=""d-flex bd-highlight"">
            <div class=""p-2 flex-shrink-1 bd-highlight"">
                <img src=""~/images/sem_imagem.jpg"" />
            </div>
            <div class=""p-2 w-100 bd-highlight"">
                <div style=""height:50%;"">
                    <a>Nome</a>
                </div>
                <div style=""height:50%;"">
                    <a>Preço</a>
                </div>
            </div>

        </div>

    </div>-->
    </div>
        ");
            EndContext();
            BeginContext(914, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3338d89c9fb5574208f6ac96afa16690f20f75b04910", async() => {
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
            EndContext();
            BeginContext(974, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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