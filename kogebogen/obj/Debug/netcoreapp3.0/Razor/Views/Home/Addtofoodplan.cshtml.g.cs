#pragma checksum "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43519ed3545be326029b3d567bc9abb108261ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Addtofoodplan), @"mvc.1.0.view", @"/Views/Home/Addtofoodplan.cshtml")]
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
#line 1 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\_ViewImports.cshtml"
using kogebogen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
using kogebogen.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
using kogebogen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43519ed3545be326029b3d567bc9abb108261ff5", @"/Views/Home/Addtofoodplan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addtofoodplan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
  
    ViewData["Title"] = "Addfav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Addfav</h1>\r\n\r\n\r\n<table>\r\n    <tr>\r\n        <th>Mandag</th>\r\n        <th>Tirsdag</th>\r\n        <th>Onsdag</th>\r\n        <th>Torsdag</th>\r\n        <th>Fredag</th>\r\n        <th>Lørdag</th>\r\n        <th>Søndag</th>\r\n    </tr>\r\n    <tr>\r\n\r\n");
#nullable restore
#line 23 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
         foreach (Recipe r in Model.Madplan)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <h4>");
#nullable restore
#line 27 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
               Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 484, "\"", 501, 1);
#nullable restore
#line 28 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
WriteAttributeValue("", 490, r.ImageUrl, 490, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <p>");
#nullable restore
#line 29 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
              Write(r.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n");
#nullable restore
#line 31 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
         

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n            ");
#nullable restore
#line 35 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addtofoodplan.cshtml"
       Write(Model.Madplan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n    </table>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
