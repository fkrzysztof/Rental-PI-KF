#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b8f7ce49f96d15744c9708ad0c2f52a5bdff37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b8f7ce49f96d15744c9708ad0c2f52a5bdff37", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf999fcc25147e15461dda842e480f90e4377401", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental.Data.Data.Rental.Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success float-right btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-haspopup", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-expanded", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px; height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img  mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Upload/Default/DefaultUser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
  
    //ViewData["Title"] = "Wiadomości nieodczytane";
    ViewData["Title"] = ViewBag.Tite;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-2\">\r\n    <div class=\"col-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b8f7ce49f96d15744c9708ad0c2f52a5bdff378146", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-circle\"></i>\r\n            Dodaj\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div id=""accordion"">
    <div class=""card mb-4"">
        <div class=""card-header"" id=""Filtry"">
            <div class=""mb-0 collapsed"" data-toggle=""collapse"" data-target=""#collapse1"" aria-expanded=""true"" aria-controls=""collapseOne"">
                <strong>Filtry</strong>
                <button class=""btn btn-link btn-sm"">
                    <i class=""fa fa-bars text-black""></i>
                </button>
            </div>
        </div>
        <div id=""collapse1""");
            BeginWriteAttribute("class", " class=\"", 934, "\"", 1001, 2);
            WriteAttributeValue("", 942, "collapse", 942, 8, true);
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
WriteAttributeValue(" ", 950, ViewData["currentFilter"] == null ? "" : "show", 951, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"Filtry\" data-parent=\"#accordion\">\r\n            <div class=\"card-body\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b8f7ce49f96d15744c9708ad0c2f52a5bdff3710839", async() => {
                WriteLiteral(@"
                    <div class=""form-group mb-2"">
                        <label>Wyszukaj po: </label>
                    </div>
                    <div class=""form-group mx-sm-3 mb-2 col-md-6"">
                        <input type=""text"" class=""form-control"" name=""SearchString""");
                BeginWriteAttribute("value", " value=\"", 1435, "\"", 1469, 1);
#nullable restore
#line 36 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
WriteAttributeValue("", 1443, ViewData["currentFilter"], 1443, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Imię, Nazwisko, Temat, Treść\" />\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary mb-2  btn-sm\">Szukaj</button>\r\n");
#nullable restore
#line 39 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                     if (ViewData["currentFilter"] != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a role=\"button\" class=\"btn btn-outline-primary mb-2\" id=\"usunFiltry\" href=\'javascript:history.go(-1)\'> <i class=\"fas fa-minus-circle\"></i> Usuń filtry</a>\r\n");
#nullable restore
#line 42 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 50 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
     foreach (var item in Model.OrderByDescending(x => x.StartDate).ThenBy(y => y.AddedDate))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 2152, "\"", 2428, 8);
            WriteAttributeValue("", 2160, "row", 2160, 3, true);
            WriteAttributeValue(" ", 2163, "no-gutters", 2164, 11, true);
            WriteAttributeValue(" ", 2174, "rounded", 2175, 8, true);
            WriteAttributeValue(" ", 2182, "shadow-sm", 2183, 10, true);
            WriteAttributeValue(" ", 2192, "mt-2", 2193, 5, true);
            WriteAttributeValue(" ", 2197, "mb-2", 2198, 5, true);
            WriteAttributeValue("\r\n\r\n           ", 2202, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 54 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
            if(item.ReadMessages.FirstOrDefault(f => f.MessageID == item.MessageID) == null)
            {
                 //Jesli wiadomosci nie ma w przeczytanych

#line default
#line hidden
#nullable disable
                WriteLiteral("                 ");
                WriteLiteral(" bg-light\r\n");
#nullable restore
#line 58 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 2217, 203, false);
            WriteAttributeValue("        ", 2420, "", 2428, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 61 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
              
                //wyswietlamy zdjecie profilowe autora wiadomosci
                if (item.SenderUser.Image != null)
                {
                    var base64 = Convert.ToBase64String(item.SenderUser.Image);
                    var imgSrc = String.Format("data:Image/jpeg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img style=\"width: 80px; height:80px\" class=\"card-img  mr-2\"");
            BeginWriteAttribute("src", " src=\"", 2836, "\"", 2849, 1);
#nullable restore
#line 67 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
WriteAttributeValue("", 2842, imgSrc, 2842, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 68 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68b8f7ce49f96d15744c9708ad0c2f52a5bdff3717226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"

                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-11\">\r\n");
#nullable restore
#line 76 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                 if (item.ReadMessages.FirstOrDefault(f => f.MessageID == item.MessageID) != null)
                {
                    //wiadomosc przeczytana

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-envelope-open float-right m-1\"></i>\r\n");
#nullable restore
#line 80 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                }
                else
                {
                    //wiadomosc nie przeczytana

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-envelope float-right m-1\"></i>\r\n");
#nullable restore
#line 85 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>");
#nullable restore
#line 86 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SenderUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 86 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.SenderUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b8f7ce49f96d15744c9708ad0c2f52a5bdff3720434", async() => {
                WriteLiteral("\r\n                    <span class=\"card-text\">\r\n                        ");
#nullable restore
#line 89 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                                          WriteLiteral(item.MessageID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n                <div class=\"float-right align-bottom\">\r\n                    <small class=\"text-muted align-bottom\">");
#nullable restore
#line 93 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental-PI-KF\Views\Messages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rental.Data.Data.Rental.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
