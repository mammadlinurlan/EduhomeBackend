#pragma checksum "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117129f5626d5213fc3e8f36e88c837c571b463b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__bCommentPartialView), @"mvc.1.0.view", @"/Views/Shared/_bCommentPartialView.cshtml")]
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
#line 1 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\_ViewImports.cshtml"
using BackendProjectNurlanSenior;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\_ViewImports.cshtml"
using BackendProjectNurlanSenior.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\_ViewImports.cshtml"
using BackendProjectNurlanSenior.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117129f5626d5213fc3e8f36e88c837c571b463b", @"/Views/Shared/_bCommentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e145a45e4b143f3e1eafeaa21a7efdd2d8d36b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__bCommentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text text-danger deleteCmt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
 foreach (Comment item in Model.Blog.Comments)
{
    if (Model.Blog.Comments != null)
    {
        if (item.IsAccepted == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"commentdiv\">\r\n                <h5>");
#nullable restore
#line 12 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
               Write(item.AppUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <span>");
#nullable restore
#line 13 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
                 Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span><strong>");
#nullable restore
#line 14 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
                         Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                <br />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 538, "\"", 554, 1);
#nullable restore
#line 16 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
WriteAttributeValue("", 546, item.Id, 546, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hiddenId\" />\r\n                <p>");
#nullable restore
#line 17 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
              Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
                 if (item.AppUser.UserName == User.Identity.Name)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117129f5626d5213fc3e8f36e88c837c571b463b7321", async() => {
                WriteLiteral("DELETE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
                                                                          WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_bCommentPartialView.cshtml"

        }
    }



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
