#pragma checksum "C:\Users\patricia.russ\Desktop\Projeto\Views\Home\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49de8403d33bf7e4243ed122ae52674df794e653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resultado), @"mvc.1.0.view", @"/Views/Home/Resultado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Resultado.cshtml", typeof(AspNetCore.Views_Home_Resultado))]
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
#line 1 "C:\Users\patricia.russ\Desktop\Projeto\Views\_ViewImports.cshtml"
using Projeto;

#line default
#line hidden
#line 2 "C:\Users\patricia.russ\Desktop\Projeto\Views\_ViewImports.cshtml"
using Projeto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49de8403d33bf7e4243ed122ae52674df794e653", @"/Views/Home/Resultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4dfd97469170fe8b85a6370378ea67b5320a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NumeroViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Voltar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\patricia.russ\Desktop\Projeto\Views\Home\Resultado.cshtml"
  
    ViewData["Tile"] = "Resultado";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 261, true);
            WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-body"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h3>Resultado</h3>
                <br/>
                 <br/> 
                 
                 O  Número ");
            EndContext();
            BeginContext(332, 12, false);
#line 15 "C:\Users\patricia.russ\Desktop\Projeto\Views\Home\Resultado.cshtml"
                      Write(Model.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(344, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(347, 20, false);
#line 15 "C:\Users\patricia.russ\Desktop\Projeto\Views\Home\Resultado.cshtml"
                                     Write(Model.ResultadoFeliz);

#line default
#line hidden
            EndContext();
            BeginContext(367, 3, true);
            WriteLiteral(" e ");
            EndContext();
            BeginContext(371, 22, false);
#line 15 "C:\Users\patricia.russ\Desktop\Projeto\Views\Home\Resultado.cshtml"
                                                             Write(Model.ResultadoSortudo);

#line default
#line hidden
            EndContext();
            BeginContext(393, 53, true);
            WriteLiteral("\r\n            </div>\r\n            <br/>\r\n            ");
            EndContext();
            BeginContext(446, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49de8403d33bf7e4243ed122ae52674df794e6535434", async() => {
                BeginContext(493, 37, true);
                WriteLiteral("\r\n               Voltar\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(534, 66, true);
            WriteLiteral(" \r\n        </div>\r\n        <hr />\r\n   \r\n  </div>\r\n </div>     \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NumeroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
