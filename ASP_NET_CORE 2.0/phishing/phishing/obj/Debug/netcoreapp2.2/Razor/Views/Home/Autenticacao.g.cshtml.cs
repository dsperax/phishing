#pragma checksum "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Home\Autenticacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed2b6b1b85cbee107728042f96fe393a8ed9015b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Autenticacao), @"mvc.1.0.view", @"/Views/Home/Autenticacao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Autenticacao.cshtml", typeof(AspNetCore.Views_Home_Autenticacao))]
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
#line 1 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\_ViewImports.cshtml"
using phishing;

#line default
#line hidden
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\_ViewImports.cshtml"
using phishing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed2b6b1b85cbee107728042f96fe393a8ed9015b", @"/Views/Home/Autenticacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f75807451ffeda2f4e54ecbdf141c1d16f844eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Autenticacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Home\Autenticacao.cshtml"
  
    ViewData["Title"] = "Autenticacao";

#line default
#line hidden
            BeginContext(50, 167, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"texto-principal\">\r\n        <h1>Insira seu nome e e-mail.</h1>\r\n    </div>\r\n    <div class=\"formulario-nome-email\">\r\n        ");
            EndContext();
            BeginContext(217, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed2b6b1b85cbee107728042f96fe393a8ed9015b4003", async() => {
                BeginContext(223, 410, true);
                WriteLiteral(@"
            <input name=""nome"" class=""nome-input"" id=""nomeDoPiao"" type=""text"">
            <label class=""nome-label"" for=""nome"" required>Nome</label>
            <input name=""email"" class=""email-input"" id=""emailDoPiao"" type=""email"">
            <label class=""email-label"" for=""email"" required>E-mail</label>
            <input class=""botao-comecar"" value=""COMEÇAR"" onclick=""autenticaUsuario()"">
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(640, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(681, 350, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    function autenticaUsuario() {
            var nome = document.getElementById(""nomeDoPiao"");
            var email = document.getElementById(""emailDoPiao"");

            var usuario = { Nome: nome.value, Email: email.value };

            $.ajax({
                type: ""POST"",
                url: '");
                EndContext();
                BeginContext(1032, 34, false);
#line 31 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Home\Autenticacao.cshtml"
                 Write(Url.Action("SalvaUsuario", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1066, 455, true);
                WriteLiteral(@"',
                data: JSON.stringify(usuario),
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: function () {
                    console.log('Sucesso!');
                },
                error: function () {
                    alert(""Error"");
                }
            });

        window.location.href = ""/pergunta/pergunta"";

        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(1524, 2, true);
            WriteLiteral("\r\n");
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
