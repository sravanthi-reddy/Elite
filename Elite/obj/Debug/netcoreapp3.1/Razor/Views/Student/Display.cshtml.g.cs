#pragma checksum "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d58cd64572239fc4976916a418b6bef146e773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Display), @"mvc.1.0.view", @"/Views/Student/Display.cshtml")]
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
#line 1 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\_ViewImports.cshtml"
using StudentTechProtfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\_ViewImports.cshtml"
using StudentTechProtfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d58cd64572239fc4976916a418b6bef146e773", @"/Views/Student/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bc3e495e1fa607a50d9ee6b899a1f2a96c9bdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentTechProtfolio.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
  
    ViewData["Title"] = "Display";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"display : flex; justify-content: space-between\">\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 262, 1);
#nullable restore
#line 11 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 230, Url.Action("Create", "Student"), 230, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Add New Student\">\r\n        <i class=\'fas fa-plus-circle\' style=\'font-size:24px\'></i>\r\n    </a>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Filter By Skill: ");
#nullable restore
#line 18 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
                        Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input style=\"background: #51830e\" type=\"submit\" value=\"Search\" />\r\n        </p>\r\n");
#nullable restore
#line 21 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 699, "\"", 777, 1);
#nullable restore
#line 29 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 706, Url.Action("Display", "Student", new { sortOrder = ViewBag.SortName }), 706, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
                     if (ViewBag.SortName == "DescName")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\'fas fa-sort-alpha-up\'></i>\r\n");
#nullable restore
#line 34 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\'fas fa-sort-alpha-up-alt\'></i>\r\n");
#nullable restore
#line 38 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>    \r\n\r\n            </th>\r\n            <th>\r\n                Enrolled Date\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1201, "\"", 1279, 1);
#nullable restore
#line 44 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 1208, Url.Action("Display", "Student", new { sortOrder = ViewBag.SortDate }), 1208, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'far fa-calendar-alt\'></i>\r\n                </a>\r\n            </th>\r\n            <th>\r\n                Program\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayNameFor(model => model.Skills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Industry Experience\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 67 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateEnrolled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentProgram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Skills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.IndustryExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2347, "\"", 2420, 1);
#nullable restore
#line 83 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 2354, Url.Action("ViewStudent", "Student", new { studentId = item.ID }), 2354, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View\">\r\n                    <i class=\"fa fa-eye\" style=\"font-size:20px\"></i>\r\n                </a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2615, 1);
#nullable restore
#line 86 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 2556, Url.Action("Edit", "Student", new { studentId = item.ID }), 2556, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">\r\n                    <i class=\'far fa-edit\' style=\'font-size:20px\'></i>\r\n                </a> |\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 2829, "\"", 2897, 1);
#nullable restore
#line 90 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
WriteAttributeValue("", 2836, Url.Action("Delete", "Student", new { studentId = item.ID }), 2836, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete\">\r\n                    <i class=\'far fa-trash-alt\' style=\'font-size:20px\'></i>\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Sravanthi Nuthula\Desktop\TCE MRP\Elite\Elite\Views\Student\Display.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentTechProtfolio.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
