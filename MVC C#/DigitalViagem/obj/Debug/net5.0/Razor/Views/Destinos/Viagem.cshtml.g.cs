#pragma checksum "C:\Users\David\Desktop\AgenciaDeViagemV2\MVC C#\DigitalViagem\Views\Destinos\Viagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b25a6c6503850303cf8c055d9073e2a7bd3d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinos_Viagem), @"mvc.1.0.view", @"/Views/Destinos/Viagem.cshtml")]
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
#line 1 "C:\Users\David\Desktop\AgenciaDeViagemV2\MVC C#\DigitalViagem\Views\_ViewImports.cshtml"
using DigitalViagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\Desktop\AgenciaDeViagemV2\MVC C#\DigitalViagem\Views\_ViewImports.cshtml"
using DigitalViagem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b25a6c6503850303cf8c055d9073e2a7bd3d5c", @"/Views/Destinos/Viagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8833060e92218f8b9fb24d6e6136db1543e1333", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinos_Viagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\David\Desktop\AgenciaDeViagemV2\MVC C#\DigitalViagem\Views\Destinos\Viagem.cshtml"
  
	ViewData["Title"] = "Destinos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
	<div class=""row"">
		<!--Seção banner esquerdo-->
		<div class=""col-sm-2"">
			<div>
				<div class=""card-deck img-fluid py-2"">
					<img class=""imgbanner2 rounded"" src=""https://i.ibb.co/BB6ZNPw/469591-conjo-de-banner-de-viagem-vetor.png""");
            BeginWriteAttribute("alt", " alt=\"", 308, "\"", 314, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card-deck img-fluid py-2\">\r\n\t\t\t\t\t<img class=\"imgbanner2 rounded\" src=\"https://i.ibb.co/j5WDn8S/469591-conjunto-de-banner-de-viaadsagem-vetor.png\"");
            BeginWriteAttribute("alt", " alt=\"", 493, "\"", 499, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
				</div>
			</div>
		</div>
		<!--Seção contendo os card com zoom-->
		<div class=""container col-md-8"">
			<hr />
			<h4>COMPRE A SUA VIAGEM:</h4>
			<br />
			<div class=""row justify-content-around text-center"">
				<div class=""col-md-4"">
					<div class=""gallery_product"">
						<a href=""#""><img class=""imgbanner img-responsive"" src=""https://www.praiasdenatal.com.br/wp-content/uploads/2014/08/Natal-RN1.jpg""></a>
						<h4 class=""title"">NATAL</h4>
						<h4 class=""textoprecoant"">R$ 484</h4>
						<h4 class=""textopreconov"">R$ 297</h4>
						<div class=""card-body"">
							<button type=""button"" onclick=""mostrar()"" class=""btn btn-primary"" id=""btn-viagem"" value=""Comprar"">Comprar</button>
						</div>
					</div>
				</div>
				<div class=""col-md-4"">
					<div class=""gallery_product"">
						<a href=""#""><img class=""imgbanner img-responsive"" src=""https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/21/4d/46/arraial-d-ajuda-eco-resort.jpg?w=400&h=300&s=1""></a>
						<h4 class=""title""");
            WriteLiteral(@">PORTO SEGURO</h4>
						<h4 class=""textoprecoant"">R$ 729</h4>
						<h4 class=""textopreconov"">R$ 675</h4>
						<div class=""card-body"">
							<button type=""button"" onclick=""mostrar()"" class=""btn btn-primary"" id=""btn-viagem"" value=""Comprar"">Comprar</button>
						</div>
					</div>
				</div>
				<div class=""col-md-4"">
					<div class=""gallery_product"">
						<a href=""#""><img class=""imgbanner img-responsive"" src=""https://www.vidadeturista.com/wp-content/uploads/2009/03/recife-pe.jpg""></a>
						<h4 class=""title"">RECIFE</h4>
						<h4 class=""textoprecoant"">R$ 551</h4>
						<h4 class=""textopreconov"">R$ 351</h4>
						<div class=""card-body"">
							<button type=""button"" onclick=""mostrar()"" class=""btn btn-primary"" id=""btn-viagem"" value=""Comprar"">Comprar</button>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!--Fim da primeira seção de card-->
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
