#pragma checksum "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\_ViewImports.cshtml"
using TicTacToe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\_ViewImports.cshtml"
using TicTacToe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251dceebe3e6747e5343b222378328fe467f6241", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed27150", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - TicTacToe</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed27793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed28971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed210149", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed211415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed212515", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed213615", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed215419", async() => {
                WriteLiteral("\r\n    <header>\r\n        <div class=\"border-bottom box-shadow\">\r\n            <div class=\"container\">\r\n                <h2>TicTacToe</h2>\r\n                <div class=\"userInfo\">\r\n                    <div>");
#nullable restore
#line 20 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 882, "\"", 921, 1);
#nullable restore
#line 21 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 889, Url.Action("Logoff", "Account"), 889, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Logoff</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div class=\"container\">\r\n        <div id=\"dialog-confirm\" title=\"Hello\"></div>\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 29 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2020 - TicTacToe\r\n        </div>\r\n    </footer>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed217248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ac7f2bb3c4d360e4ed9b3185d602eab6438ed218348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 39 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 40 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script type=""text/javascript"">
    var connectionGame = new signalR.HubConnectionBuilder().withUrl(""/gameHub"").build();

    connectionGame.on(""RemovePlayer"", function (userName) {
        $(""#"" + userName, ""#playersList"").remove();
    });

    connectionGame.on(""AddPlayer"", function (userName) {
        if (""");
#nullable restore
#line 53 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" != userName) {
            if ($(""#"" + userName, ""#playersList"").length == 0) {
                $(""#playersList"").prepend(""<div id='"" + userName + ""' class='player'>"" + userName + ""</div>"");
            }
        }
    });

    connectionGame.on(""InvitationSent"", function (player1, gameId) {
        $(""#dialog-confirm"").html(""User "" + player1 + "" has invited you. Do you want to play?"");
        $(""#dialog-confirm"").dialog({
            resizable: false,
            closeOnEscape: false,
            height: ""auto"",
            width: 400,
            modal: true,
            buttons: {
                Ok: function () {
                    $.ajax({
                        url: """);
#nullable restore
#line 71 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                         Write(Url.Action("PlayPartial", "Game"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        type: ""GET"",
                        data: {
                            gameId: gameId
                        },
                        success: function (html) {
                            $(""main"").html(html);
                            history.pushState(null, ""Play"", ""/Game/Play?gameId="" + gameId);
                            connectionGame.invoke(""InvitationAccepted"", player1, gameId);
                        }
                    });
                    $(this).dialog(""close"");

                },
                Cancel: function () {
                    connectionGame.invoke(""InvitationRejected"", player1, gameId);
                    $(this).dialog(""close"");
                }
            }
        });
        $(this).dialog(""open"");
    });

    connectionGame.on(""InvitationAccepted"", function () {
        $(""#player2Status"").text(""");
#nullable restore
#line 95 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                             Write(TicTacToe.BLL.Enums.PlayerStatus.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        $(\"#gameStatus\").text($(\"#turn\").val() + \" turn\");\r\n    });\r\n\r\n    connectionGame.on(\"InvitationRejected\", function () {\r\n        $(\"#player2Status\").text(\"");
#nullable restore
#line 100 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                             Write(TicTacToe.BLL.Enums.PlayerStatus.Leave);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        $(\"#isOver\").val(true).change();\r\n    });\r\n\r\n    connectionGame.on(\"MoveDone\", function (movePosition) {\r\n        var activePlayer = $(\"#activePlayer\").val();\r\n        if (activePlayer == \"");
#nullable restore
#line 106 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                        Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\".cell[location=\'\" + movePosition + \"\']\").attr(\"zero\", \"zero\");\r\n        }\r\n        else if (activePlayer == \"");
#nullable restore
#line 109 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                             Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") {
            $("".cell[location='"" + movePosition + ""']"").attr(""cross"", ""cross"");
        }
        $(""#turn"").val(activePlayer).change();
    });

    connectionGame.on(""GameIsOver"", function (winCombination, winner) {
        if (winCombination) {
            var classToAdd;
            var activePlayer = $(""#activePlayer"").val();
            if (activePlayer == winner) {
                classToAdd = ""bg-success"";
            }
            else {
                classToAdd = ""bg-danger"";
            }

            $.each(winCombination, function (key, value) {
                $("".cell[location='"" + value + ""']"").addClass(classToAdd);
            });
        }

        $(""#isOver"").val(true).change();
    });

    connectionGame.on(""OpponentBack"", function () {
        if ($(""#activePlayer"").val() == """);
#nullable restore
#line 135 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                    Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player2Status\").text(\"");
#nullable restore
#line 136 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n        else if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 138 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                         Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player1Status\").text(\"");
#nullable restore
#line 139 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n    });\r\n\r\n    connectionGame.on(\"ActiveUserBack\", function () {\r\n        if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 144 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                    Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player1Status\").text(\"");
#nullable restore
#line 145 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n        else if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 147 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                         Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player2Status\").text(\"");
#nullable restore
#line 148 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n    });\r\n\r\n    connectionGame.on(\"OpponentLost\", function (activePlayer) {\r\n        if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 153 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                    Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player2Status\").text(\"");
#nullable restore
#line 154 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Pending);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n        else if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 156 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                         Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player1Status\").text(\"");
#nullable restore
#line 157 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Pending);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n    });\r\n\r\n    connectionGame.on(\"CloseGame\", function () {\r\n        if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 162 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                    Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player2Status\").text(\"");
#nullable restore
#line 163 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Leave);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        }\r\n        else if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 165 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                         Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n            $(\"#player1Status\").text(\"");
#nullable restore
#line 166 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                 Write(TicTacToe.BLL.Enums.PlayerStatus.Leave);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        }

        $(""#isOver"").val(true).change();
    });

    connectionGame.on(""Logoff"", function () {
        if ($(""#dialog-confirm"").is("":visible"")) {
            $(""#dialog-confirm"").dialog(""close"");
        }

        window.location = """);
#nullable restore
#line 177 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                      Write(Url.Action("Logoff", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    });\r\n\r\n    connectionGame.start();\r\n\r\n    $(document).on(\"click\", \".cell\", function () {\r\n        if (!$(\"#isOver\").val()) {\r\n            if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 184 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                        Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                && $(\"#turn\").val() == \"");
#nullable restore
#line 185 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                   Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                && !$(this).attr(\"cross\")) {\r\n                $(this).attr(\"cross\", \"cross\");\r\n                $(\"#turn\").val(\"");
#nullable restore
#line 188 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                           Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").change();\r\n                connectionGame.invoke(\"MoveDone\", parseInt($(\"#gameId\").val()), parseInt($(this).attr(\"location\")));\r\n            }\r\n            else if ($(\"#activePlayer\").val() == \"");
#nullable restore
#line 191 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                             Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                && $(\"#turn\").val() == \"");
#nullable restore
#line 192 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                                   Write(TicTacToe.BLL.Enums.PlayerNumber.Player2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                && !$(this).attr(\"zero\")) {\r\n                $(this).attr(\"zero\", \"zero\");\r\n                $(\"#turn\").val(\"");
#nullable restore
#line 195 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                           Write(TicTacToe.BLL.Enums.PlayerNumber.Player1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").change();
                connectionGame.invoke(""MoveDone"", parseInt($(""#gameId"").val()), parseInt($(this).attr(""location"")));
            }
        }
    });

    $(document).on(""click"", ""#closeGame"", function () {
        $.ajax({
            url: """);
#nullable restore
#line 203 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
             Write(Url.Action("IndexPartial", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""GET"",
            success: function (html) {
                connectionGame.invoke(""CloseGame"", parseInt($(""#gameId"").val()));
                $(""main"").html(html);
                history.pushState(null, ""Home"", ""/"");
            }
        });
    });

    $(document).on(""change"", ""#turn"", function () {
        $(""#gameStatus"").text($(this).val() + "" turn"");
    });

    $(document).on(""change"", ""#isOver"", function () {
        $(""#gameStatus"").text(""Game is over"");
    });

    $(document).on(""click"", "".player"", function () {
        var player2 = $(this).attr(""id"");
        $.ajax({
            url: """);
#nullable restore
#line 224 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
             Write(Url.Action("Play", "Game"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            type: \"POST\",\r\n            data: {\r\n                player2: player2,\r\n                player1: \"");
#nullable restore
#line 228 "C:\Users\natal\source\repos\TicTacToe\TicTacToe.Web\Views\Shared\_Layout.cshtml"
                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
            },
            success: function (html) {
                $(""main"").html(html);
                history.pushState(null, ""Play"", ""/Game/Play?gameId="" + $(""#gameId"").val());
                connectionGame.invoke(""InvitePlayer"", player2, parseInt($(""#gameId"").val()));
            }
        });
    });
</script>");
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
