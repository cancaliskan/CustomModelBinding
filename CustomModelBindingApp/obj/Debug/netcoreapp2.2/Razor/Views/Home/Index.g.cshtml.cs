#pragma checksum "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c1852aabd8279536b2ff479e9a4c7b6b6accfe"
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
#line 1 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\_ViewImports.cshtml"
using CustomModelBindingApp;

#line default
#line hidden
#line 2 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\_ViewImports.cshtml"
using CustomModelBindingApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c1852aabd8279536b2ff479e9a4c7b6b6accfe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc648e95412e6df94bf1e4f0b839c26c0907aa0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 871, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c1852aabd8279536b2ff479e9a4c7b6b6accfe3933", async() => {
                BeginContext(55, 206, true);
                WriteLiteral("\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>User Name</th>\r\n                <th>User Address</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 12 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
             foreach (var person in Model)
            {

#line default
#line hidden
                BeginContext(320, 109, true);
                WriteLiteral("                <tr>\r\n                    <th>\r\n                        <input type=\"checkbox\" name=\"UserUid\"");
                EndContext();
                BeginWriteAttribute("id", " id=", 429, "", 448, 1);
#line 16 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 433, person.UserIid, 433, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 448, "", 527, 1);
#line 16 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 455, string.Concat(@person.UserIid,"|",@person.Name,"|",@person.Address,"^"), 455, 72, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(527, 62, true);
                WriteLiteral(" />\r\n                    </th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("for", " for=", 589, "", 606, 1);
#line 18 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 594, person.Name, 594, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(606, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(608, 11, false);
#line 18 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
                                           Write(person.Name);

#line default
#line hidden
                EndContext();
                BeginContext(619, 46, true);
                WriteLiteral(" </label></th>\r\n                    <th><label");
                EndContext();
                BeginWriteAttribute("for", " for=", 665, "", 685, 1);
#line 19 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 670, person.Address, 670, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(685, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(687, 14, false);
#line 19 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
                                              Write(person.Address);

#line default
#line hidden
                EndContext();
                BeginContext(701, 39, true);
                WriteLiteral(" </label></th>\r\n                </tr>\r\n");
                EndContext();
#line 21 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(755, 133, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <div>\r\n        <button onclick=\"Next()\" id=\"submit\" type=\"button\">Next</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(895, 2138, true);
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>

<script type=""text/javascript"">
    //    function Next() {
    //        var http = new XMLHttpRequest();
    //        var url = '/Home/Index';
    //        var params = GetModelData();//'orem=ipsum&name=binny';
    //        http.open('POST', url, true);

    ////Send the proper header information along with the request
    //        http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');

    //        http.onreadystatechange = function() {//Call a function when the state changes.
    //            if(http.readyState == 4 && http.status == 200) {
    //                alert(http.responseText);
    //            }
    //        }
    //        http.send(params);
    //    }


    function GetModelData() {
        var list = """";
        $(""input:checkbox[name=UserUid]:checked"").each(function () {
            list += ($(this).val());
            //li");
            WriteLiteral(@"st.push($(this).val());
        });
        console.log(typeof list);
        return list;
    }
    function Next() {
        //form encoded data
        var dataType = 'application/x-www-form-urlencoded; charset=utf-8';
        var data = $('form').serialize();

        //JSON data
        var dataType = 'application/json; charset=utf-8';

        console.log('Submitting form...');
        $.ajax({
            type: 'POST',
            url: '/Home/Index',
            dataType: 'json',
            contentType: dataType,
            data: GetModelData(),
            success: function (result) {
                console.log('Data received: ');
                console.log(result);
            }
        });
    }
    //function Next() {
    //    var model = GetModelData();
    //    var url = ""/Home/Index"";
    //    $.ajax({
    //        url: url,
    //        data: model.toString(),
    //        type: ""POST"",
    //        success: function (data, textStatus, XMLHttpRequest)");
            WriteLiteral(" {\r\n    //            alert(data);\r\n    //        }\r\n    //    });\r\n    //}\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
