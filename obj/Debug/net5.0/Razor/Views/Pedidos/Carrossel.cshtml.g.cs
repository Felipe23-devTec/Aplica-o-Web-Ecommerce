#pragma checksum "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab31f35836c1505eaa42de3772258076637ca11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Carrossel), @"mvc.1.0.view", @"/Views/Pedidos/Carrossel.cshtml")]
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
#line 1 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\_ViewImports.cshtml"
using WebbAppEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\_ViewImports.cshtml"
using WebbAppEcommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab31f35836c1505eaa42de3772258076637ca11", @"/Views/Pedidos/Carrossel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c162128b0f2025fc8ac3ab9166c150332dcd732", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Carrossel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebbAppEcommerce.Entities.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Catálogo</h3>\n<div id=\"my-carousel\" class=\"carousel slide\" data-ride=\"carousel\">\n    <!-- Wrapper for slides -->\n    <div class=\"carousel-inner\" role=\"listbox\">\n");
#nullable restore
#line 6 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
           const int TAMANHO_PAGINA = 4;
                        int paginas = (int)Math.Ceiling((double)Model.Count() / TAMANHO_PAGINA); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
         for (int i = 0; i < paginas; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 423, "\"", 460, 2);
            WriteAttributeValue("", 431, "item", 431, 4, true);
#nullable restore
#line 11 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
WriteAttributeValue(" ", 435, i == 0 ? "active": "", 436, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"row\">\n\n");
#nullable restore
#line 14 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
                       var listaProdutos = Model.Skip(i * TAMANHO_PAGINA).Take(TAMANHO_PAGINA); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
                     foreach (var produto in listaProdutos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-3 col-sm-3 col-lg-3\">\n                            <div class=\"panel panel-default\">\n                                <div class=\"panel-body\">\n                                    <img class=\"img-produto-carrossel\"");
            BeginWriteAttribute("src", " src=\"", 933, "\"", 990, 3);
            WriteAttributeValue("", 939, "/images/produtos/large_", 939, 23, true);
#nullable restore
#line 20 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
WriteAttributeValue("", 962, produto.CodigoProduto, 962, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 986, ".jpg", 986, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                                </div>\n                                <div class=\"panel-footer produto-footer\">\n                                    <div class=\"produto-nome\">");
#nullable restore
#line 23 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
                                                         Write(produto.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                    <div><h4><strong>");
#nullable restore
#line 24 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
                                                Write(produto.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></h4></div>
                                    <div class=""text-center"">
                                        <a href=""/"" class=""btn btn-success"">Adicionar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 31 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 35 "C:\Users\felip\Documents\Desenvolvimento Web\Aprendendo C#\WebbAppEcommerce\Views\Pedidos\Carrossel.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    <!-- Controls -->
    <a class=""left carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebbAppEcommerce.Entities.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
