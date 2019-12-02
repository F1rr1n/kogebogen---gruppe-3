#pragma checksum "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969bd538bca75b7e48039341c9086f18bd9ddcbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Recipes), @"mvc.1.0.view", @"/Views/Home/Recipes.cshtml")]
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
#line 1 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\_ViewImports.cshtml"
using kogebogen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\_ViewImports.cshtml"
using kogebogen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
using kogebogen.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969bd538bca75b7e48039341c9086f18bd9ddcbf", @"/Views/Home/Recipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Recipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repositories>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/recipes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
  
    ViewData["Title"] = "Recipes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Fontawesome - icons -->
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css""
      integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">

<h1>Recipes</h1>

<button class=""collapsible"">Filtrer<i class=""fas fa-sort-down""></i></button>
<div class=""content"" style=""display:none;"">
    <div class=""slidecontainer"">
        <p id=""filterPrice""></p>
        20 kr <input type=""range"" class=""slider"" name=""rangeInput"" min=""20"" max=""100"" value=""60""> 100 kr

        <p id=""filterTime""></p>
        10 min <input type=""range"" class=""slider"" id=""filterRange"" name=""rangeInput"" min=""10"" max=""120"" value=""55""> 120 min
    </div>
</div>

<button class=""collapsible"">Sortér efter <i class=""fas fa-sort-down""></i></button>
<div class=""content"" style=""display:none;"">
    <input type=""checkbox"" name=""sorting"" value=""newest""> Nyeste <br />
    <input type=""checkbox"" name=""sorting"" value=""price1""> Pris lav til høj <br />
   ");
            WriteLiteral(" <input type=\"checkbox\" name=\"sorting\" value=\"price2\"> Pris høj til lav <br />\r\n    <input type=\"checkbox\" name=\"sorting\" value=\"a-z\"> A til Z <br />\r\n    <input type=\"checkbox\" name=\"sorting\" value=\"totalTime\"> Tid i alt <br />\r\n</div>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
 foreach (Recipe r in Model.CookBook)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flex-container\" style=\"display:flex\">\r\n        <h2>");
#nullable restore
#line 36 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
       Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1493, "\"", 1510, 1);
#nullable restore
#line 37 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
WriteAttributeValue("", 1499, r.ImageUrl, 1499, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        \r\n        <button class=\"fas fa-heart addToMy\"></button>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\densk\OneDrive\Dokumenter\Visual Studio 2019\Projects\Kogebogen\kogebogen\Views\Home\Recipes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969bd538bca75b7e48039341c9086f18bd9ddcbf6686", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repositories> Html { get; private set; }
    }
}
#pragma warning restore 1591
