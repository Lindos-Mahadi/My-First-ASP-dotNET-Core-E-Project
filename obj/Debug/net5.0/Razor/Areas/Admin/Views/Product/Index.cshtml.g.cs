#pragma checksum "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856509236a2c1a1cd265a95a429a00962503dfa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#line 1 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shopping_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shopping_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"856509236a2c1a1cd265a95a429a00962503dfa7", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f89f9087e1adbe52cad3e4767dfda2624e551721", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Shopping_Store.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h1 class=\"text-info\">Product List</h1>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "856509236a2c1a1cd265a95a429a00962503dfa75413", async() => {
                WriteLiteral(" <i class=\"fas fa-plus\"></i> &nbsp; Add New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "856509236a2c1a1cd265a95a429a00962503dfa76722", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""lowPrice"" placeholder=""Enter Min Value"" />
        </div>
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""largePrice"" placeholder=""Enter Max Value"" />
        </div>
        <div class=""col-3"">
            <input type=""submit"" class=""form-control btn btn-success"" value=""Search"" />
        </div>
        <div class=""col-3""></div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n            <tr class=\"table-striped bg-info\">\r\n");
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 40 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.ProductColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.IsAbailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.ProductTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.SpecialTagId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 63 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 67 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.IsAbailable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.ProductType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.SpecialTag.SpecialTagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "856509236a2c1a1cd265a95a429a00962503dfa713370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 74 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 78 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        });
        $(function(){
            var save = '");
#nullable restore
#line 94 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (save != \'\') {\r\n                alertify.success(save);\r\n            }\r\n            var edit = \'");
#nullable restore
#line 98 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (edit != \'\') {\r\n                alertify.success(edit);\r\n            }\r\n            var deleteData = \'");
#nullable restore
#line 102 "F:\ASPdotNET\Online-Shopping-Store\My-Core-Project\Online-Shopping-Store\Areas\Admin\Views\Product\Index.cshtml"
                         Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (deleteData != \'\') {\r\n                alertify.success(deleteData);\r\n            }\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online_Shopping_Store.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
