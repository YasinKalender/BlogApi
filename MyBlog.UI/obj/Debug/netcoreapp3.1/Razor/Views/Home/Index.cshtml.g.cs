#pragma checksum "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e41d808ad973a9e1dae62860cad56be4ba643b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.UI.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.DTO.DTO.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.DTO.DTO.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.DTO.DTO.CommentsDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\_ViewImports.cshtml"
using MyBlog.Entities.ORM.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e41d808ad973a9e1dae62860cad56be4ba643b9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbc63a03ca1dcd873777d3d1b10f3a0d27b7411", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_HomeLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n    <!-- Blog Entries Column -->\r\n    <div class=\"col-md-8\">\r\n\r\n        <h1 class=\"my-4\">\r\n            Page Heading\r\n            <small>Secondary Text</small>\r\n        </h1>\r\n");
#nullable restore
#line 17 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
         if (ViewBag.active != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
       Write(Component.InvokeAsync("GetCategoryName", new { categoryid = @ViewBag.active}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                                                                                          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e41d808ad973a9e1dae62860cad56be4ba643b96770", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
         if (!string.IsNullOrWhiteSpace(@ViewBag.search))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
       Write(Component.InvokeAsync("Search", new { s = ViewBag.search }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                                                                        
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("k\r\n        <input type=\"text\" name=\"s\" class=\"form-control\" />\r\n        <button type=\"submit\" class=\"btn btn-primary\">Ara</button>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n      \r\n\r\n        <!-- Blog Post -->\r\n");
#nullable restore
#line 36 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {




#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-4\">\r\n                <GetBlogImage");
            BeginWriteAttribute("itemid", " itemid=\"", 981, "\"", 998, 1);
#nullable restore
#line 42 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 990, item.ID, 990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></GetBlogImage>\r\n                <div class=\"card-body\">\r\n                    <h2 class=\"card-title\">");
#nullable restore
#line 44 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 45 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                                    Write(item.ContentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e41d808ad973a9e1dae62860cad56be4ba643b910830", async() => {
                WriteLiteral("Detay &rarr;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                                                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n                    Posted ");
#nullable restore
#line 49 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
                      Write(item.AddDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\ysnbj\Desktop\MyBlog\MyBlog.UI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        <!-- Pagination -->
        <ul class=""pagination justify-content-center mb-4"">
            <li class=""page-item"">
                <a class=""page-link"" href=""#"">&larr; Older</a>
            </li>
            <li class=""page-item disabled"">
                <a class=""page-link"" href=""#"">Newer &rarr;</a>
            </li>
        </ul>

    </div>

    <!-- Sidebar Widgets Column -->


</div>
<!-- /.row -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
