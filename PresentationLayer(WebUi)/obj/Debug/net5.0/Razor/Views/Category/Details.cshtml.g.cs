#pragma checksum "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2bb23f21b4c68d960d603fccbb12672f790cf0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Details), @"mvc.1.0.view", @"/Views/Category/Details.cshtml")]
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
#line 1 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\_ViewImports.cshtml"
using PresentationLayer_WebUi_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\_ViewImports.cshtml"
using PresentationLayer_WebUi_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\_ViewImports.cshtml"
using SharedLayer.Domain.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bb23f21b4c68d960d603fccbb12672f790cf0c", @"/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb576c32d938a075759f0b06adde7e30e6ec84e", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedLayer.Domain.ViewModels.CategoryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- shop wrapper -->
<div class=""container grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 md:gap-6 lg:gap-6 pt-4 pb-16 items-start"">
    <!-- sidebar -->
    <div class=""col-span-1 cg-white px-4 lg:px-4 lg:px-4 pb-6 w-36 md:w-52 lg:w-56 shadow rounded overflow-hidden"">
        <div class=""divide-y divide-gray-200 space-y-5"">
            <!-- category filter -->
            <div>
                <h3 class=""text-md lg:text-xl text-gray-800 uppercase py-2 font-medium"">
                    categories
                </h3>
                <div class=""space-y-4 divide divide-y"">
                    <!--category-productsr-->

                        <!-- single category -->
                        <div class=""flex items-center pt-4"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 866, 2);
            WriteAttributeValue("", 839, "/Category/Details/", 839, 18, true);
#nullable restore
#line 17 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Category\Details.cshtml"
WriteAttributeValue("", 857, Model.id, 857, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-gray-600 ml-1 md:ml-3 lg:ml-3 cursor-pointer hover:text-primary\">\r\n                                ");
#nullable restore
#line 18 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Category\Details.cshtml"
                           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </div>
                        <!-- single category-end -->
                    
                </div>
            </div>
            <!-- category filter-end -->
            <!-- brand filter -->
            <div class=""pt-2"">
                <div>
                    <h3 class=""text-md lg:text-xl text-gray-800 uppercase py-2 font-medium"">
                        brands
                    </h3>
                    <div class=""space-y-2"">
                        <!-- single brand -->
                        <div class=""flex items-center"">
                            <input type=""checkbox""
                                   id=""brand-1""
                                   class=""focus:ring-0 rounded-sm cursor-pointer""
                                   style=""accent-color: #fd3d57"" />
                            <label for=""brand-1""
                                   class=""text-gray-600 ml-1 md:ml-3 lg:ml-3 cursor-pointer"">brand1");
            WriteLiteral(@"</label>
                            <div class=""ml-1 md:ml-auto lg:ml-auto text-gray-600 text-sm"">
                                (15)
                            </div>
                        </div>
                        <!-- single brand-end -->
                    </div>
                </div>
            </div>
            <!-- brand filter-end -->
            <!-- price filter -->
            <div class=""pt-2"">
                <h3 class=""text-md lg:text-xl text-gray-800 mb-3 uppercase font-medium"">
                    price
                </h3>
                <div class=""mt-4 flex items-center"">
                    <input id=""priceFilter""
                           type=""text""
                           placeholder=""min""
                           class=""w-full border rounded border-gray-300 focus:ring-0 focus:outline-none px-3 py-1 text-gray-600 text-sm shadow-sm"" />
                    <span class=""mx-3 text-gray-500"">-</span>
                    <input id=""priceFilter""
   ");
            WriteLiteral(@"                        type=""text""
                           placeholder=""max""
                           class=""w-full border rounded border-gray-300 focus:ring-0 focus:outline-none px-3 py-1 text-gray-600 text-sm shadow-sm"" />
                </div>
            </div>
            <!-- price filter-end -->
        </div>
    </div>
    <!-- sidebar-end -->
    <!-- product -->
    <div class=""col-span-1 md:col-span-2 lg:col-span-3"">
        <!-- sorting -->
");
            WriteLiteral(@"        <!-- sorting-end -->
        <!-- product grid -->
        <div class=""flex justify-center"">
            <div class=""grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6 lg:gap-28"">
                <!-- single product -->

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2bb23f21b4c68d960d603fccbb12672f790cf0c8192", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 89 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Category\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products;

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
            WriteLiteral("\r\n                \r\n            </div>\r\n        </div>\r\n        <!-- product grid-end -->\r\n\r\n    </div>\r\n    <!-- product-end -->\r\n</div>\r\n<!-- shop wrapper-end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedLayer.Domain.ViewModels.CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591