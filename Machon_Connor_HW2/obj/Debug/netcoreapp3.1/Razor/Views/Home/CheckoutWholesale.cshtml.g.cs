#pragma checksum "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\CheckoutWholesale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe1946715a16b3596c85d6b7194860b438aa926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckoutWholesale), @"mvc.1.0.view", @"/Views/Home/CheckoutWholesale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe1946715a16b3596c85d6b7194860b438aa926", @"/Views/Home/CheckoutWholesale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6721c70986ad375634a6fe3a5a4d02cc195e473", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckoutWholesale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Machon_Connor_HW2.Models.WholesaleOrder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\CheckoutWholesale.cshtml"
  
    ViewData["Title"] = "CheckoutWholesale";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Checkout Wholesale</h1>

<h4>Wholesale Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""WholesaleTotals"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CustomerCode"" class=""control-label""></label>
                <input asp-for=""CustomerCode"" class=""form-control"" />
                <span asp-validation-for=""CustomerCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeliveryFee"" class=""control-label""></label>
                <input asp-for=""DeliveryFee"" class=""form-control"" />
                <span asp-validation-for=""DeliveryFee"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NumberOfHardbacks"" class=""control-label""></label>
                <input asp-for=""NumberOfHardbacks"" class=""form-control"" />
       ");
            WriteLiteral(@"         <span asp-validation-for=""NumberOfHardbacks"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NumberOfPaperbacks"" class=""control-label""></label>
                <input asp-for=""NumberOfPaperbacks"" class=""form-control"" />
                <span asp-validation-for=""NumberOfPaperbacks"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""PreferredCustomer"" /> ");
#nullable restore
#line 37 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\CheckoutWholesale.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model.PreferredCustomer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Submit Order"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Machon_Connor_HW2.Models.WholesaleOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591