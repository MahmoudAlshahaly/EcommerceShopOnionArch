#pragma checksum "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6137de81bf93cdf0e7a3585f67820e6c1f3c11d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComplaintAndSuggestion_DetailsForAdmin), @"mvc.1.0.view", @"/Views/ComplaintAndSuggestion/DetailsForAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6137de81bf93cdf0e7a3585f67820e6c1f3c11d6", @"/Views/ComplaintAndSuggestion/DetailsForAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb576c32d938a075759f0b06adde7e30e6ec84e", @"/Views/_ViewImports.cshtml")]
    public class Views_ComplaintAndSuggestion_DetailsForAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedLayer.Domain.ViewModels.ComplaintAndSuggestionVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsForAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ComplaintAndSuggestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
  
    ViewData["Title"] = "DetailsForAdmin";

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
    <p class=""text-gray-600 font-medium"">Complaints and Suggestion</p>
</div>
<!-- breadcrums-end -->


<div class=""bg-white p-8 rounded-md w-full"">
    <div class=""container overflow-x-auto"">
        <div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6137de81bf93cdf0e7a3585f67820e6c1f3c11d65368", async() => {
                WriteLiteral(@"
                <div class=""flex justify-between flex-wrap gap-2"">
                    <div class=""flex gap-0 lg:gap-4 items-center"">
                        <div>
                            <label for=""from""
                                   class=""bg-gray-100 p-1 md:p-2 rounded"">From :</label>
                            <input id=""from""
                                   type=""date""
                                   name=""from""
                                   class=""p-1 md:p-2 focus:outline-none bg-gray-100 rounded"" />
                        </div>
                        <div>
                            <label for=""to""
                                   class=""bg-gray-100 p-1 md:p-2 rounded"">To :</label>
                            <input id=""to""
                                   type=""date""
                                   name=""To""
                                   class=""p-1 md:p-2 focus:outline-none bg-gray-100 rounded"" />
                        </div>
                ");
                WriteLiteral(@"    </div>
                    <div class=""flex"">
                        <div id=""addWrapper"">
                            <input type=""submit"" class=""bolck w-full py-2 text-center text-white bg-primary border border-primary rounded hover:bg-transparent hover:text-primary transition uppercase font-roboto font-medium"" value=""Search"" />
                        </div>
                    </div>
                </div>
            ");
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
            WriteLiteral(@"
        </div>
        <div class=""inline-block min-w-full shadow rounded-lg overflow-hidden"">
            <table class=""min-w-full leading-normal"">
                <thead>
                    <tr>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            User
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Subject
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Message
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase trac");
            WriteLiteral(@"king-wider"">
                            Date
                        </th>
                        <th class=""px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider"">
                            Actions
                        </th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 74 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 3707, "\"", 3715, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <td class=""px-5 py-5 border-b border-gray-200 bg-white text-sm"">
                                <div class=""flex items-center"">
                                    <div class=""ml-3"">
                                        <p class=""text-gray-900 whitespace-no-wrap"">
                                            ");
#nullable restore
#line 81 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
                                       Write(item.userid);

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
#line 90 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
                                       Write(item.subject);

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
#line 99 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
                                       Write(item.message);

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
#line 108 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
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
                                <div class=""flex gap-1"">
                                    <span class=""relative inline-block px-6 py-3 bg-red-200 hover:bg-red-400 rounded-full font-semibold text-red-900 leading-tight"">
                                        <span aria-hidden
                                              class=""absolute inset-0 opacity-50""></span>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 6325, "\"", 6371, 2);
            WriteAttributeValue("", 6332, "/ComplaintAndSuggestion/Delete/", 6332, 31, true);
#nullable restore
#line 118 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
WriteAttributeValue("", 6363, item.id, 6363, 8, false);

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
#line 125 "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\ComplaintAndSuggestion\DetailsForAdmin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedLayer.Domain.ViewModels.ComplaintAndSuggestionVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591