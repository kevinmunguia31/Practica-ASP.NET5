#pragma checksum "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98233292419debcf54b5dbfd23ada7fb7d831ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98233292419debcf54b5dbfd23ada7fb7d831ec", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MvcMovie.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Movie/Find"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <h3 class=\"text-center\">Productos</h3>\n        <hr>\n    </div>\n");
#nullable restore
#line 10 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\n            <div class=\"card card-product mb-3\">\n                <div class=\" d-flex flex-row-reverse bd-highlight\">\n");
#nullable restore
#line 15 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                     if((await AuthorizationService.AuthorizeAsync(User, "Required")).Succeeded){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button");
            BeginWriteAttribute("onclick", "  onclick=\"", 562, "\"", 594, 3);
            WriteAttributeValue("", 573, "deleteMovie(", 573, 12, true);
#nullable restore
#line 16 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
WriteAttributeValue("", 585, item.Id, 585, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 593, ")", 593, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""mr-2 close p-2 bd-highlight"" data-dismiss=""toast"" aria-label=""Close"">
                            <span style=""color: red;"" aria-hidden=""true"">&times;</span>
                        </button>
                        <a style=""color: green; font-size:15px;""");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 900, 2);
            WriteAttributeValue("", 880, "/Movie/Edit/", 880, 12, true);
#nullable restore
#line 19 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
WriteAttributeValue("", 892, item.Id, 892, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-transparent\"><i class=\"fas fa-wrench\"></i></a>\n");
#nullable restore
#line 20 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \n                     \n                </div>\n                <img");
            BeginWriteAttribute("src", " src=\"", 1071, "\"", 1089, 1);
#nullable restore
#line 24 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
WriteAttributeValue("", 1077, item.Poster, 1077, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1111, "\"", 1117, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"250px\" height=\"250px\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 26 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 27 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                                    Write(item.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 28 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                                                              Write(item.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1421, "\"", 1451, 2);
            WriteAttributeValue("", 1428, "/Movie/Details/", 1428, 15, true);
#nullable restore
#line 29 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
WriteAttributeValue("", 1443, item.Id, 1443, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Ver Mas</a>\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1520, "\"", 1557, 4);
            WriteAttributeValue("", 1530, "loadComent(", 1530, 11, true);
#nullable restore
#line 30 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
WriteAttributeValue("", 1541, item.Id, 1541, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1549, ",", 1549, 1, true);
            WriteAttributeValue(" ", 1550, "event)", 1551, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><small><i class=\"fas fa-comment-dots\"></i></small></a>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 34 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Anuncio", async() => {
                WriteLiteral("\n    <div");
                BeginWriteAttribute("class", " class=\"", 1735, "\"", 1743, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98233292419debcf54b5dbfd23ada7fb7d831ec10941", async() => {
                    WriteLiteral("\n            <div class=\"form-group \">\n                <!--<label class=\"mr-3\">Buscar Producto</label>-->\n");
#nullable restore
#line 42 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                 if((await AuthorizationService.AuthorizeAsync(User, "Required")).Succeeded){

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98233292419debcf54b5dbfd23ada7fb7d831ec11614", async() => {
                        WriteLiteral("<i class=\"fas fa-notes-medical\"></i>");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("        \n");
#nullable restore
#line 44 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                 if((await AuthorizationService.AuthorizeAsync(User, "Editores")).Succeeded){

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98233292419debcf54b5dbfd23ada7fb7d831ec13694", async() => {
                        WriteLiteral("<i class=\"fas fa-notes-medical\"></i>");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("        \n");
#nullable restore
#line 47 "/home/kevinmunguia/Documentos/ASP.Net/MvcMovie/Views/Movie/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                
                <input type=""text"" class=""form-control ml-3"" placeholder=""Buscar Producto"" required minlength=""1"" name=""movie2"">
            </div>
            <button type=""submit"" class=""btn btn-primary mt-1 mb-1 ml-2""><i class=""fas fa-search""></i></button>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <hr>
        <h3>Información COVID-19</h3>
        <hr>
        <div class=""list-group"">
            <a target=""_blank"" href=""https://www.eleconomista.es/actualidad/noticias/11388850/09/21/Cesar-Carballo-explica-por-que-siguen-muriendo-tantas-personas-de-Covid19.html"" class=""list-group-item list-group-item-action"">
                <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">César Carballo explica por qué siguen muriendo tantas personas de Covid-19</h5>
                <small> Madrid 13/09/2021</small>
                </div>
                <p class=""mb-1"">La estrategia de vacunación española ya ha superado el 70% de la población española y camina hacia el 90%...</p>
                <small>Fuente: elEconomista </small>
            </a>
            <a target=""_blank"" href=""https://www.el19digital.com/articulos/ver/titulo:120523-vacunacion-voluntaria-contra-covid-19-sigue-sumando-protagonistas-en-managua"" class=""list-group-item list-group-item-action"">
           ");
                WriteLiteral(@"     <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">Vacunación voluntaria contra Covid-19 sigue sumando protagonistas en Managua</h5>
                <small class=""text-muted"">Managua 13/09/2021</small>
                </div>
                <p class=""mb-1"">La intensa campaña de vacunación voluntaria contra la Covid-19 siguió realizándose en la capital con la aplicación de la segunda dosis de Spunitk V...</p>
                <small class=""text-muted"">Fuente: El 19 Digital</small>
            </a>
            <a target=""_blank"" href=""https://www.nytimes.com/es/2021/08/18/espanol/cuba-coronavirus.html"" class=""list-group-item list-group-item-action"">
                <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">‘Ingresan para morir’: el coronavirus muestra las fallas del sistema de salud cubano</h5>
                <small class=""text-muted""> EE.UU. 18/08/2021</small>
                </div>
                <p class=""mb-1"">Después de la con");
                WriteLiteral(@"tingencia del coronavirus en 2020, Cuba ha sido devastada por la variante delta, que es altamente contagiosa y ha aumentado las...</p>
                <small class=""text-muted"">Fuente: The New York Times</small>
            </a>
            <img src=""https://coronavirus.gob.mx/wp-content/uploads/2020/04/Banner-QuedateCasa.png""");
                BeginWriteAttribute("alt", " alt=\"", 5110, "\"", 5116, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n    </div>\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("AnuncioInferior", async() => {
                WriteLiteral(@"
    <h3><i class=""fas fa-search-location""></i> Nuestras Sucursales en todo El Pais</h3>
    <div class=""row"">
        <div class=""col-4"">
            <div class=""list-group"" id=""list-tab"" role=""tablist"">
                <a class=""list-group-item list-group-item-action active d-flex justify-content-between"" id=""list-home-list"" data-toggle=""list"" href=""#list-home"" role=""tab"" aria-controls=""home"">
                    <strong>Chinandega</strong>
                    <img loading=""lazy"" class=""lazy alignnone wp-image-228 lazy-loaded"" src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png"" data-lazy-type=""image"" data-lazy-src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png""");
                BeginWriteAttribute("alt", " alt=\"", 5922, "\"", 5928, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""22"" height=""30"">
                </a>
                <a class=""list-group-item list-group-item-action d-flex justify-content-between"" id=""list-profile-list"" data-toggle=""list"" href=""#list-profile"" role=""tab"" aria-controls=""profile"">
                    <strong>Masaya</strong>
                    <img loading=""lazy"" class=""lazy alignnone wp-image-228 lazy-loaded"" src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png"" data-lazy-type=""image"" data-lazy-src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png""");
                BeginWriteAttribute("alt", " alt=\"", 6517, "\"", 6523, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""22"" height=""30"">
                </a>
                <a class=""list-group-item list-group-item-action d-flex justify-content-between"" id=""list-messages-list"" data-toggle=""list"" href=""#list-messages"" role=""tab"" aria-controls=""messages"">
                    <strong>León</strong>
                    <img loading=""lazy"" class=""lazy alignnone wp-image-228 lazy-loaded"" src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png"" data-lazy-type=""image"" data-lazy-src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png""");
                BeginWriteAttribute("alt", " alt=\"", 7113, "\"", 7119, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""22"" height=""30"">
                </a>
                <a class=""list-group-item list-group-item-action d-flex justify-content-between"" id=""list-settings-list"" data-toggle=""list"" href=""#list-settings"" role=""tab"" aria-controls=""settings"">
                    <strong>Esteli</strong>
                    <img loading=""lazy"" class=""lazy alignnone wp-image-228 lazy-loaded"" src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png"" data-lazy-type=""image"" data-lazy-src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/marker-icon.png""");
                BeginWriteAttribute("alt", " alt=\"", 7711, "\"", 7717, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""22"" height=""30"">
                </a>
            </div>
        </div>
        <div class=""col-8"">
            <div class=""tab-content"" id=""nav-tabContent"">
                <div class=""tab-pane fade show active"" id=""list-home"" role=""tabpanel"" aria-labelledby=""list-home-list"">
                    <p class=""ml-2"">Tel: 1801-3276
                    <br>Ubicada de Panaderia Morellia 1/2 cuadra al sur, contiguo a Ecami Industrial.
                    <br>Lun-vie: 8am-9pm  Sab-Dom: 8am-7pm

                    <br>Gerente: Ramón Duriez.

                    <br>rduriez@fvalue.biz</p>
                    <img src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/Chinandega1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8427, "\"", 8433, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250px\" height=\"250px\">\n                </div>\n                <div class=\"tab-pane fade\" id=\"list-profile\" role=\"tabpanel\" aria-labelledby=\"list-profile-list\">         \n                    <p");
                BeginWriteAttribute("class", " class=\"", 8633, "\"", 8641, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tel: 1801-3276
                    <br>Costado Sur Este parque central.
                    <br>Lun-vie: 8am-10pm  Sab-Dom: 8am-8pm

                    <br>Gerente: Marx Ruiz.

                    <br>mruiz@fvalue.biz</p>
                    <img src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/Masaya1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8977, "\"", 8983, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250px\" height=\"250px\">\n                </div>\n                <div class=\"tab-pane fade\" id=\"list-messages\" role=\"tabpanel\" aria-labelledby=\"list-messages-list\">\n                    <p");
                BeginWriteAttribute("class", " class=\"", 9176, "\"", 9184, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tel: 1801-3276
                    <br>Costado Sur Parque La Merced, antiguo local de Don Señor.
                    <br>Lun-vie: 7am-9:30pm  Sab: 8am-9:30pm Dom: 8am-7pm

                    <br>Gerente: Milton Montiel.

                    <br>mmontiel@fvalue.biz</p>
                    <img src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/Leon1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 9565, "\"", 9571, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250px\" height=\"250px\">\n                </div>\n                <div class=\"tab-pane fade\" id=\"list-settings\" role=\"tabpanel\" aria-labelledby=\"list-settings-list\">\n                    <p");
                BeginWriteAttribute("class", " class=\"", 9764, "\"", 9772, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tel: 1801-3276
                    <br>Del supermercado Las Segovias, 2 cuadras al Sur.
                    <br>Lun-vie: 8am-10pm  Sab: 8am-8pm Dom: 8am-7pm

                    <br>Gerente: Emilson Diaz.

                    <br>ediaz@fvalue.biz</p>
                    <img src=""https://farmavalue.biz/nicaragua/wp-content/uploads/sites/22/2019/06/Esteli3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10136, "\"", 10142, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250px\" height=\"250px\">\n                </div>\n            </div>\n        </div>\n    </div>\n");
            }
            );
            WriteLiteral(@"

<div class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Comentarios</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div id=""div_comment"" class=""modal-body"">
        <div class=""spinner-border"" role=""status"">
          <span class=""sr-only"">Loading...</span>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
        <!--<button type=""button"" class=""btn btn-primary"">Save changes</button>-->
      </div>
    </div>
  </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MvcMovie.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591