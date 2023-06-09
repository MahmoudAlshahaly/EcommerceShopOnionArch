#pragma checksum "E:\EcommerceShop\EcommerceShop\PresentationLayer(WebUi)\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cedf5bedd688d70f22f13930bce0924a2b13b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cedf5bedd688d70f22f13930bce0924a2b13b4", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb576c32d938a075759f0b06adde7e30e6ec84e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-2 text-end me-3"">
            <ul class=""list-unstyled"">
                <li><a onclick=""GetRoles()"">All Roles</a></li>
                <li><a onclick=""AddRole()"">Add Role</a></li>
            </ul>
        </div>
        <div class=""col-md-8"" id=""roleData1""></div>

    </div>
</div>



<script src=""/lib/jquery/dist/jquery.min.js""></script>
<script>
    $(function () {
        GetRoles();
    });

    function GetRoles() {
        $.ajax({
            url: ""/Admin/AllRoles"",
            success: function (result) {
                $(""#roleData1"").html(result);
            }
        });
    }

    function AddRole() {
        $.ajax({
            url: ""/Admin/NewRole"",
            success: function (result) {
                $(""#roleData1"").html(result);
            }
        });
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
