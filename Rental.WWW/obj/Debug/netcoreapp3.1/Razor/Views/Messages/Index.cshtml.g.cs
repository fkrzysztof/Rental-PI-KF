#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9db40211baa94573f8a26d426ef0aceceaddaebd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db40211baa94573f8a26d426ef0aceceaddaebd", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a59a14ceed467fcf91029402cc9fca83bd2182", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental.Data.Data.Rental.Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px; height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img  mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Upload/Default/DefaultUser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
  
    //ViewData["Title"] = "Wiadomości nieodczytane";
    ViewData["Title"] = ViewBag.Tite;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-4 justify-content-center\">\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 10 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
   Write(await Html.PartialAsync("Navi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""col-md-12"">
        <div class=""card border-top-0 rounded-0 rounded-bottom"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-12 mb-2"">
                        <span class=""float-left""><i class=""fas fa-folder-open mr-2""></i>Lista aktualnych pozycji</span>
                        <button class=""btn text-primary float-right"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""true"" aria-controls=""collapseExample""><i class=""fas fa-sliders-h""></i></button>
                    </div>
                    <div class=""col-12 mb-4"">
                        <div class=""text-center collapse show"" id=""collapseExample""");
            BeginWriteAttribute("style", " style=\"", 1013, "\"", 1021, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card card-body pb-0\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db40211baa94573f8a26d426ef0aceceaddaebd8453", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                    <div class=\"row\">\r\n                                        <div class=\"col-sm-12 align-self-center\">\r\n");
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                              
                                                if (@ViewBag.Search != null)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span class=\"badge badge-pill badge-info\">\"");
#nullable restore
#line 31 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                                                                          Write(ViewBag.Search);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db40211baa94573f8a26d426ef0aceceaddaebd9698", async() => {
                    WriteLiteral("&times;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</span> ");
#nullable restore
#line 31 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                                                                                                                                                                                                       
                                                }
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <input type=""text"" name=""searchString"" class=""form-control"" placeholder=""Wpisz szukaną frazę.."" />
                                        </div>
                                        <div class=""col-sm-12 text-right"">
                                            <button type=""submit"" class=""btn text-primary""><i class=""fas fa-search""></i></button>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db40211baa94573f8a26d426ef0aceceaddaebd11990", async() => {
                    WriteLiteral("<i class=\"fas fa-ban\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n\r\n\r\n                       \r\n");
#nullable restore
#line 50 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                             foreach (var item in Model.OrderByDescending(x => x.StartDate).ThenBy(y => y.AddedDate))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 3100, "\"", 3524, 8);
            WriteAttributeValue("", 3108, "row", 3108, 3, true);
            WriteAttributeValue(" ", 3111, "no-gutters", 3112, 11, true);
            WriteAttributeValue(" ", 3122, "rounded", 3123, 8, true);
            WriteAttributeValue(" ", 3130, "shadow-sm", 3131, 10, true);
            WriteAttributeValue(" ", 3140, "mt-2", 3141, 5, true);
            WriteAttributeValue(" ", 3145, "mb-2", 3146, 5, true);
            WriteAttributeValue("\r\n\r\n                                   ", 3150, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 54 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                    if(item.ReadMessages.FirstOrDefault(f => f.MessageID == item.MessageID) == null)
                                    {
                                         //Jesli wiadomosci nie ma w przeczytanych

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         ");
                WriteLiteral(" bg-light\r\n");
#nullable restore
#line 58 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 3189, 299, false);
            WriteAttributeValue("                                    ", 3488, "", 3524, 36, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 61 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                      
                                        //wyswietlamy zdjecie profilowe autora wiadomosci
                                        if (item.SenderUser.Image != null)
                                        {
                                            var base64 = Convert.ToBase64String(item.SenderUser.Image);
                                            var imgSrc = String.Format("data:Image/jpeg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img style=\"width: 80px; height:80px\" class=\"card-img  mr-2\"");
            BeginWriteAttribute("src", " src=\"", 4100, "\"", 4113, 1);
#nullable restore
#line 67 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
WriteAttributeValue("", 4106, imgSrc, 4106, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 68 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9db40211baa94573f8a26d426ef0aceceaddaebd18712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-11 ml-2\">\r\n");
#nullable restore
#line 75 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                         if (item.ReadMessages.FirstOrDefault(f => f.MessageID == item.MessageID) != null)
                                        {
                                            //wiadomosc przeczytana

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-envelope-open float-right m-1\"></i>\r\n");
#nullable restore
#line 79 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                        }
                                        else
                                        {
                                            //wiadomosc nie przeczytana

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-envelope float-right m-1\"></i>\r\n");
#nullable restore
#line 84 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5>");
#nullable restore
#line 85 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SenderUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => item.SenderUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db40211baa94573f8a26d426ef0aceceaddaebd22319", async() => {
                WriteLiteral("\r\n                                            <span class=\"card-text\">\r\n                                                ");
#nullable restore
#line 88 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </span>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                                                  WriteLiteral(item.MessageID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n                                        <div class=\"float-right align-bottom\">\r\n                                            <small class=\"text-muted align-bottom\">");
#nullable restore
#line 92 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 96 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Messages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
