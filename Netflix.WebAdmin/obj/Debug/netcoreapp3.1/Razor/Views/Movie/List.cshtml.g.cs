#pragma checksum "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_List), @"mvc.1.0.view", @"/Views/Movie/List.cshtml")]
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
#line 1 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\_ViewImports.cshtml"
using Netflix.WebAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\_ViewImports.cshtml"
using Netflix.WebAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
using Netflix.WebAdmin.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f1", @"/Views/Movie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6a230885accc884e651838643a43d858f4269f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JsMovieList.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("105"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ConfirmJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.7.0/css/all.css\" integrity=\"sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ\" crossorigin=\"anonymous\">\r\n<h1>List</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f16302", async() => {
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
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f17356", async() => {
                WriteLiteral("Yeni Film Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Banner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <span>Options&nbsp;&nbsp;</span>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 42 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
           Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 50 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
                     if (!string.IsNullOrEmpty(item.Summary) && item.Summary.Length > 35)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 52 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
                       Write(item.Summary.Substring(0,35));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f112786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1889, "~/images/", 1889, 9, true);
#nullable restore
#line 59 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
AddHtmlAttributeValue("", 1898, item.Banner, 1898, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f114585", async() => {
                WriteLiteral("<i title=\"Edit\" class=\"fas fa-edit\" style=\"color:coral\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2037, "~/Movie/Edit/", 2037, 13, true);
#nullable restore
#line 62 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
AddHtmlAttributeValue("", 2050, item.Id, 2050, 8, false);

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
            WriteLiteral("&nbsp;\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f116198", async() => {
                WriteLiteral("<i title=\"Edit\" class=\"fas fa-info-circle\" style=\"color:cornflowerblue\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2161, "~/Movie/Detail/", 2161, 15, true);
#nullable restore
#line 63 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
AddHtmlAttributeValue("", 2176, item.Id, 2176, 8, false);

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
            WriteLiteral("&nbsp;\r\n");
            WriteLiteral("\r\n                    <!--CONFIRM Modal POPUP-->\r\n                    <div class=\"modal\" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("id", " id=\"", 2807, "\"", 2831, 2);
            WriteAttributeValue("", 2812, "modalPopup_", 2812, 11, true);
#nullable restore
#line 71 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 2823, item.Id, 2823, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"modal-dialog\" role=\"document\">\r\n                            <div class=\"modal-content\">\r\n                                <div class=\"modal-header\">\r\n                                    <h4 class=\"modal-title\">");
#nullable restore
#line 75 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3189, "\"", 3231, 4);
            WriteAttributeValue("", 3199, "confirmDelete(\'", 3199, 15, true);
#nullable restore
#line 76 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 3214, item.Id, 3214, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3222, "\',", 3222, 2, true);
            WriteAttributeValue(" ", 3224, "false)", 3225, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    <p>Bu filmi silmek istediğinizden emin misiniz?</p>
                                </div>
                                <div class=""modal-footer"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f120096", async() => {
                WriteLiteral(" Evet");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3714, "~/Movie/Delete/", 3714, 15, true);
#nullable restore
#line 84 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
AddHtmlAttributeValue("", 3729, item.Id, 3729, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a href=\"#\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3844, "\"", 3886, 4);
            WriteAttributeValue("", 3854, "confirmDelete(\'", 3854, 15, true);
#nullable restore
#line 85 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 3869, item.Id, 3869, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3877, "\',", 3877, 2, true);
            WriteAttributeValue(" ", 3879, "false)", 3880, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Hayır</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <span");
            BeginWriteAttribute("id", " id=\"", 4062, "\"", 4086, 2);
            WriteAttributeValue("", 4067, "deleteSpan_", 4067, 11, true);
#nullable restore
#line 91 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 4078, item.Id, 4078, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a href=\"#\"><i title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4143, "\"", 4184, 4);
            WriteAttributeValue("", 4153, "confirmDelete(\'", 4153, 15, true);
#nullable restore
#line 92 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 4168, item.Id, 4168, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4176, "\',", 4176, 2, true);
            WriteAttributeValue(" ", 4178, "true)", 4179, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-trash\" style=\"color:red\"></i></a>\r\n                    </span>\r\n                </td>\r\n                <td colspan=\"3\" align=\"center\">\r\n                    <pager");
            BeginWriteAttribute("list", " list=\"", 4362, "\"", 4375, 1);
#nullable restore
#line 96 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"
WriteAttributeValue("", 4369, Model, 4369, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Movie\" asp-action=\"List\" />\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 100 "C:\Users\Aydog\Source\Repos\PederliFix\Netflix.WebAdmin\Views\Movie\List.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf4be29c26fcb3c0e0c74819fdd5c4c5c6f8f124609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
