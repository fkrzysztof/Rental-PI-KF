#pragma checksum "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d3357b36eb75868603b382b517434be5da364bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Details), @"mvc.1.0.view", @"/Views/Vehicles/Details.cshtml")]
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
#line 1 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\_ViewImports.cshtml"
using Rental_PI_KF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\_ViewImports.cshtml"
using Rental_PI_KF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d3357b36eb75868603b382b517434be5da364bf", @"/Views/Vehicles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf999fcc25147e15461dda842e480f90e4377401", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rental_Data.Data.Rental.Vehicle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Vehicle</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Brand.BrandID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VehicleModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.VehicleModel.VehicleModelID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearOfProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearOfProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeneralType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeneralType.GeneralTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExactType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExactType.ExactTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngineType.EngineTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Colour.ColourID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GearBox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.GearBox.GearBoxID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WheelDrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.WheelDrive.WheelDriveID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3357b36eb75868603b382b517434be5da364bf17627", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Users\Ja\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Details.cshtml"
                           WriteLiteral(Model.VehicleID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3357b36eb75868603b382b517434be5da364bf19790", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rental_Data.Data.Rental.Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
