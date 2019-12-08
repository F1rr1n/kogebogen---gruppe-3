#pragma checksum "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0115d1dbe3300423211a5ed4cd8a3e5cd30d5ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TheRecipe), @"mvc.1.0.view", @"/Views/Home/TheRecipe.cshtml")]
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
#line 1 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\_ViewImports.cshtml"
using kogebogen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\_ViewImports.cshtml"
using kogebogen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0115d1dbe3300423211a5ed4cd8a3e5cd30d5ca2", @"/Views/Home/TheRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TheRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 40vw; max-height:35vh;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
  
    ViewData["Title"] = "TheRecipe";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Opskriftens titel og beskrivelse -->\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Beskrivelse</h2>\r\n<p>");
#nullable restore
#line 9 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<!-- Div-container der indeholder ingredienserne, pris, tid og billede -->
<div class=""ingredients-container"" style=""display:flex;justify-content:space-between;"">
    <div class=""ingredients"">
        <h2>Ingredienser</h2>
        <table>
            <!-- Loop igennem ingredienserne, da det er en liste -->
");
#nullable restore
#line 17 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
             foreach (ModelIngredient i in Model.Ingredients)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
                   Write(i.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
                   Write(i.Ingredient.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
                   Write(i.Ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <p>Pris i alt: ");
#nullable restore
#line 27 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
                  Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kr</p>\r\n        <p><i class=\"fas fa-clock\"></i> Tid i alt: ");
#nullable restore
#line 28 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
                                              Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</p>\r\n\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0115d1dbe3300423211a5ed4cd8a3e5cd30d5ca26743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 937, "~/img/", 937, 6, true);
#nullable restore
#line 31 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
AddHtmlAttributeValue("", 943, Model.ImageUrl, 943, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
AddHtmlAttributeValue("", 965, Model.Name, 965, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<!-- Vejledningen til opskrifterne i et loop, da det er en liste -->\r\n<h2>Vejledning</h2>\r\n<ol>\r\n");
#nullable restore
#line 37 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
     foreach (string guide in Model.Guide)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 39 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
       Write(guide);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "C:\Users\Peter\Documents\Visual Studio 2019\Kogebogen projekt\kogebogen\Views\Home\TheRecipe.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
