#pragma checksum "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f657a892e876beb7835731aeb6683da9692e5425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__eCommentPartialView), @"mvc.1.0.view", @"/Views/Shared/_eCommentPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f657a892e876beb7835731aeb6683da9692e5425", @"/Views/Shared/_eCommentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e145a45e4b143f3e1eafeaa21a7efdd2d8d36b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__eCommentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
 foreach (Comment item in Model.Event.Comments)
{
    if (Model.Event.Comments != null)
    {
        if (item.IsAccepted == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"commentdiv\">\r\n                <h5>");
#nullable restore
#line 12 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
               Write(item.AppUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <span>");
#nullable restore
#line 13 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
                 Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span><strong>");
#nullable restore
#line 14 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
                         Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                <br />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 538, "\"", 554, 1);
#nullable restore
#line 16 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
WriteAttributeValue("", 546, item.Id, 546, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"hiddenId\" class=\"hiddenClass\" />\r\n                <p>");
#nullable restore
#line 17 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
              Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
                 if (item.AppUser.UserName == User.Identity.Name)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"text-decoration:none\" class=\"text text-danger deleteCmt\">DELETE</a>\r\n");
#nullable restore
#line 21 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Shared\_eCommentPartialView.cshtml"

        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
