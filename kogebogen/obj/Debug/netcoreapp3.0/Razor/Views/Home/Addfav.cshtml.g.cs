#pragma checksum "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "178f8e2e7df1ad64eb21461ae6bc3d4a10328d1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Addfav), @"mvc.1.0.view", @"/Views/Home/Addfav.cshtml")]
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
#line 2 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\_ViewImports.cshtml"
using kogebogen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
using kogebogen.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178f8e2e7df1ad64eb21461ae6bc3d4a10328d1f", @"/Views/Home/Addfav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addfav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
  
    ViewData["Title"] = "Addfav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Addfav</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 11 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
 foreach (Recipe r in Model.Favorites)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flex-container\" style=\"display:flex\">\r\n        <h2>");
#nullable restore
#line 15 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
       Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 248, "\"", 265, 1);
#nullable restore
#line 16 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
WriteAttributeValue("", 254, r.ImageUrl, 254, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        \r\n\r\n    </div>\r\n");
#nullable restore
#line 20 "D:\Brugere\Multimedie Design\github\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"


}

#line default
#line hidden
#nullable disable
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