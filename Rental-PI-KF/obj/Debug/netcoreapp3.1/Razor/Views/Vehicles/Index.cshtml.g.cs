#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b26b415df7ce26eb201b522d58600d7bf3ab63"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b26b415df7ce26eb201b522d58600d7bf3ab63", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf999fcc25147e15461dda842e480f90e4377401", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental_Data.Data.Rental.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b26b415df7ce26eb201b522d58600d7bf3ab634637", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n               Zdjecie\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VehicleModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearOfProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GeneralType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExactType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EngineType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GearBox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WheelDrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 84 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 87 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                   
                    string cos = @item.Pictures.FirstOrDefault().URL;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                 if (cos != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 2645, "\"", 2677, 1);
#nullable restore
#line 92 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 2651, item.Pictures.First().URL, 2651, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded  img-fluid\" />\r\n");
#nullable restore
#line 93 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand.BrandID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VehicleModel.VehicleModelID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearOfProduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EngineCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GeneralType.GeneralTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExactType.ExactTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EngineType.EngineTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Colour.ColourID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GearBox.GearBoxID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WheelDrive.WheelDriveID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b26b415df7ce26eb201b522d58600d7bf3ab6320976", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b26b415df7ce26eb201b522d58600d7bf3ab6323163", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b26b415df7ce26eb201b522d58600d7bf3ab6325356", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 162 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Vehicles\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
