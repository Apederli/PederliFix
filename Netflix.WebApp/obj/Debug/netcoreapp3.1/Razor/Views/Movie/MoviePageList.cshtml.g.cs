#pragma checksum "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465ce10a90bc4fa085419f03ac047dec39b8f3c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MoviePageList), @"mvc.1.0.view", @"/Views/Movie/MoviePageList.cshtml")]
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
#line 1 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\_ViewImports.cshtml"
using Netflix.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\_ViewImports.cshtml"
using Netflix.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml"
using Netflix.WebApp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465ce10a90bc4fa085419f03ac047dec39b8f3c8", @"/Views/Movie/MoviePageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9da059e7dad3b04ec730360309490aaad48a41b", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MoviePageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeriesMovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml"
  
    ViewData["Title"] = "MoviePageList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MoviePageList</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml"
 foreach (var item in Model.Movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 185, "\"", 234, 2);
            WriteAttributeValue("", 191, "https://localhost:44365/images/", 191, 31, true);
#nullable restore
#line 10 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml"
WriteAttributeValue("", 222, item.Banner, 222, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"105\" height=\"140\" class=\"img-thumbnail\" />\r\n");
#nullable restore
#line 11 "C:\Users\Aydog\source\repos\PederliFix\Netflix.WebApp\Views\Movie\MoviePageList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeriesMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591