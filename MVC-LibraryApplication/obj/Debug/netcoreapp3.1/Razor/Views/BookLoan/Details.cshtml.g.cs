#pragma checksum "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e269d8f8aaba706464ad28852804871afad089e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookLoan_Details), @"mvc.1.0.view", @"/Views/BookLoan/Details.cshtml")]
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
#line 1 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\_ViewImports.cshtml"
using MVC_LibraryApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\_ViewImports.cshtml"
using MVC_LibraryApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e269d8f8aaba706464ad28852804871afad089e5", @"/Views/BookLoan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c38fc03caf976457a41a6e35adeb52c7ebf744", @"/Views/_ViewImports.cshtml")]
    public class Views_BookLoan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryRepository.Models.Loan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Loan</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayName("Name of Renter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Member.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayName("Name of Book"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookArticle.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookArticle.ReleseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookArticle.ReleseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookArticle.NumberOfCopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookArticle.NumberOfCopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 63 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\uppgifter\uppgift10\LibraryApplication\LibraryApplication\MVC-LibraryApplication\Views\BookLoan\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e269d8f8aaba706464ad28852804871afad089e510297", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryRepository.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
