#pragma checksum "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2da8c0a4850579ed89b18b16c317bebc81a2169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2da8c0a4850579ed89b18b16c317bebc81a2169", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e145a45e4b143f3e1eafeaa21a7efdd2d8d36b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>courses</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Course Start -->
<div class=""course-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 29 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Search\Index.cshtml"
             if (Model.Courses.Count() == 0 && Model.Teachers.Count() == 0  && Model.Events.Count() == 0  && Model.Blogs.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1 style=\"font-size:60px;\">Not found...</h1>\r\n");
#nullable restore
#line 32 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Search\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Search\Index.cshtml"
           Write(await Html.PartialAsync("_allPartialView", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Search\Index.cshtml"
                                                                  

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n}\r\n<!-- Course End -->\r\n<!-- Subscribe Start -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
