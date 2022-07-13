#pragma checksum "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c068786b3da45002093bfbcf64bf035e97ea25fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/Index.cshtml")]
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
#line 1 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Yummy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Yummy.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c068786b3da45002093bfbcf64bf035e97ea25fb", @"/Areas/AdminPanel/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f551a8a82751d8a729b4b7b8a1ab1b65d65ca8", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h2 class=\"card-title\">Products</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c068786b3da45002093bfbcf64bf035e97ea25fb4358", async() => {
                WriteLiteral("Add Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""table-responsive pt-3"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th>
                                    #
                                </th>
                                <th>
                                    Photo
                                </th>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Price($)
                                </th>
                                <th>
                                    Settings
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 38 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                             foreach (var food in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 45 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                         foreach (var image in @food.ProductImages)
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c068786b3da45002093bfbcf64bf035e97ea25fb7669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1847, "~/assets/img/foods/", 1847, 19, true);
#nullable restore
#line 47 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1866, image.Url, 1866, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 48 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 51 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                   Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 54 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                   Write(food.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        $");
#nullable restore
#line 57 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                    Write(food.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <a class=""btn btn-sm btn-danger"">
                                            <i class=""mdi mdi-delete""></i>
                                        </a>
                                        <a class=""btn btn-sm btn-warning"">
                                            <i class=""mdi mdi-grease-pencil""></i>
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 68 "D:\.NET\Yummy\Yummy\Areas\AdminPanel\Views\Product\Index.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591