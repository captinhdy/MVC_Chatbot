#pragma checksum "D:\source\repos\dotnetcoreMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8199649e893dc04701bba543833983d7f1b57cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\source\repos\dotnetcoreMVC\Views\_ViewImports.cshtml"
using dotnetcoreMVC;

#line default
#line hidden
#line 2 "D:\source\repos\dotnetcoreMVC\Views\_ViewImports.cshtml"
using dotnetcoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8199649e893dc04701bba543833983d7f1b57cbf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5fabba6bab60e148d2bb66435c2f659c4bdcef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\source\repos\dotnetcoreMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 3544, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        Welcome to the FAQ bot test app. This was built using the FAQ section of your public page found here.
        <br/>
        <a href=""https://www.crest-management.com/pages/faq.aspx"">Crest FAQ</a>
        <br/>
        Try asking the bot about payments
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div id=""bot"">
            <div id=""bot-text"">

            </div>
            <div id=""bot-question"">
                <div class=""row"">
                    <div class=""col-md-9"">
                        <label for=""QuestionTxt"">Ask the bot a question</label>
                        <input type=""text"" style=""width:90%"" id=""QuestionTxt"" class=""form-control""/>
                    </div>
                    <div class=""col-md-3"">
                        <label for=""submitbtn"">&nbsp;</label>
                        <br/>
                        <input type=""button"" value=""submit"" onclick=""SubmitQuestion()"" class=""btn ");
            WriteLiteral(@"btn-primary"" id=""submitbtn"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <label>Questions to try</label>
            <ul>
                <li>Can i make a payment online?</li>
                <li>Can i pay by credit card?</li>
                <li>Can i pay by check?</li>
                <li>how can i obtain a copy of my statement?</li>
            </ul>
        </div>
    </div>
</div>



<script>
    function SubmitQuestion(){
        var question = document.getElementById(""QuestionTxt"").value;
        var chatArea = document.getElementById(""bot-text"");
        questionDiv = document.createElement(""div"");
        questionDiv.classList.add('question-box');
        questionDiv.innerHTML = question;
        chatArea.append(questionDiv);
        chatArea.scrollTop = chatArea.scrollHeight;

        //var request =new XMLHttpRequest();

        var data = {
      ");
            WriteLiteral(@"      ""Question"" : question
        }
         $.ajax({
                type: ""GET"",
                url: ""/Bot/SubmitQuestion?Question="" + question,
                contentType: ""application/json"",
                dataType: ""json"",
                success:  function(r){
                console.log(r)
                var response = r;
                var div = document.createElement(""div"");
                var br = document.createElement(""br"")
                div.classList.add('answer-box');
                div.innerHTML = response.answer;
                div.innerHTML += ""<br/>""
                div.innerHTML += ""confidence level: "" + response.confidence;
                chatArea.append(div);
                chatArea.scrollTop = chatArea.scrollHeight;
            },
            error: function(ex){
                alert(ex.responseText)
            }
        });
       // request.onreadystatechange = function() {
         //   if (this.readyState == 4 && this.status == 200) {
        ");
            WriteLiteral(@"        // Typical action to be performed when the document is ready:
                
                
      //      }
//
  //          if(this.status == 500){
    //            alert(request.responseText)
      //      }
        //};
        
        //request.open(""POST"", ""/Bot/SubmitQuestion"");
        //request.setRequestHeader(""Content-Type"", ""application/json; charset=utf-8"");
        //request.send(JSON.stringify(data));
    }
</script>
        ");
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
