#pragma checksum "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "904984786d5c853e540c4011c9827c5b826638df"
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
#line 1 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\_ViewImports.cshtml"
using kogebogen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\_ViewImports.cshtml"
using kogebogen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
using kogebogen.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"904984786d5c853e540c4011c9827c5b826638df", @"/Views/Home/Addfav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addfav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
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
#line 3 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
  
    ViewData["Title"] = "Addfav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Addfav</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
 foreach (Recipe r in Model.Favorites)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flex-container\" style=\"display:flex\">\r\n        <h2>");
#nullable restore
#line 15 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
       Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "904984786d5c853e540c4011c9827c5b826638df4107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 254, "~/img/", 254, 6, true);
#nullable restore
#line 16 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"
AddHtmlAttributeValue("", 260, r.ImageUrl, 260, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Addfav.cshtml"


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
