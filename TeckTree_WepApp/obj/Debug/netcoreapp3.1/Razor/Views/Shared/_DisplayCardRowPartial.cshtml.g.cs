#pragma checksum "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db29034fc65c1cac09347d6d15629af65bcde247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayCardRowPartial), @"mvc.1.0.view", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
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
#line 1 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\_ViewImports.cshtml"
using TeckTree_WepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\_ViewImports.cshtml"
using TeckTree_WepApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\_ViewImports.cshtml"
using TeckTree_WepApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\_ViewImports.cshtml"
using TeckTree_WepApp.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db29034fc65c1cac09347d6d15629af65bcde247", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6530875a502e9b74aba4df07136aa5024e74653", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__DisplayCardRowPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n");
#nullable restore
#line 5 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
         foreach (Category item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 mt-3\">\r\n                <a href=\"#\" class=\"RegisterLink text-dark\" data-categoryId=\"");
#nullable restore
#line 8 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"card\">\r\n                        <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 359, "\"", 387, 1);
#nullable restore
#line 10 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 365, item.ThumbnaImagePath, 365, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 388, "\"", 405, 1);
#nullable restore
#line 10 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 394, item.Title, 394, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 12 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 13 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 18 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 20 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Views\Shared\_DisplayCardRowPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591