#pragma checksum "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088c20ef305edc0ae52f6c0329f5e3cd8f8e4196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"088c20ef305edc0ae52f6c0329f5e3cd8f8e4196", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 35, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(76, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9753da2e68d34ecba98dc9986bec1a8e", async() => {
                BeginContext(82, 197, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>CRUDelicious</title>\n    ");
                EndContext();
                BeginContext(279, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c11ac0fe9724c98910f8fee92a8cde8", async() => {
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
                EndContext();
                BeginContext(326, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(334, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(335, 962, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8d698e5f594ab2acaf11c909acb59b", async() => {
                BeginContext(341, 231, true);
                WriteLiteral("\n    <div class=\"wrapper\">\n        <div>\n            <center>\n                <h1>Welcome to CRUDelicious</h1>\n            </center>\n            <div style=\"display: block\">\n            </div>\n            <br>\n            <center>\n");
                EndContext();
#line 24 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
             foreach (var a in @ViewBag.Dish)
            {

#line default
#line hidden
                BeginContext(632, 20, true);
                WriteLiteral("                <h1>");
                EndContext();
                BeginContext(653, 6, false);
#line 26 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.Name);

#line default
#line hidden
                EndContext();
                BeginContext(659, 26, true);
                WriteLiteral("</h1>\n                <h3>");
                EndContext();
                BeginContext(686, 6, false);
#line 27 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(692, 133, true);
                WriteLiteral("</h3>\n                <h2 style=\"border-bottom: 2px solid black\"></h2>\n                <br>\n                <br>\n                <h3>");
                EndContext();
                BeginContext(826, 13, false);
#line 31 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.Description);

#line default
#line hidden
                EndContext();
                BeginContext(839, 26, true);
                WriteLiteral("</h3>\n                <h3>");
                EndContext();
                BeginContext(866, 11, false);
#line 32 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(877, 26, true);
                WriteLiteral("</h3>\n                <h3>");
                EndContext();
                BeginContext(904, 10, false);
#line 33 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(914, 26, true);
                WriteLiteral("</h3>\n                <h3>");
                EndContext();
                BeginContext(941, 11, false);
#line 34 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.CreatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(952, 26, true);
                WriteLiteral("</h3>\n                <h3>");
                EndContext();
                BeginContext(979, 11, false);
#line 35 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
               Write(a.UpdatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(990, 89, true);
                WriteLiteral("</h3>\n                <br>\n                <a name=\"Delete\" id=\"\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1079, "\"", 1098, 2);
                WriteAttributeValue("", 1086, "delete/", 1086, 7, true);
#line 37 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
WriteAttributeValue("", 1093, a.id, 1093, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1099, 86, true);
                WriteLiteral(" role=\"button\">Delete</a>\n                <a name=\"Edit\" id=\"\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1185, "\"", 1202, 2);
                WriteAttributeValue("", 1192, "edit/", 1192, 5, true);
#line 38 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
WriteAttributeValue("", 1197, a.id, 1197, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1203, 24, true);
                WriteLiteral(" role=\"button\">Edit</a>\n");
                EndContext();
#line 39 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/CRUDelicious/Views/Home/Profile.cshtml"
            }

#line default
#line hidden
                BeginContext(1241, 49, true);
                WriteLiteral("            </center>\n        </div>\n    </div>\n\n");
                EndContext();
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
            EndContext();
            BeginContext(1297, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
