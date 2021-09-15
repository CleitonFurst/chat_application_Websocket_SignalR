#pragma checksum "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ffba15b8a3cb9166a968c51e73e4cd32bcfe09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_PrivateMessage), @"mvc.1.0.view", @"/Views/Chat/PrivateMessage.cshtml")]
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
#line 1 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\_ViewImports.cshtml"
using Chat_Blue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\_ViewImports.cshtml"
using Chat_Blue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ffba15b8a3cb9166a968c51e73e4cd32bcfe09", @"/Views/Chat/PrivateMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7dd2407eb2cde9dfeea3d6c9093747c37187d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_PrivateMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SendMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
  
    var messages = ViewBag.Messages as List<Message>;
    var current = ViewBag.CurrentUser as AppUser;
    var username = current.UserName;
    var target = ViewBag.TargetUser as AppUser;
    var targetname = target.UserName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .chat {
        max-height: 500px;
        overflow-y: scroll;
        border: 1px solid #ffa0a0;
    }

        .chat::-webkit-scrollbar {
            width: 5px;
        }

        .chat::-webkit-scrollbar-thumb {
            box-shadow: inset 0 0 6px rgba(0,0,0,.3);
            background-color: silver;
        }
</style>

<h2>Chat com ");
#nullable restore
#line 26 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
        Write(targetname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"bg-light chat jumbotron\" id=\"chat\">\r\n");
#nullable restore
#line 28 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
     if (messages != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
         foreach (var message in messages.OrderBy(m => m.Datetime))
        {
            var position = username == message.UserName ? "text-right" : "text-left";
            var alert = username == message.UserName ? "alert-info" : "alert-secondary";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1021, "\"", 1048, 2);
            WriteAttributeValue("", 1029, "col-md-12", 1029, 9, true);
#nullable restore
#line 35 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
WriteAttributeValue(" ", 1038, position, 1039, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <small class=\"text-dark\">");
#nullable restore
#line 36 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
                                        Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1148, "\"", 1173, 3);
            WriteAttributeValue("", 1156, "alert", 1156, 5, true);
            WriteAttributeValue(" ", 1161, "mb-0", 1162, 5, true);
#nullable restore
#line 37 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
WriteAttributeValue(" ", 1166, alert, 1167, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                        <span class=\"d-block\">");
#nullable restore
#line 38 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
                                         Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <small class=\"text-info\">");
#nullable restore
#line 40 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
                                        Write(message.Datetime.ToString("dd/MM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01ffba15b8a3cb9166a968c51e73e4cd32bcfe098469", async() => {
                WriteLiteral("\r\n    <div class=\"input-group col-md-12 mb-4\">\r\n        <input name=\"Text\" id=\"MessageText\" class=\"form-control\" />\r\n        <button type=\"submit\" id=\"submitBtn\" class=\"btn btn-info\">Enviar</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\r\n\r\n    <script>\r\n        var username = \"");
#nullable restore
#line 59 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
                   Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var targetname = \"");
#nullable restore
#line 60 "C:\Users\furst\Desktop\Chat_Blue_teste_2\Chat_Blue\Views\Chat\PrivateMessage.cshtml"
                     Write(targetname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

        var objDiv = document.getElementById(""chat"");
        objDiv.scrollTop = objDiv.scrollHeight;

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build();

        function formataData(dateString) {
            var date = new Date(Date.parse(dateString));
            var dateStr =
                (""00"" + date.getDate()).slice(-2) + ""/"" +
                (""00"" + (date.getMonth() + 1)).slice(-2) + "" "" + // ""00"" + 9 -> ""009"" -> ""09"" ; ""00"" + 12 -> ""0012"" -> ""12""
                (""00"" + date.getHours()).slice(-2) + "":"" +
                (""00"" + date.getMinutes()).slice(-2);
            return dateStr;
        }

        connection.on(""PrivateMessage"", (data) => {
            var position = data.userName === username ? ""text-right"" : ""text-left"";
            var alert = data.userName === username ? ""alert-info"" : ""alert-secondary"";

            var message = document.createElement(""div"");
            message.className = ""row"";

            var messag");
                WriteLiteral(@"eCol = document.createElement(""div"");
            messageCol.classList = ""col-md-12 "" + position;

            var messageUser = document.createElement(""small"");
            messageUser.className = ""text-dark"";
            messageUser.textContent = data.userName;

            var messageAlert = document.createElement(""div"");
            messageAlert.classList = ""alert mb-0 "" + alert;

            var messageAlertMessage = document.createElement(""div"");
            messageAlertMessage.className = ""d-block"";
            messageAlertMessage.innerHTML = data.text;

            var messageDt = document.createElement(""small"");
            messageDt.className = ""text-info"";
            messageDt.textContent = formataData(data.datetime);

            messageAlert.appendChild(messageAlertMessage);
            messageCol.appendChild(messageUser);
            messageCol.appendChild(messageAlert);
            messageCol.appendChild(messageDt);
            message.appendChild(messageCol);
          ");
                WriteLiteral(@"  console.log(message);
            document.getElementById(""chat"").appendChild(message);
            objDiv.scrollTop = objDiv.scrollHeight;
        });

        connection.start().then(function () {
            connection.invoke(""joinPrivate"", targetname);
            document.getElementById(""SendMessageForm"").addEventListener(""submit"", function (event) {
                event.preventDefault();

                var data = {
                    Text: document.getElementById(""MessageText"").value,
                    UserName: username,
                    TargetName: targetname
                }
                console.log(data);

                document.getElementById(""MessageText"").value = """";
                connection.invoke(""sendPrivateMessage"", data).catch(function (err) {
                    return console.error(err.toString());
                });
            });
        }).catch(function (err) {
            return console.error(err.toString());
        });

        window.a");
                WriteLiteral("ddEventListener(\"unload\", function () {\r\n            connection.invoke(\"leavePrivate\", targetname);\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
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
