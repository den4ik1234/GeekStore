#pragma checksum "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4a179a01916182b2c2709da7a2ba6357299c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_SeeCart), @"mvc.1.0.view", @"/Views/Product/SeeCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/SeeCart.cshtml", typeof(AspNetCore.Views_Product_SeeCart))]
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
#line 1 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore;

#line default
#line hidden
#line 2 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Data.Tables;

#line default
#line hidden
#line 4 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using GeekStore.Data.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4a179a01916182b2c2709da7a2ba6357299c1c", @"/Views/Product/SeeCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e88e7114a52b1816d86d77c80d4c57a475ff67", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_SeeCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: inherit;color:inherit; position: inherit; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartCheckout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
  
    ViewData["Title"] = "SeeCart";

#line default
#line hidden
            BeginContext(45, 339, true);
            WriteLiteral(@"
<div class=""container con"">
    <div class=""card shopping-cart"">
        <div class=""card-header bg-dark text-light"">
            <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
            Shopping cart
            <div class=""clearfix""></div>
        </div>
        <div class=""card-body"">
            <!-- PRODUCT -->
");
            EndContext();
#line 15 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
              
            int i =0;
                    double total = 0;
                if(Model.Products.Count==0)
                {

#line default
#line hidden
            BeginContext(526, 50, true);
            WriteLiteral("                <h2>In your cart 0 products</h2>\r\n");
            EndContext();
#line 21 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                }
                else
                {

                    foreach (Product product in Model.Products)
                    {
                    i=i+1;
                    if(product.Discount!=0){
                        total += product.Price - (product.Price / 100 * product.Discount);
                    }
                    else{
                        total += product.Price;
                    }

#line default
#line hidden
            BeginContext(1014, 159, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-12 col-sm-12 col-md-2 text-center\">\r\n                        <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1173, "\"", 1193, 1);
#line 36 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
WriteAttributeValue("", 1179, product.Image, 1179, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 215, true);
            WriteLiteral(" alt=\"prewiew\" width=\"120\" height=\"80\">\r\n                    </div>\r\n                    <div class=\"col-12 text-sm-center col-sm-12 text-md-left col-md-6\">\r\n                        <h4 class=\"product-name\"><strong>");
            EndContext();
            BeginContext(1410, 12, false);
#line 39 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                                                    Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 81, true);
            WriteLiteral("</strong></h4>\r\n                        <h4>\r\n                            <small>");
            EndContext();
            BeginContext(1504, 19, false);
#line 41 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                              Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 305, true);
            WriteLiteral(@"</small>
                        </h4>
                    </div>
                    <div class=""col-12 col-sm-12 text-sm-center col-md-4 text-md-right row"">
                        <div class=""col-3 col-sm-3 col-md-6 text-md-right"" style=""padding-top: 5px"">
                            <h6><strong>");
            EndContext();
            BeginContext(1829, 13, false);
#line 46 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                                   Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 165, true);
            WriteLiteral("</strong></h6>\r\n                        </div>\r\n                        <div class=\"col-4 col-sm-4 col-md-4\">\r\n                            <div class=\"quantity\">\r\n\r\n");
            EndContext();
            BeginContext(2172, 236, true);
            WriteLiteral("                                <label>Count: <b>1</b></label>\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-2 col-sm-2 col-md-2 text-right\">\r\n                            ");
            EndContext();
            BeginContext(2408, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4a179a01916182b2c2709da7a2ba6357299c1c9765", async() => {
                BeginContext(2575, 252, true);
                WriteLiteral("\r\n                                <button  type=\"button\" class=\"btn btn-outline-danger btn-xs\">\r\n                                    <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                                </button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                                                                                      WriteLiteral(Model.ProductCarts[i-1].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2831, 108, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <hr>\r\n");
            EndContext();
#line 67 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                  
                    }
                }
            
            

#line default
#line hidden
            BeginContext(3030, 116, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n\r\n            <div class=\"pull-right\" style=\"margin: 10px\">\r\n");
            EndContext();
#line 78 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                 if(Model.Products.Count!=0){

#line default
#line hidden
            BeginContext(3193, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3209, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4a179a01916182b2c2709da7a2ba6357299c1c13550", async() => {
                BeginContext(3327, 8, true);
                WriteLiteral("Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                                                                        WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3339, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                }

#line default
#line hidden
            BeginContext(3360, 98, true);
            WriteLiteral("                <div class=\"pull-right\" style=\"margin: 5px\">\r\n                    Total price: <b>");
            EndContext();
            BeginContext(3459, 5, false);
#line 82 "C:\Users\Dan\source\repos\GeekStore\GeekStore\Views\Product\SeeCart.cshtml"
                               Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(3464, 84, true);
            WriteLiteral("</b>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
