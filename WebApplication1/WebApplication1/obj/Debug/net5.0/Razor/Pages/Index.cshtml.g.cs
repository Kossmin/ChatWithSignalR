#pragma checksum "D:\DemoWeb\DemoJS\ChatWithSignalR\WebApplication1\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1ed29b16a809aedd77910f2ef4635fb89c6c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "D:\DemoWeb\DemoJS\ChatWithSignalR\WebApplication1\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1ed29b16a809aedd77910f2ef4635fb89c6c6f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("for"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(); return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/moment.js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DemoWeb\DemoJS\ChatWithSignalR\WebApplication1\WebApplication1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Chat</h2>\r\n\r\n<div class=\"container-fluid\" id=\"container\">\r\n    <div id=\"div\">\r\n\r\n    </div>\r\n    <div id=\"chatConnectionInfo\">\r\n        <strong>Connecting.....</strong>\r\n    </div>\r\n    <div id=\"chatPannel\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1ed29b16a809aedd77910f2ef4635fb89c6c6f5132", async() => {
                WriteLiteral(@"
            <input type=""hidden"" id=""displayname"" />
            <ul id=""discussion"">
            </ul>
            <div class=""col-3 mb-3"">
                <input type=""text"" class=""form-control"" id=""message"">
            </div>
            <button type=""button"" class=""btn btn-light"" id=""sendmessage"" onclick=""sendMessage()"">Send message</button>
            <button type=""button"" class=""btn btn-info"" id=""changeroom"" onclick=""leaveRoom()"">Change room</button>
            <span>If you want to join your friend's room, please click on the ""change room"" button and input their room Id</span>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1ed29b16a809aedd77910f2ef4635fb89c6c6f7388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const connection = new signalR.HubConnectionBuilder()
        .withUrl(""/chathub"")
        .build();
    /*let chatterName = prompt(""Your name: "");*/
    let chatPannel = document.getElementById(""chatPannel"");
    let chatConnectionInfo = document.getElementById(""chatConnectionInfo"");
    let container = document.getElementById(""container"")
    let RoomIdContext;
    connection.on(""ReceiveMessage"", receiveMessage);
    connection.on(""SendId"", RoomID);
    connection.on(""ReceiveMessages"", addMessages);
    connection.on(""ChangeId"", changeId);


    function addMessages(messages) {
        if (!messages) return;
        let chatHistory = document.getElementById(""discussion"");
        while (chatHistory.firstChild) {
            chatHistory.removeChild(chatHistory.lastChild);
        }
        messages.forEach(function (m) {
            receiveMessage(m.chatterName, m.content, m.sendAt);
        });
    }


    function RoomID(roomId) {
        addRoomId(roomId);
     ");
            WriteLiteral(@"   RoomIdContext = roomId;
    }

    function addRoomId(roomId) {
        let newdiv = document.getElementById(""div"");
        if (newdiv.childElementCount != 0) {
            while (newdiv.firstChild) {
                newdiv.removeChild(newdiv.lastChild);
            }
        }
        newdiv.textContent =""Your room ID: "" + roomId;
    }

    connection.onclose(function () {
        onDisconnected();
        setTimeout(onConnection(), 5000);
    })


    function onConnection() {
        connection.start()
            .then(onConnected)
            .catch(function (err) {
                console.error(err);
            });
    }

    function onDisconnected() {
        chatPannel.style = ""filter :blur(2px)"";;
        chatConnectionInfo.style = ""display:block;"";
        let button = document.getElementById(""sendmessage"");
        button.disable = false;
    }

    function onConnected() {
        chatPannel.style = ""filter :blur(0);"";
        chatConnectionInfo.style = """);
            WriteLiteral(@"display:none;"";
        let content = document.getElementById(""message"");
        content.focus();

        let button = document.getElementById(""sendmessage"");
        button.disable = true;
    }

    onConnection();

    function sendMessage() {
        let content = document.getElementById(""message"");
        let text = content.value;
        if (text.trim() === """") return;
     
        content.value = """";
        content.focus();
        connection.invoke(""SendMessage"", localStorage.getItem(""userEmail""), text, RoomIdContext);
    }

    function receiveMessage(chattername, content, sendAt) {
        let listitem = document.createElement(""li"");
        let spanName = document.createElement(""span"");
        spanName.textContent = chattername + ""  "";
        spanName.style = ""padding-right: 15px"";
        listitem.appendChild(spanName);

        let spanText = document.createElement(""span"");
        spanText.style = ""padding-right: 30px"";
        spanText.textContent = content ");
            WriteLiteral(@"+ ""  "";
        listitem.appendChild(spanText);


        let spanTime = document.createElement(""span"");
        sendAt = moment(sendAt).format('LT');
        spanTime.textContent = sendAt;
        listitem.appendChild(spanTime);

        let ul = document.getElementById(""discussion"");
        ul.appendChild(listitem);

    }

    function leaveRoom() {
        RoomIdContext = prompt(""Room id: "");
        if (RoomIdContext === null) {
            return;
        }
        else {
            let chatHistory = document.getElementById(""discussion"");
            while (chatHistory.firstChild) {
                chatHistory.removeChild(chatHistory.lastChild);
            }
            connection.invoke(""LeaveRoom"", RoomIdContext);
        }
    }

    function changeId(newId) {
        RoomIdContext = newId;
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
