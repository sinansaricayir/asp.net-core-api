#pragma checksum "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0d79b91a69c2a4153610db91ed7fab28094920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout__adminLayout), @"mvc.1.0.view", @"/Views/AdminLayout/_adminLayout.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0d79b91a69c2a4153610db91ed7fab28094920", @"/Views/AdminLayout/_adminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6494dc9393571371fa83d6140b50adbfa061ea87", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminLayout__adminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
#nullable restore
#line 4 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0d79b91a69c2a4153610db91ed7fab280949203527", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 8 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/PreLoaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <div id=\"main-wrapper\">\n\n        ");
#nullable restore
#line 12 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLAyout/NavHeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        ");
#nullable restore
#line 14 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLAyout/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        ");
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLAyout/SidebarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <div class=""content-body"">

            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                ");
#nullable restore
#line 25 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n\n        ");
#nullable restore
#line 34 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLAyout/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    </div>\n\n    ");
#nullable restore
#line 38 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
