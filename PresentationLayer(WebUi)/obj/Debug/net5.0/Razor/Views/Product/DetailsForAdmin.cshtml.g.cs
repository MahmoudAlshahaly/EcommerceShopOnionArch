#pragma checksum "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265f7c719ed3b234671e75466135680690465cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DetailsForAdmin), @"mvc.1.0.view", @"/Views/Product/DetailsForAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265f7c719ed3b234671e75466135680690465cac", @"/Views/Product/DetailsForAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb576c32d938a075759f0b06adde7e30e6ec84e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailsForAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedLayer.Domain.ViewModels.ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mainImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("min-w-[80px] max-h-20 sm:min-w-[96px] sm:max-h-20 lg:min-w-[100px] lg:h-24 cursor-pointer border"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
  
    ViewData["Title"] = "DetailsForAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- product view -->\r\n<div class=\"container flex gap-6 flex-wrap\">\r\n\r\n    <!--  product image -->\r\n    <div class=\"w-[320px] sm:w-[420px] md:lg:w-[510px] lg:w-[510px]\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "265f7c719ed3b234671e75466135680690465cac5692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 321, "~/img/", 321, 6, true);
#nullable restore
#line 13 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
AddHtmlAttributeValue("", 327, Model.imageurl, 327, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div id=\"imgWrapper\" class=\"flex justify-center gap-0 sm:gap-2 lg:gap-8 mt-4 w-full\">\r\n");
#nullable restore
#line 17 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
              
                int index = 1;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
             foreach (var item in Model.ProductImage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button");
            BeginWriteAttribute("class", " class=\"", 656, "\"", 684, 2);
            WriteAttributeValue("", 664, "smallImageBtn-", 664, 14, true);
#nullable restore
#line 22 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
WriteAttributeValue("", 678, index, 678, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "265f7c719ed3b234671e75466135680690465cac8533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 718, "~/img/", 718, 6, true);
#nullable restore
#line 23 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
AddHtmlAttributeValue("", 724, item.imageurl, 724, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 27 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"

                index++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- product image-end -->\r\n    <!-- product content -->\r\n    <div w-[400px]>\r\n        <h2 class=\"text-3xl font-medium uppercase mb-2\">\r\n            ");
#nullable restore
#line 36 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <div class=\"flex items-center mb-4\">\r\n            <div class=\"text-xs text-gray-500 ml-3\">(");
#nullable restore
#line 39 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
                                                Write(Model.Reviews.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" reviews)</div>\r\n        </div>\r\n        <div class=\"space-y-2\">\r\n            <p class=\"text-gray-800 font-semibold space-x-2\">\r\n                <span>Availability:</span>\r\n                <span class=\"text-green-600\">( ");
#nullable restore
#line 44 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
                                          Write(Model.quantityavailable);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ) In Stock</span>\r\n            </p>\r\n            <p class=\"space-x-2\">\r\n                <span class=\"text-gray-800 font-semibold\">Brand:</span>\r\n                <span class=\"text-gray-600\">");
#nullable restore
#line 48 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
                                       Write(Model?.Brand.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"space-x-2\">\r\n                <span class=\"text-gray-800 font-semibold\">Category:</span>\r\n                <span class=\"text-gray-600\">");
#nullable restore
#line 52 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
                                       Write(Model?.Category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n        </div>\r\n        <!-- price -->\r\n        <div class=\"flex items-baseline mb-1 space-x-2 font-roboto mt-4\">\r\n            <p class=\"text-2xl text-primary font-semibold\">$");
#nullable restore
#line 57 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
                                                       Write(Model.saleprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("        </div>\r\n        <!-- price-end -->\r\n        <!-- description -->\r\n        <p class=\"mt-4 text-gray-600 w-80 sm:w-96\">\r\n            ");
#nullable restore
#line 63 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Product\DetailsForAdmin.cshtml"
       Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <!-- description-end -->
        <!-- quantity -->
        <div class=""mt-4"">
        </div>
        <!-- quantity-end -->
        <!-- add to cart btn -->
        <div class=""flex gap-3 pb-5 mt-6"">
            <a href=""/Product/index""
               class=""bg-primary border border-primary text-white px-8 py-2 font-medium rounded uppercase flex items-center gap-2 hover:bg-opacity-0 hover:text-primary transition"">
                All Product
            </a>
        </div>
        <!-- add to cart btn-end -->
    </div>
    <!-- product content-end -->
</div>
<!-- product view-end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedLayer.Domain.ViewModels.ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
