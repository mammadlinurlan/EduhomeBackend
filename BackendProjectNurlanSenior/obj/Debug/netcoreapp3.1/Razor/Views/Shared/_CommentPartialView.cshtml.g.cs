#pragma checksum "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e94ca2442ed05f3ab03096ee4fac16e702f9b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartialView), @"mvc.1.0.view", @"/Views/Shared/_CommentPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e94ca2442ed05f3ab03096ee4fac16e702f9b82", @"/Views/Shared/_CommentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e145a45e4b143f3e1eafeaa21a7efdd2d8d36b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
 foreach (Comment item in Model.Course.Comments)
{
    if (item.IsAccepted == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>");
#nullable restore
#line 9 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
       Write(item.AppUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <span>");
#nullable restore
#line 10 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
         Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        <span><strong>");
#nullable restore
#line 12 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
                 Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n        <br />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 413, "\"", 429, 1);
#nullable restore
#line 14 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
WriteAttributeValue("", 421, item.Id, 421, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"hiddenId\" />\r\n");
            WriteLiteral("        <p>");
#nullable restore
#line 16 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
      Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
         if (item.AppUser.UserName == User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e94ca2442ed05f3ab03096ee4fac16e702f9b827174", async() => {
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
#line 19 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
                                                                    WriteLiteral(item.Id);

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
#line 20 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_CommentPartialView.cshtml"
         
    }


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
