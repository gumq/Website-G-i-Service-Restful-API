#pragma checksum "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628b782534fc0c5af2d4148ae586c7078769780b"
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
#line 1 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\_ViewImports.cshtml"
using TranLeQuyen_5951071088;

#line default
#line hidden
#line 2 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\_ViewImports.cshtml"
using TranLeQuyen_5951071088.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628b782534fc0c5af2d4148ae586c7078769780b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96dbff4852bd2669367ebe4794ed489ecacca12", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TranLeQuyen_5951071088.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(107, 306, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>Sr No.</th>
            <th>Employee Name</th>
            <th>City.</th>
            <th>State</th>
            <th>Country</th>
            <th>Department</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
       foreach (var item in Model) 
      {

#line default
#line hidden
            BeginContext(459, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(498, 10, false);
#line 22 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.Sr_no);

#line default
#line hidden
            EndContext();
            BeginContext(508, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(536, 13, false);
#line 23 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.Emp_name);

#line default
#line hidden
            EndContext();
            BeginContext(549, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(577, 9, false);
#line 24 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(586, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(614, 10, false);
#line 25 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.State);

#line default
#line hidden
            EndContext();
            BeginContext(624, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(652, 12, false);
#line 26 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.Country);

#line default
#line hidden
            EndContext();
            BeginContext(664, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(694, 15, false);
#line 28 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
               Write(item.Department);

#line default
#line hidden
            EndContext();
            BeginContext(709, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(758, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9278585694c64234aa5e63fe382d8e65", async() => {
                BeginContext(806, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
                                           WriteLiteral(item.Sr_no);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(814, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(836, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7cc2e644094fe1bd008906e2214bab", async() => {
                BeginContext(886, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
                                             WriteLiteral(item.Sr_no);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(896, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "E:\Cntt Năm 3\C#\src\TranLeQuyen_5951071088\TranLeQuyen_5951071088\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(953, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TranLeQuyen_5951071088.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591