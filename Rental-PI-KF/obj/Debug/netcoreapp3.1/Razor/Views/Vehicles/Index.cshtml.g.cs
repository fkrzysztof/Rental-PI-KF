#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772f4ce4b274f719c82a2bd3579310876ef0348a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
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
#line 1 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\_ViewImports.cshtml"
using Rental_PI_KF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\_ViewImports.cshtml"
using Rental_PI_KF.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
using Rental_Data.Data.Rental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
using Rental.Data.Data.Rental;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772f4ce4b274f719c82a2bd3579310876ef0348a", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf999fcc25147e15461dda842e480f90e4377401", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental_Data.Data.Rental.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateThis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RentalVehicles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vehicles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h4>Samochody osobowe</h4>\r\n");
#nullable restore
#line 10 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
  
    List<Equipment> TempList = new List<Equipment>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"btn-group-toggle\" data-toggle=\"buttons\">\r\n    <label class=\"btn btn-secondary active\">\r\n        <input type=\"checkbox\" checked autocomplete=\"off\"> Checked\r\n    </label>\r\n</div>\r\n\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 22 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-5 m-4\">\r\n            <div class=\"card shadow-sm\">\r\n                <div class=\"card-header bg-gradient-white \">\r\n                    <h5 class=\"card-title float-left align-items-center m-0\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Brand.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.VehicleModel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h5>

                    <div class=""dropdown no-arrow float-right"">
                        <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                            <div class=""dropdown-header"">Dostępne opcje:</div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772f4ce4b274f719c82a2bd3579310876ef0348a8045", async() => {
                WriteLiteral("Wypożycz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                               WriteLiteral(item.VehicleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 39 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                              
                                string blockade = "Zablokuj";
                                if (item.Blockade == true)
                                {
                                    blockade = "Odblokuj";
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772f4ce4b274f719c82a2bd3579310876ef0348a11163", async() => {
#nullable restore
#line 46 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                                                                                 Write(blockade);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                               WriteLiteral(item.VehicleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772f4ce4b274f719c82a2bd3579310876ef0348a13970", async() => {
                WriteLiteral("Edytuj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                         WriteLiteral(item.VehicleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                          
                            if (item.Blockade == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"text-danger fas fa-lock float-left ml-3 mr-1\"></i>\r\n");
#nullable restore
#line 53 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n                <div class=\"card-body \">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-7\">\r\n");
#nullable restore
#line 64 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                               
                                RentalVehicle rentalVehicleItem;
                                if ((rentalVehicleItem = item.RentalVehicles.FirstOrDefault(f =>
                                f.From.CompareTo(DateTime.Now.Date) <= 0 && f.To.CompareTo(DateTime.Now.Date) >= 0
                                )) != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"position-absolute bg-gradient-info text-white p-3 rotate-n-15 d-inline-block my-1 rounded shadow-sm\">Wypożyczony</div>\r\n");
#nullable restore
#line 71 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }
                             

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3474, "\"", 3529, 1);
#nullable restore
#line 75 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 3480, item.Pictures.First(f => f.IsActive == true).URL, 3480, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded\" />\r\n                        </div>\r\n                        <div class=\"col-md-4 m-2\">\r\n");
            WriteLiteral("                            <small>\r\n                                Rocznik: ");
#nullable restore
#line 82 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.YearOfCarProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Pojemność: ");
#nullable restore
#line 83 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3<br />\r\n                                Silnik: ");
#nullable restore
#line 84 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EngineType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Przebieg: ");
#nullable restore
#line 85 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral(" km<br />\r\n                                Moc (KM): ");
#nullable restore
#line 86 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM<br />\r\n                                Skrzynia: ");
#nullable restore
#line 87 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.GearBox.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Klimatyzacja: ");
#nullable restore
#line 88 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.AirConditioning.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            </small>\r\n                        </div>\r\n                        <div class=\"col-md-11 m-2\">\r\n");
#nullable restore
#line 105 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                              
                                DateTime.Now.Date.ToString();

                                if (item.RentalVehicles.FirstOrDefault(f => f.From.CompareTo(DateTime.Now.Date) > 0) != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>start jest pozniej</p>\r\n");
#nullable restore
#line 111 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>start jest wczesniej</p>\r\n");
#nullable restore
#line 115 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }
                                if (item.RentalVehicles.FirstOrDefault(f => f.To.CompareTo(DateTime.Now.Date) < 0) != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>koniec jest wczersniej</p>\r\n");
#nullable restore
#line 119 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>koniec jest pozniej</p>\r\n");
#nullable restore
#line 123 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }


                                //RentalVehicle rentalVehicleItem;
                                //TimeSpan rezult;
                                DateTime nextRentalDate;



                                //szukam zajetego
                                if ((rentalVehicleItem = item.RentalVehicles.FirstOrDefault(f =>
                                f.From.CompareTo(DateTime.Now.Date) <= 0 && f.To.CompareTo(DateTime.Now.Date) >= 0
                                )) != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>Aktualnie Wypożyczony</h6>\r\n                                    <p>Koniec wypożyczenia za ");
#nullable restore
#line 138 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                          Write((rentalVehicleItem.To.Date - DateTime.Now.Date).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("dni / ");
#nullable restore
#line 138 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                                                                      Write(rentalVehicleItem.To.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 139 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>Aktualnie Dostepny</h6>\r\n");
#nullable restore
#line 143 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                    if ((nextRentalDate = item.RentalVehicles.OrderBy(o => o.From).Select(s => s.From).FirstOrDefault(f => f.CompareTo(DateTime.Now.Date) > 0)).CompareTo(DateTime.Now.Date) > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>Następna rezerwacja za: ");
#nullable restore
#line 145 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                               Write((nextRentalDate.Date - DateTime.Now.Date).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("dni  / ");
#nullable restore
#line 145 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                                                                      Write(nextRentalDate.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 146 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                                               
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>Brak rezerwacji</p>\r\n");
#nullable restore
#line 151 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                    }

                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"card-title\">Opis</h6>\r\n                            <p><small>");
#nullable restore
#line 156 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small><p>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n\r\n                        <div class=\"col-md-11 m-2\">\r\n");
            WriteLiteral(@"                            <button class=""btn-sm btn-outline-dark"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""true"" aria-controls=""collapseExample"">
                                Wyposażenie
                            </button>

                            <hr />
");
#nullable restore
#line 176 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                              
                                Equipment toAdd;
                                foreach (var name in @ViewBag.EQNameList)
                                {
                                    if ((toAdd = item.Equipment.FirstOrDefault(f => f.EquipmentNameID == name.EquipmentNameID)) == null)
                                    {
                                        TempList.Add(new Equipment()
                                        {
                                            Name = name.Name,
                                            Check = false
                                        }
                                        );
                                    }
                                    else
                                    {
                                        toAdd.Name = name.Name;
                                        TempList.Add(toAdd);
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"collapse\" id=\"collapseExample\">\r\n                                <dl class=\"row\">\r\n");
#nullable restore
#line 199 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     foreach (var eqtemp in TempList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <dt class=\"col-sm-5\">\r\n                                            <small>");
#nullable restore
#line 202 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                              Write(Html.DisplayFor(eqtempModel => eqtemp.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-1\">\r\n                                            ");
#nullable restore
#line 205 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                       Write(Html.DisplayFor(eqtempModel => eqtemp.Check));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n");
#nullable restore
#line 207 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </dl>\r\n                            </div>\r\n");
#nullable restore
#line 210 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                              
                                TempList.Clear();
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 218 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rental_Data.Data.Rental.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
