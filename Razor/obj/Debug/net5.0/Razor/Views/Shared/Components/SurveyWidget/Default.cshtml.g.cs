#pragma checksum "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Shared\Components\SurveyWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d44b2f96b26ea6fc76fb3fa7fabb6d9865291f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SurveyWidget_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SurveyWidget/Default.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\_ViewImports.cshtml"
using Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\_ViewImports.cshtml"
using Razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44b2f96b26ea6fc76fb3fa7fabb6d9865291f70", @"/Views/Shared/Components/SurveyWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SurveyWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Razor.Components.SurveyProduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""panel panel-primary widget"">
                            <div class=""panel-heading"">
                                <div class=""row"">
                                    <div class=""col-xs-3"">
                                        <i class=""fa fa-comments fa-3x""></i>
                                    </div>
                                    <div class=""col-xs-9 text-right"">
                                        <h3>Coolest Product</h3>
                                    </div>
                                </div>
                            </div>
                            <div class=""widget-display"">
                                <table class=""table table-fluid table-striped"">
                                    <thead>
                                        <tr>
                                            <th>Product</th>
                                            <th>Add Vote</th>
                                        </tr>
                               ");
            WriteLiteral("     </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Shared\Components\SurveyWidget\Default.cshtml"
                                         foreach (var product in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 26 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Shared\Components\SurveyWidget\Default.cshtml"
                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td><a href=\"#\" class=\"vote-up\" data-productIds=\"3\">Vote Up</a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Shared\Components\SurveyWidget\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Razor.Components.SurveyProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
