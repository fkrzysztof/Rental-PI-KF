#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e2536bc89f75032abb1819ce91d4c4dbacb71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e2536bc89f75032abb1819ce91d4c4dbacb71b", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a59a14ceed467fcf91029402cc9fca83bd2182", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rental.Data.Data.Rental.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30px; height:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img  mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Upload/Default/DefaultUser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Aktualności";
    ViewBag.PageTitle = "Aktualności";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row no-gutters\">\r\n    <div class=\"row mb-4 no-gutters\">\r\n        <div class=\"col-md-12\">\r\n            <ul class=\"nav nav-tabs\">\r\n                <li class=\"nav-item\">\r\n                    <span");
            BeginWriteAttribute("class", " class=\"", 344, "\"", 408, 2);
            WriteAttributeValue("", 352, "nav-link", 352, 8, true);
#nullable restore
#line 12 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
WriteAttributeValue(" ", 360, ViewBag.GeneraltypeNow == null ? "active":"", 361, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Zapoznaj się z naszymi promocjami</span>
                </li>
            </ul>
        </div> 
        <div class=""col-md-12"">
            <div class=""card border-top-0 rounded-0 rounded-bottom"">
                <div class=""card-body"">
                    <div class=""row no-gutters"">
");
            WriteLiteral("                        <div class=\"col-12\">\r\n                            \r\n\r\n                                            <div class=\"row\">\r\n                                                <div class=\"col-12\">\r\n");
#nullable restore
#line 28 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                     foreach (var item in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""card shadow-sm mb-4 mt-4"">
                                                            <div class=""card-body"">
                                                                <small class=""float-sm-right"">");
#nullable restore
#line 32 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                                         Write(item.Create);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                                <h5 class=\"card-title text-info\">");
#nullable restore
#line 33 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                                            Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                                <p class=\"card-text\">");
#nullable restore
#line 34 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                                Write(item.NewsContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                                <hr />
                                                                <div class=""float-right"">
                                                                    <span class=""align-bottom"">");
#nullable restore
#line 37 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                                          Write(item.SenderUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                                                                     Write(item.SenderUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 38 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                      
                                                                        //wyswietlamy zdjecie profilowe autora
                                                                        if (item.SenderUser.Image != null)
                                                                        {
                                                                            var base64 = Convert.ToBase64String(item.SenderUser.Image);
                                                                            var imgSrc = String.Format("data:Image/jpeg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <img style=\"width: 30px; height:30px\" class=\"card-img  mr-2\"");
            BeginWriteAttribute("src", " src=\"", 2896, "\"", 2909, 1);
#nullable restore
#line 44 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
WriteAttributeValue("", 2902, imgSrc, 2902, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 45 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                        }
                                                                        else
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64e2536bc89f75032abb1819ce91d4c4dbacb71b10309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
#line 49 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                                        }
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                </div>\r\n                                                            </div>\r\n                                                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\News\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rental.Data.Data.Rental.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591