#pragma checksum "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d41fa2c63edde50f8e0bcdf5797f6854e180c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Search), @"mvc.1.0.view", @"/Views/Course/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d41fa2c63edde50f8e0bcdf5797f6854e180c7", @"/Views/Course/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e145a45e4b143f3e1eafeaa21a7efdd2d8d36b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
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
                <div class=""course-title"">
                    <h3>search courses</h3>
                </div>
                <div class=""course-form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d41fa2c63edde50f8e0bcdf5797f6854e180c75584", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" name=\"Name\" id=\"Name\" />\r\n                        <button type=\"submit\">search</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1 style=\"font-size:60px;\">Not found...</h1>\r\n");
#nullable restore
#line 42 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml"
           Write(await Html.PartialAsync("_CoursePartialView", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\MACBOOK\source\repos\BackendProjectNurlanSenior\BackendProjectNurlanSenior\Views\Course\Search.cshtml"
                                                                     

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script>
          $(document).ready(function () {

              function Contains(text_one, text_two) {
                  if (text_one.indexOf(text_two) != -1) {
                      return true;
                  }
              }

              $(""#Name"").keyup(function () {
                  var searchText = $(""#Name"").val().toLowerCase();
                  $("".courseForSearch"").each(function () {
                      if (!Contains($(this).text().toLowerCase(), searchText)) {

                          $(this).hide()

                      }
                      else {
                          $(this).show()
                      }
                  })
              })



          })
    </script>


");
            }
            );
            WriteLiteral("<!-- Course End -->\r\n<!-- Subscribe Start -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
