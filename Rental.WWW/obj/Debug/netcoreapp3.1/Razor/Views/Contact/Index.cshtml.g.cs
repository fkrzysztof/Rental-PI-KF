#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a024ac91ff9aa1a831321f32db8528f3bba65263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\_ViewImports.cshtml"
using Rental.WWW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\_ViewImports.cshtml"
using Rental.WWW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024ac91ff9aa1a831321f32db8528f3bba65263", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a59a14ceed467fcf91029402cc9fca83bd2182", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental_Data.Data.Rental.RentalAgency>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.PageTitle = "Oddziały";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-12 mt-2 mb-2\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""row"">
                                <div class=""col-12 text-sm-left"">
                                    <p class=""card-text""><i class=""fas fa-user-tie mr-2""></i>");
#nullable restore
#line 20 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.ContactPerson));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"col-12 text-sm-left\"><i class=\"fas fa-phone mr-2\"></i>");
#nullable restore
#line 22 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Phone1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                <div class=\"col-12 text-sm-left\"><i class=\"fas fa-phone mr-2\"></i>");
#nullable restore
#line 23 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Phone2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                <div class=\"col-12 text-sm-left\"><i class=\"fas fa-at mr-2\"></i>");
#nullable restore
#line 24 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Email1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                <div class=\"col-12 text-sm-left\"><i class=\"fas fa-at mr-2\"></i>");
#nullable restore
#line 25 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Email2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 align-self-end"">
                            <div class=""row"">
                                <div class=""col-12 text-sm-right""><i class=""fas fa-map-marker-alt"" style=""font-size: 2rem;""></i></div>
                                <div class=""col-12 text-sm-right"">Adres:</div>
                                <div class=""col-12 text-sm-right"">");
#nullable restore
#line 32 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                             Write(item.RentalAgencyAddress.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                              Write(item.RentalAgencyAddress.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"col-12 text-sm-right\">");
#nullable restore
#line 33 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                             Write(item.RentalAgencyAddress.ZIPCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                                                               Write(item.RentalAgencyAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"col-12 text-sm-right\">");
#nullable restore
#line 34 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
                                                             Write(item.RentalAgencyAddress.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Contact\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rental_Data.Data.Rental.RentalAgency>> Html { get; private set; }
    }
}
#pragma warning restore 1591