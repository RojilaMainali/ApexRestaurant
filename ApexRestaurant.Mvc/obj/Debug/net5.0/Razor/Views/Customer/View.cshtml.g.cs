#pragma checksum "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b142772e829a2e0bed490f9e7fb5f95d7777f99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_View), @"mvc.1.0.view", @"/Views/Customer/View.cshtml")]
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
#line 1 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b142772e829a2e0bed490f9e7fb5f95d7777f99", @"/Views/Customer/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2369768eb70623acf1b455032a9a618096237c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApexRestaurant.Mvc.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
  
 ViewBag.Title = "Create New Customer - MVC";
 Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Create New Customer</h2>\r\n");
#nullable restore
#line 7 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
 using (Html.BeginForm()) 
{
 

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"form-horizontal\">\r\n <hr />\r\n ");
#nullable restore
#line 13 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"form-group\">\r\n ");
#nullable restore
#line 15 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = 
"control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"col-md-10\">\r\n ");
#nullable restore
#line 18 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { 
@class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n ");
#nullable restore
#line 20 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = 
"text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n </div>\r\n </div>\r\n <div class=\"form-group\">\r\n ");
#nullable restore
#line 25 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = 
"control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"col-md-10\">\r\n ");
#nullable restore
#line 28 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { 
@class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n ");
#nullable restore
#line 30 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = 
"text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n </div>\r\n</div>\r\n <div class=\"form-group\">\r\n <div class=\"col-md-offset-2 col-md-10\">\r\n <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n </div>\r\n </div>\r\n </div>\r\n");
#nullable restore
#line 40 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n ");
#nullable restore
#line 42 "D:\ApexRestaurant\ApexRestaurant.MVC\Views\Customer\View.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApexRestaurant.Mvc.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
