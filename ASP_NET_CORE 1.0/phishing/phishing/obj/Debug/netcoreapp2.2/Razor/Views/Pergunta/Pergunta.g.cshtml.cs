#pragma checksum "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210ce5bf6a135e2a0117655fffdbbc440e726bec"
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
#line 1 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\_ViewImports.cshtml"
using phishing;

#line default
#line hidden
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\_ViewImports.cshtml"
using phishing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210ce5bf6a135e2a0117655fffdbbc440e726bec", @"/Views/Pergunta/Pergunta.cshtml")]
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
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
  
    ViewData["Title"] = "Pergunta";

#line default
#line hidden
            BeginContext(77, 104, true);
            WriteLiteral("\r\n<div id=\"container\" class=\"container\">\r\n    <div id=\"workspace\" class=\"texto-principal\">\r\n        <h1>");
            EndContext();
            BeginContext(182, 12, false);
#line 8 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(194, 32, true);
            WriteLiteral("</h1>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(227, 15, false);
#line 10 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(242, 342, true);
            WriteLiteral(@"
        </p>
        <div id=""respostas"">
            <button class=""botao-alternativa"" onclick=""clicou()"">PHISHING</button>
            <button class=""botao-alternativa"" onclick=""clicou()"">VERDADEIRO</button>
        </div>
    </div>
    <div class=""formulario-questoes"">
        <a href=""drive--google.com"" onclick=""return false"">");
            EndContext();
            BeginContext(584, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "210ce5bf6a135e2a0117655fffdbbc440e726bec5142", async() => {
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
            BeginContext(613, 28, true);
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(658, 193, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    var cont = document.getElementById(\"container\");\r\n    var rsp = document.getElementById(\"respostas\");\r\n\r\n    function clicou() {\r\n\r\n        var np = \"");
                EndContext();
                BeginContext(852, 18, false);
#line 29 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
             Write(Model.Num_Pergunta);

#line default
#line hidden
                EndContext();
                BeginContext(870, 35, true);
                WriteLiteral("\";\r\n        var respostaCorreta = \"");
                EndContext();
                BeginContext(906, 14, false);
#line 30 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                          Write(Model.Resposta);

#line default
#line hidden
                EndContext();
                BeginContext(920, 250, true);
                WriteLiteral("\";\r\n        var resposta = { NumPergunta: np, RespostaPergunta: respostaCorreta};\r\n\r\n                rsp.addEventListener(\"click\", function (event) {\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \'");
                EndContext();
                BeginContext(1171, 39, false);
#line 36 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                         Write(Url.Action("SalvaResposta", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(1210, 518, true);
                WriteLiteral(@"',
                        data: JSON.stringify(resposta),
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8"",
                        success: function () {
                            alert('passou primeiro ajax');
                        },
                        error: function () {
                            alert(""Error"");
                        }
                    });

                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(1729, 41, false);
#line 49 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                         Write(Url.Action("GetNextQuestion", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 538, true);
                WriteLiteral(@"',
                        data: { NumPergunta: np }
                    }).done(function (data) {
                        console.log(data);
                        $('#workspace h1').html(data.titulo);
                        $('#workspace p').html(data.descricao);
                        //COLOCAR O HTML NA MODEL nos campos novos
                       // $('.formulario-questoes').html(data.conteudoDiv);
                        //fazer para conteudo acerto
                    });
                });

            }

");
                EndContext();
                BeginContext(2833, 12833, true);
                WriteLiteral(@"
    //    //Pergunta 2

    //        function pergunta2() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Você recebeu um fax.</h1>
    //    <p>Sabemos que você não perde tempo, mas vá no seu ritmo.</p>
    //    <button class=""botao-alternativa"" onclick=""clicou2()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou2()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q2.png"" />
    //</div>`

    //        }

    //        function acertouQuestao2() {
    //        //incrementa acertos
    //         ws.innerHTML = `<h1>Correto!</h1>
    //<p>Bela sacada! Como você percebeu, o domínio do e-mail do remetente tem um erro ortográfico (“efacks”), e o link aponta para “mailru382.co”. Geralmente os ataques de phishing tentam enganar os destinatários com URLs parecidos.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta3()"">PRÓXIMA PERGUNTA</button>`;
  ");
                WriteLiteral(@"  //        }

    //        function errouQuestao2() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>O domínio do e-mail do remetente tem um erro ortográfico “efacks”. O nome correto seria ""efax"".</p>
    //<button class=""botao-alternativa"" onclick=""pergunta3()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou2() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""PHISHING"") {
    //                acertouQuestao2();
    //            } else if (event.target.innerHTML == ""VERDADEIRO"") {
    //                errouQuestao2();
    //            }
    //            });
    //            }

    //    //Pergunta 3

    //        function pergunta3() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Vamos relembrar os bons tempos!</h1>
    //    <p>Você se lembra de algum colega da escola chamado TK?</p>
    //    <button class=""botao-alternativa"" on");
                WriteLiteral(@"click=""clicou3()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou3()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q3.png"" />
    //    <p style=""display: flex; margin-left: 1rem;"">oi, você se lembra<a href=""www.sytez.net"" style=""text-decoration: none;"">DESTA FOTO</a>?</p>
    //</div>`

    //        }

    //        function acertouQuestao3() {
    //        //incrementa acertos
    //         ws.innerHTML = `<h1>Correto!</h1>
    //<p>Bela sacada! Como você percebeu, o domínio do e-mail do remetente tem um erro ortográfico (“efacks”), e o link aponta para “mailru382.co”. Geralmente os ataques de phishing tentam enganar os destinatários com URLs parecidos.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta4()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function errouQuestao3() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>O domínio do e-mail do remetente tem um err");
                WriteLiteral(@"o ortográfico “efacks”. O nome correto seria ""efax"".</p>
    //<button class=""botao-alternativa"" onclick=""pergunta4()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou3() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""PHISHING"") {
    //                acertouQuestao3();
    //            } else if (event.target.innerHTML == ""VERDADEIRO"") {
    //                errouQuestao3();
    //            }
    //            });
    //            }

    //    //Pergunta 4

    //        function pergunta4() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Essa, não! Parece que você está sem espaço de armazenamento.</h1>
    //    <p>Quanto será que custa o upgrade?</p>
    //    <button class=""botao-alternativa"" onclick=""clicou4()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou4()"">VERDADEIRO</button>
    //</div>
    //<div cla");
                WriteLiteral(@"ss=""formulario-questoes"">
    //    <img src=""~/static/q4.png"" />
    //</div>`

    //        }

    //        function acertouQuestao4() {
    //        //incrementa acertos
    //         ws.innerHTML = `<h1>Correto!</h1>
    //<p>Bela sacada! Como você percebeu, o domínio do e-mail do remetente tem um erro ortográfico (“efacks”), e o link aponta para “mailru382.co”. Geralmente os ataques de phishing tentam enganar os destinatários com URLs parecidos.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta5()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function errouQuestao4() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>O domínio do e-mail do remetente tem um erro ortográfico “efacks”. O nome correto seria ""efax"".</p>
    //<button class=""botao-alternativa"" onclick=""pergunta5()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou4() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.targe");
                WriteLiteral(@"t.innerHTML == ""VERDADEIRO"") {
    //                acertouQuestao4();
    //            } else if (event.target.innerHTML == ""PHISHING"") {
    //                errouQuestao4();
    //            }
    //            });
    //            }

    //    //Pergunta 5

    //        function pergunta5() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Você recebeu um novo tipo de relatório da escola.</h1>
    //    <p>Normalmente, os e-mails dela vêm do endereço “sandra.maia@escolanota10.org”.</p>
    //    <button class=""botao-alternativa"" onclick=""clicou5()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou5()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q5.png"" />
    //</div>`

    //        }

    //        function acertouQuestao5() {
    //        //incrementa acertos
    //        ws.innerHTML = `<h1>Correto!</h1>
    //<p>Este foi um ataque de ph");
                WriteLiteral(@"ishing difícil de perceber. PDFs podem conter malware ou vírus, por isso, verifique se o remetente é confiável e use o navegador ou um serviço on-line como o Google Drive para abri-los com segurança.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta6()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function errouQuestao5() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>Este foi um ataque de phishing difícil de perceber. PDFs podem conter malware ou vírus, por isso, verifique se o remetente é confiável e use o navegador ou um serviço on-line como o Google Drive para abri-los com segurança.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta6()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou5() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""PHISHING"") {
    //                acertouQuestao5();
    //            } else if (event.target.innerHTML == ""VERDADEIRO"")");
                WriteLiteral(@" {
    //                errouQuestao5();
    //            }
    //            });
    //            }

    //    //Pergunta 6

    //        function pergunta6() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Alguém está tentando acessar sua conta.</h1>
    //    <p>Observe com atenção antes de trocar sua senha.</p>
    //    <button class=""botao-alternativa"" onclick=""clicou6()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou6()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q6.png"" />
    //</div>`

    //            }

    //        function acertouQuestao6() {
    //        //incrementa acertos
    //        ws.innerHTML = `<h1>Correto!</h1>
    //<p>Este é quase idêntico a um ataque que hackeou e-mails de políticos. Sempre confira os URLs com atenção.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta7()"">PRÓXIMA PERGUNTA</button>`;
");
                WriteLiteral(@"    //        }

    //        function errouQuestao6() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>Este ataque usou um URL parecido com o do Gmail. Na verdade, este é quase idêntico a um ataque que hackeou e-mails de políticos. Sempre confira os URLs com atenção.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta7()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou6() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""PHISHING"") {
    //                acertouQuestao6();
    //            } else if (event.target.innerHTML == ""VERDADEIRO"") {
    //                errouQuestao6();
    //            }
    //        });
    //            }

    //    //Pergunta 7

    //        function pergunta7() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Parece que sua conta está sendo atacada novamente.</h1>
    //    <p>Ou será que não?</");
                WriteLiteral(@"p>
    //    <button class=""botao-alternativa"" onclick=""clicou7()"">PHISHING</button>
    //    <button class=""botao-alternativa"" onclick=""clicou7()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q7.1.png"" />
    //    <div style=""background-color: #f4f4f4;"">
    //        <img src=""~/static/q7.2.png"" />
    //        <a href=""www.sytez.net""><img src=""~/static/q7.3.png"" /></a>
    //    </div>
    //</div>`
    //            }

    //        function acertouQuestao7() {
    //        //incrementa acertos
    //        ws.innerHTML = `<h1>Correto!</h1>
    //<p>Os hackers tentaram usar o Google para esconder o link real, que é do SytezURL. Um e-mail parecido com esse foi usado para atacar think tanks e políticos.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta8()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function errouQuestao7() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>Os hackers tentar");
                WriteLiteral(@"am usar o Google para esconder o link real, que é do SytezURL. Um e-mail parecido com esse foi usado para atacar think tanks e políticos.</p>
    //<button class=""botao-alternativa"" onclick=""pergunta8()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou7() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""PHISHING"") {
    //                acertouQuestao7();
    //            } else if (event.target.innerHTML == ""VERDADEIRO"") {
    //                errouQuestao7();
    //            }
    //        });
    //            }

    //    //Pergunta 8

    //        function pergunta8() {
    //            cont.innerHTML = `<div id=""workspace"" class=""texto-principal"">
    //    <h1>Você assinou um serviço de planejamento de viagens.</h1>
    //    <p>Você quer que seu e-mail seja verificado, mas olhe com mais atenção.</p>
    //    <button class=""botao-alternativa"" onclick=""clicou8()"">PHISHING</button>
    /");
                WriteLiteral(@"/    <button class=""botao-alternativa"" onclick=""clicou8()"">VERDADEIRO</button>
    //</div>
    //<div class=""formulario-questoes"">
    //    <img src=""~/static/q8.1.png"" />
    //    <a href=""www.tripit.com""><img src=""~/static/q8.2.png"" /></a>
    //    <img src=""~/static/q8.3.png"" />
    //</div>`
    //            }

    //        function acertouQuestao8() {
    //        //incrementa acertos
    //        ws.innerHTML = `<h1>Correto!</h1>
    //<p>É importante ter cuidado com esses tipos de solicitações de acesso à conta e ter certeza de que o desenvolvedor é confiável. Confira o domínio mostrado e clique nele para saber mais detalhes.</p>
    //<button class=""botao-alternativa"" onclick=""resultado()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function errouQuestao8() {
    //        ws.innerHTML = `<h1>Errado!</h1>
    //<p>É importante ter cuidado com esses tipos de solicitações de acesso à conta e ter certeza de que o desenvolvedor é confiável. Confira o domínio mostra");
                WriteLiteral(@"do e clique nele para saber mais detalhes.</p>
    //<button class=""botao-alternativa"" onclick=""resultado()"">PRÓXIMA PERGUNTA</button>`;
    //        }

    //        function clicou8() {
    //        ws.addEventListener(""click"", function(event) {
    //            if (event.target.innerHTML == ""VERDADEIRO"") {
    //                acertouQuestao8();
    //            } else if (event.target.innerHTML == ""PHISHING"") {
    //                errouQuestao8();
    //            }
    //        });
    //        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(15669, 6, true);
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