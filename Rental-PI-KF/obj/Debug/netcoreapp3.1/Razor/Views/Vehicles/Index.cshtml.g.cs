#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260b21de46c5389bcdf64c3fb97383645a686345"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260b21de46c5389bcdf64c3fb97383645a686345", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf999fcc25147e15461dda842e480f90e4377401", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental_Data.Data.Rental.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Upload/Images/imgull.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
            WriteLiteral("\r\n<h1>SAmochody osobowe</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260b21de46c5389bcdf64c3fb97383645a6863454626", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
     for (int i = 0; i < 20; i++)
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-5 m-4\">\r\n                <div class=\"card shadow-sm\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-7\">\r\n\r\n\r\n");
#nullable restore
#line 23 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                              
                                string cos = @item.Pictures.FirstOrDefault().URL;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                             if (cos != "")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 722, "\"", 754, 1);
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 728, item.Pictures.First().URL, 728, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded\" />\r\n");
#nullable restore
#line 29 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "260b21de46c5389bcdf64c3fb97383645a6863457878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-4 m-2\">\r\n                            <h5 class=\"card-title\">\r\n                                ");
#nullable restore
#line 37 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Brand.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.VehicleModel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                            <small>\r\n                                Rocznik: ");
#nullable restore
#line 40 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.YearOfCarProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Pojemność: ");
#nullable restore
#line 41 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3<br />\r\n                                Silnik: ");
#nullable restore
#line 42 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EngineType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Przebieg: ");
#nullable restore
#line 43 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral(" km<br />\r\n                                Moc (KM): ");
#nullable restore
#line 44 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM<br />\r\n                                Skrzynia: ");
#nullable restore
#line 45 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.GearBox.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Klimatyzacja: ");
#nullable restore
#line 46 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Equipment.AirConditioning.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
                            </small>
                        </div>
                        <div class=""col-md-11 m-2"">
                            <h5 class=""card-title"">Special title treatment</h5>
                            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
                            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                        </div>
                        
                        <div class=""col-md-11 m-2"">
");
            WriteLiteral(@"                            <button class=""btn-sm btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                Wyposażenie
                            </button>
                            <hr />
                            <div class=""collapse"" id=""collapseExample"">
                                <dl class=""row"">

                                    <dt class=""col-sm-5"">
                                        <small>");
#nullable restore
#line 65 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.ABS));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 69 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.ABS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 72 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.AUX));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 75 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.AUX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 78 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.ISOFIX));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 81 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.ISOFIX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 84 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.CD));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 87 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.CD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 90 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.SD));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 93 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.SD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 96 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.USB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 99 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.USB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 102 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.CruiseControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 105 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.CruiseControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 108 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.Navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 111 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.Navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-5\">\r\n                                        <small>");
#nullable restore
#line 114 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                          Write(Html.DisplayNameFor(modelItem => item.Equipment.PowerSteering));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-1\">\r\n                                        ");
#nullable restore
#line 117 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment.PowerSteering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n                            </div>\r\n                        </div>\r\n                        </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 125 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
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
