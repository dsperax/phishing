#pragma checksum "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33c57c3561d219062ef6db68664692fd90e14196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pergunta_Pergunta), @"mvc.1.0.view", @"/Views/Pergunta/Pergunta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pergunta/Pergunta.cshtml", typeof(AspNetCore.Views_Pergunta_Pergunta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c57c3561d219062ef6db68664692fd90e14196", @"/Views/Pergunta/Pergunta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f75807451ffeda2f4e54ecbdf141c1d16f844eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pergunta_Pergunta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<phishing.Models.Pergunta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/q1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
  
    ViewData["Title"] = "Pergunta";

#line default
#line hidden
            BeginContext(77, 104, true);
            WriteLiteral("\r\n<div id=\"container\" class=\"container\">\r\n    <div id=\"workspace\" class=\"texto-principal\">\r\n        <h1>");
            EndContext();
            BeginContext(182, 12, false);
#line 8 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(194, 32, true);
            WriteLiteral("</h1>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(227, 15, false);
#line 10 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(242, 391, true);
            WriteLiteral(@"
        </p>
        <div id=""respostas"">           
            <button id=""btn-phishing"" class=""botao-alternativa"" onclick=""clicou()"">PHISHING</button>
            <button id=""btn-verdadeiro"" class=""botao-alternativa"" onclick=""clicou()"">VERDADEIRO</button>
        </div>
    </div>
    <div class=""formulario-questoes"">
        <a href=""drive--google.com"" onclick=""return false"">");
            EndContext();
            BeginContext(633, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33c57c3561d219062ef6db68664692fd90e141965273", async() => {
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
            BeginContext(662, 28, true);
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(707, 296, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    
    var rsp = document.getElementById(""btn-verdadeiro"");
    var questao = [];
    var nq = 1;
    var nAcertos = 0;

    function avancaProximaPergunta() {
        questao.push(1);
    }

        function clicou() {

            var np = """);
                EndContext();
                BeginContext(1004, 18, false);
#line 36 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                 Write(Model.Num_Pergunta);

#line default
#line hidden
                EndContext();
                BeginContext(1022, 39, true);
                WriteLiteral("\";\r\n            var respostaCorreta = \"");
                EndContext();
                BeginContext(1062, 14, false);
#line 37 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                              Write(Model.Resposta);

#line default
#line hidden
                EndContext();
                BeginContext(1076, 436, true);
                WriteLiteral(@""";
            var resposta = { NumPergunta: nq, RespostaPergunta: respostaCorreta };

            console.log(respostaCorreta);

            rsp.addEventListener(""click"", function (event) {
                nq = questao.length;
                console.log(nq);

                if (event.target.innerHTML == ""PHISHING"" || event.target.innerHTML == ""VERDADEIRO"") {

                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(1513, 42, false);
#line 49 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                         Write(Url.Action("RespostaPergunta", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(1555, 739, true);
                WriteLiteral(@"',
                        data: { NumPergunta: nq }
                    }).done(function (data) {
                        //console.log(data);
                        if (event.target.innerHTML != respostaCorreta) {
                            $('#workspace h1').html(data.mensagemErro);
                        } else {
                            $('#workspace h1').html(data.mensagemAcerto);
                            nAcertos++;

                        }
                        $('#workspace p').html(data.descricaoResposta);
                        $('#respostas').html(data.botaoProximaPergunta);
                    });

                    $.ajax({
                    type: ""POST"",
                    url: '");
                EndContext();
                BeginContext(2295, 39, false);
#line 66 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                     Write(Url.Action("SalvaResposta", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(2334, 470, true);
                WriteLiteral(@"',
                    data: JSON.stringify(resposta),
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    success: function () {
                    },
                    error: function () {
                        alert(""Error"");
                    }
                    });

                } else {              
                        $.ajax({
                        url: '");
                EndContext();
                BeginContext(2805, 41, false);
#line 79 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE mexer dia 11\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                         Write(Url.Action("GetNextQuestion", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(2846, 596, true);
                WriteLiteral(@"',
                        data: { NumPergunta: nq }
                    }).done(function (data) {
                        //console.log(data);
                        $('#workspace h1').html(data.titulo);
                        $('#workspace p').html(data.descricao);
                        $('.formulario-questoes').html(data.conteudoDiv);
                        $('#respostas').html(data.botaoRespostas);
                        //alert('passou 3 ajax');
                    });
                }
                       
            });
            
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(3445, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<phishing.Models.Pergunta> Html { get; private set; }
    }
}
#pragma warning restore 1591