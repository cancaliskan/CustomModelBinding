#pragma checksum "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d0542ae910e2e124b544d8f16de42a1db7769f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d0542ae910e2e124b544d8f16de42a1db7769f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc648e95412e6df94bf1e4f0b839c26c0907aa0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 168, true);
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>User Name</th>\r\n            <th>User Address</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
         foreach (var person in Model)
        {

#line default
#line hidden
            BeginContext(243, 97, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    <input type=\"checkbox\" name=\"UserUid\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 340, "", 359, 1);
#line 15 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 344, person.UserIid, 344, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 359, "", 434, 1);
#line 15 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 366, string.Concat(@person.UserIid,"|",@person.Name,"|",@person.Address), 366, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 54, true);
            WriteLiteral(" />\r\n                </th>\r\n                <th><label");
            EndContext();
            BeginWriteAttribute("for", " for=", 488, "", 505, 1);
#line 17 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 493, person.Name, 493, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(507, 11, false);
#line 17 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
                                       Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(518, 42, true);
            WriteLiteral(" </label></th>\r\n                <th><label");
            EndContext();
            BeginWriteAttribute("for", " for=", 560, "", 580, 1);
#line 18 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 565, person.Address, 565, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(580, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(582, 14, false);
#line 18 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
                                          Write(person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(596, 35, true);
            WriteLiteral(" </label></th>\r\n            </tr>\r\n");
            EndContext();
#line 20 "C:\Users\Can\Documents\GitHub\CustomModelBinding\CustomModelBindingApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(642, 898, true);
            WriteLiteral(@"    </tbody>
</table>


<div>
    <button onclick=""Next()"" id=""submit"" type=""button"">Next</button>
</div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>

<script type=""text/javascript"">



    function GetModelData() {
        var list = new String();
        $(""input:checkbox[name=UserUid]:checked"").each(function () {
            list += ($(this).val());
            //list.push($(this).val());
        });
        return list;
    }

    function Next() {
        var model = GetModelData();
        var url = ""/Home/Index"";
        typeof model + ""asd""
        $.ajax({
            url: url,
            data: model.toString(),
            type: ""POST"",
            success: function (data, textStatus, XMLHttpRequest) {
                alert(data);
            }
        });
    }
</script>");
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
