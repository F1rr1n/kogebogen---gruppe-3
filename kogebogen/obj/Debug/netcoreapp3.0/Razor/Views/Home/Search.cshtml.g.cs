#pragma checksum "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d233e4b7dbad8357a34b4faf46d5e3cb9c19a9f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d233e4b7dbad8357a34b4faf46d5e3cb9c19a9f4", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21405804a1e5690aec9b744b289feb3d01148ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeHolder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search</h1>\r\n\r\n\r\n<p>Title</p>\r\n");
#nullable restore
#line 10 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
 for (int i = 0; i < Model.recipeCounter; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
Write(Model.recipes[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
      
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Disse opskrifter passer til hvad du søgte efter</p>\r\n");
#nullable restore
#line 18 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
 for (int i = Model.recipeCounter; i < Model.recipes.Count; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
Write(Model.recipes[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Peter\Documents\GitHub\kogebogen---gruppe-3\kogebogen\Views\Home\Search.cshtml"
      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeHolder> Html { get; private set; }
    }
}
#pragma warning restore 1591
