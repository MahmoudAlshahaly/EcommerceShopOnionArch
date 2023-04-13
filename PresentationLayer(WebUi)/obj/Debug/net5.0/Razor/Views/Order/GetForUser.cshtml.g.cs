#pragma checksum "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ea4f436fa9fe09dcf44c5835ab2f1b5b31217f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetForUser), @"mvc.1.0.view", @"/Views/Order/GetForUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ea4f436fa9fe09dcf44c5835ab2f1b5b31217f", @"/Views/Order/GetForUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb576c32d938a075759f0b06adde7e30e6ec84e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetForUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedLayer.Domain.ViewModels.OrderVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
  
    ViewData["Title"] = "GetForUser";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrums -->
<div class=""container py-4 flex items-center gap-3"">
    <a href=""/Home/Index"" class=""text-primary text-base"">
        <i class=""fas fa-home""></i>
    </a>
    <span class=""text-sm text-gray-400"">
        <i class=""fas fa-chevron-right""></i>
    </span>
    <p class=""text-gray-600 font-medium"">Orders</p>
</div>
<!-- breadcrums-end -->


<div class=""bg-white p-8 rounded-md w-full"">
    <div class=""container overflow-x-auto"">
        <div class=""inline-block min-w-full shadow rounded-lg overflow-hidden"">
            <table class=""min-w-full leading-normal"">
                <thead>
                    <tr>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Order ID
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase track");
            WriteLiteral(@"ing-wider"">
                            User
                        </th>

                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Total Before Tax
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Total Tax
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Total After Tax
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Date
                        </th>

                      ");
            WriteLiteral(@"  <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Product Name
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Quantity
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Sale Price
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Total Product Price
                        </th>

                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold tex");
            WriteLiteral("t-gray-600 uppercase tracking-wider\">\r\n                            Actions\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
#nullable restore
#line 66 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                     foreach (var item in Model)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                         foreach (var product in item.OrderDetails)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 3568, "\"", 3576, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 77 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 86 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 95 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 104 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.taxvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 113 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.totalaftertax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 122 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(item.date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 131 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(product.Product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 140 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(product.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 149 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(product.saleprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex items-center"">
                                        <div class=""ml-3"">
                                            <p class=""text-gray-900 whitespace-no-wrap"">
                                                ");
#nullable restore
#line 158 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                                           Write(product.totalsale);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>

                                </td>
                                <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                    <div class=""flex gap-1"">
                                        <span class=""relative inline-block px-6 py-3 bg-red-200 hover:bg-red-400 rounded-full font-semibold text-red-900 leading-tight"">
                                            <span aria-hidden
                                                  class=""absolute inset-0 opacity-50""></span>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 9746, "\"", 9775, 2);
            WriteAttributeValue("", 9753, "/Order/Delete/", 9753, 14, true);
#nullable restore
#line 169 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
WriteAttributeValue("", 9767, item.id, 9767, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""relative"">
                                                <i class=""fa fa-trash""></i>
                                            </a>
                                        </span>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 176 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Order\GetForUser.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedLayer.Domain.ViewModels.OrderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
