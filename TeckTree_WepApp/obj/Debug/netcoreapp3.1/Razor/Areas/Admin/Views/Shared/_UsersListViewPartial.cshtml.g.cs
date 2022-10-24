#pragma checksum "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1dc972f4461a4c13b2866a27a20dc9b34c3348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
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
#line 1 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeckTree_WepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeckTree_WepApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
using TeckTree_WepApp.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1dc972f4461a4c13b2866a27a20dc9b34c3348", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66442c9b9cc9da6f817407db11fba33e0e5828e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeckTree_WepApp.Areas.Admin.Models.UsersCategoryListModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
         if (Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:center\">\r\n");
#nullable restore
#line 18 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                         if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 742, "\"", 758, 1);
#nullable restore
#line 20 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 750, user.Id, 750, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 963, "\"", 979, 1);
#nullable restore
#line 24 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 971, user.Id, 971, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 27 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\projects\Full Project\TeckTree_WepApp\TeckTree_WepApp\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeckTree_WepApp.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
