#pragma checksum "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Shared\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbfe2fd0538676937a6d7cc4a003ad112a32ac9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_News), @"mvc.1.0.view", @"/Views/Shared/News.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbfe2fd0538676937a6d7cc4a003ad112a32ac9", @"/Views/Shared/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a59a14ceed467fcf91029402cc9fca83bd2182", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"" id=""newsTop"">
    
    <div class=""col-12 justify-content-center text-center"" id=""load"">
        <div class=""spinner-border"" role=""status"">
            <span class=""sr-only"">Loading...</span>
        </div>
    </div>


</div>

<script type=""text/javascript"">
            $(document).ready(function () {

                    var urlNews = '");
#nullable restore
#line 15 "C:\Users\krzys\Documents\Programowanie\Rental-PI-KF\Rental.WWW\Views\Shared\News.cshtml"
                              Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""News/GetTopNews"";
                    $.getJSON(urlNews, function (newscollection) {
                        var htmlstring = """";

                        $.each(newscollection, function (i, newsItem) {
                            
                            htmlstring += ""<div class=\""col-xl-3 col-md-6 mb-4\"">"" +
                                ""<div class=\""card border-left-info h-100 py-2\"">"" +
                                ""<div class=\""card-body\"">"" +
                                ""<div class=\""row no-gutters align-items-center\"">"" +
                                ""<div class=\""col mr-2\"">"" +
                                ""<div class=\""text-xs font-weight-bold text-info text-uppercase mb-1\"">"" + newsItem.topic + ""</div>"" +
                                ""<div class=\""row no-gutters align-items-center\"">"" +
                                ""<div class=\""col-auto\"">"" +
                                ""<div class=\""h6 mb-0 mr-3 font-weight-bold text-gray-800 \"">"" + newsItem.newsCo");
            WriteLiteral(@"ntent.substring(0, 50) + ""...</div>"" +
                                                                    ""</div>"" +
                                                                ""</div>"" +
                                                            ""</div>"" +
                                                            ""<div class=\""col-auto\"">"" +
                                                                ""<i class=\""fas fa-clipboard-list fa-2x text-gray-300\""></i>"" +
                                                            ""</div>"" +
                                                        ""</div>"" +
                                                    ""</div>"" +
                                                ""</div>"" +
                                            ""</div >"";
                        });

                        $('#load').css({ display: ""none"" });
                        $('#newsTop').html(htmlstring);
                    });
            });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591