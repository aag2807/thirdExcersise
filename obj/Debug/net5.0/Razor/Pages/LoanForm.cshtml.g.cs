#pragma checksum "/Users/admin/Documents/net/third-excersise/Pages/LoanForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16866d4447c3b4004f4a1222e9e0b45a2bb4f3e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(third_excersise.Pages.Pages_LoanForm), @"mvc.1.0.razor-page", @"/Pages/LoanForm.cshtml")]
namespace third_excersise.Pages
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
#line 1 "/Users/admin/Documents/net/third-excersise/Pages/_ViewImports.cshtml"
using third_excersise;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16866d4447c3b4004f4a1222e9e0b45a2bb4f3e6", @"/Pages/LoanForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2150853fee69f2b4728c4f28ade5b800a0e1c27c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoanForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-button back-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col form box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""container"" style=""padding:20px;"">
	<div class=""col"">
		<h1 class=""title center"" style=""color:#293241;margin-top:30px"">Calculadora de <br>Prestamos</h1>
		<br>
		<div class=""col"">
			<p>Monto Mensual a pagar: <span id=""monthlyPayment"">$ ");
#nullable restore
#line 13 "/Users/admin/Documents/net/third-excersise/Pages/LoanForm.cshtml"
                                                             Write(Model.monthlyPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\t\t\t<p>Monto total a pagar: <span id=\"totalPayment\">$");
#nullable restore
#line 14 "/Users/admin/Documents/net/third-excersise/Pages/LoanForm.cshtml"
                                                        Write(Model.totalPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\t\t\t<p>Monto de interes a pagar: <span id=\"interestPayment\">$");
#nullable restore
#line 15 "/Users/admin/Documents/net/third-excersise/Pages/LoanForm.cshtml"
                                                                Write(Model.interestPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16866d4447c3b4004f4a1222e9e0b45a2bb4f3e66400", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16866d4447c3b4004f4a1222e9e0b45a2bb4f3e67733", async() => {
                WriteLiteral(@"
		<div class=""input-label-container"">
			<label class=""label"" for=""amount"">Monto del Prestamo</label>
			<input name=""principal"" type=""number"" min=""1"" step=""any"" id=""amount"" />
		</div>

		<div class=""input-label-container"">
			<label for=""interest"" class=""label"">Taza de Interes</label>
			<input name=""interest"" type=""number"" min=""1"" step=""any"" id=""interest"" />
		</div>


		<div class=""input-label-container"">
			<label class=""label"" for=""amountSelect"">Amortizacion en Años</label>
			<input name=""payments"" id=""amountSelect"" name=""amountSelect"" type=""number"" min=""1"" step=""any"" />
				
		</div>

		<div class=""row"" style=""margin-top: 20px;"">
			<button data-purpose=""calculate"" type=""submit"" class=""form-button"">Calcular</button>
		</div>
	");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	
</section>

<style>
	select {
		display: block;
		cursor: pointer;
		height: 40px;
		border: none;
		width: 100%;
		background: #F5F8F9;
		border-radius: 7px;
		text-indent: 10px;
	}

	select:focus {
		outline: none;
		border: 1px solid #353535;
	}

	input {
		width: 100%;
		height: 40px;
		margin-top: 5px;
		margin-bottom: 10px;
		border: none;
		background: #F5F8F9;
		border-radius: 7px;
		text-indent: 10px;
	}

	input:focus {
		outline: none;
		border: 1px solid #353535;
	}

	a {
		transition: all 200ms ease-out;
	}

	a:hover {
		cursor: pointer;
		opacity: 0.7;
	}

	button {
		transition: all 200ms ease-out;
	}

	button:hover {
		cursor: pointer;
		opacity: 0.7;
	}

	label {
		color: #AAADB5 !important;
		width: 100%;
		font-weight: 500;
		font-size: 1.3;
	}

	form {
		padding: 10px;
		border: 1px solid #ccc;
		height: 500px;
		width: 450px;
	}

	.container {
		width: 100%;
		display: flex;
		flex: 1;
		height: 100%;
		color: #0C");
            WriteLiteral(@"0C0C !important;
	}

	.input-label-container {}

	.title {
		margin-top: 10px;
	}

	.col {
		width: 100%;
		height: 100%;
		display: flex;
		flex-direction: column;
	}

	.row {
		width: 100%;
		height: 100%;
		display: flex;
		flex-direction: row;
	}

	.form-button {
		outline: none;
		border: none;
		height: 40px;
		width: 40%;
		display: flex;
		justify-content: center;
		align-items: center;
		background-color: #3728E0;
		margin: auto;
		color: #f1f1f1;
		border-radius: 7px;
	}

	.form-button .center {
		display: flex;
		justify-content: center;
		align-items: center;
	}

	.back-button {
	margin-top: 75px;
    margin-right: auto;
    margin-left: 0;
	}
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanFormModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoanFormModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoanFormModel>)PageContext?.ViewData;
        public LoanFormModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591