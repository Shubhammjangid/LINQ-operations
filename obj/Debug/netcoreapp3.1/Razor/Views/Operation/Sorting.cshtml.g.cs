#pragma checksum "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f0da60c0fe7d8aa422229afa715be879a9f709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operation_Sorting), @"mvc.1.0.view", @"/Views/Operation/Sorting.cshtml")]
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
#line 1 "C:\Users\harsh jangid\Desktop\LINQ\Views\_ViewImports.cshtml"
using LINQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harsh jangid\Desktop\LINQ\Views\_ViewImports.cshtml"
using LINQ.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f0da60c0fe7d8aa422229afa715be879a9f709", @"/Views/Operation/Sorting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5987313f22685bf2c625b20f299c93f7ae081f9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Operation_Sorting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LINQ.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
  
    ViewData["Title"] = "Sorting";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sorting</h1>\r\n\r\n");
            WriteLiteral("    <a class=\"dropdown-toggle\" data-toggle=\"dropdown\" href=\"#\">\r\n        Storage\r\n        <span class=\"caret\"></span>\r\n    </a>\r\n    <ul class=\"dropdown-menu\" role=\"menu\">\r\n        <li>");
#nullable restore
#line 15 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
       Write(Html.ActionLink("Age", "AgeSorting", "Operation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 16 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
       Write(Html.ActionLink("Department", "IdSorting", "Operation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 17 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
       Write(Html.ActionLink("Name", "Sorting", "Operation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.EmployeeID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.EmployeeID  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\harsh jangid\Desktop\LINQ\Views\Operation\Sorting.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LINQ.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
