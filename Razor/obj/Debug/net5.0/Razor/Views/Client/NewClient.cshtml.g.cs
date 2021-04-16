#pragma checksum "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb3df3d2ff712241e0b851ddcd04dd3d9960e48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_NewClient), @"mvc.1.0.view", @"/Views/Client/NewClient.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb3df3d2ff712241e0b851ddcd04dd3d9960e48", @"/Views/Client/NewClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_NewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Razor.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">
                Add a New Client <br />
                <small>We're always happy to gain new customers.</small>
            </h1>
        </div>
    </div>
");
#nullable restore
#line 13 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
     using (Html.BeginForm("NewClient", "Client", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                   ");
#nullable restore
#line 18 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
              Write(Html.LabelFor(u => u.FirstName, "First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   ");
#nullable restore
#line 19 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
              Write(Html.TextBoxFor(u => u.FirstName, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.LastName, "Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.LastName, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                     ");
#nullable restore
#line 26 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                Write(Html.LabelFor(u => u.CompanyName, "Company Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     ");
#nullable restore
#line 27 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                Write(Html.TextBoxFor(u => u.CompanyName, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                     ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                Write(Html.LabelFor(u => u.Phone, "Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     ");
#nullable restore
#line 31 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                Write(Html.TextBoxFor(u => u.Phone, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.ContactDate, "Contact Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                    ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.TextBoxFor(u => u.ContactDate, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.LabelFor(u => u.ClientType, "Client Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                      
                        var clientTypes = new List<SelectListItem>
                        {
                            new SelectListItem() {Text = "Small Bussiness"},
                            new SelectListItem() {Text = "Individual"},
                            new SelectListItem() {Text = "Corporation"}
                        };
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 47 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
               Write(Html.DropDownListFor(u => u.ClientType, clientTypes , new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6 form-group\">\r\n                ");
#nullable restore
#line 54 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(Html.LabelFor(u => u.Notes, "Notes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 55 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
           Write(Html.TextBoxFor(u => u.Notes, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <h3>Billing Address</h3>
                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        ");
#nullable restore
#line 63 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 64 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.Street, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 68 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 73 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 74 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 77 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.BillingAddress.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 78 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.BillingAddress.Zip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <h3>Mailing Address</h3>
                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        ");
#nullable restore
#line 88 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 89 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.Street, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 92 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 93 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 98 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 99 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        ");
#nullable restore
#line 102 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.LabelFor(x => x.MailingAddress.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 103 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
                   Write(Html.TextBoxFor(x => x.MailingAddress.Zip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <input type=\"submit\" class=\"pull-right btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 109 "C:\Users\HP\Desktop\razor\Razor\Razor\Views\Client\NewClient.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Footer", async() => {
                WriteLiteral("\r\n    <p>Make sure to send new clients a welcome package.</p>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Razor.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591