#pragma checksum "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 3 - NetProjects\E1\GymManager.Web\GymManager.Web\Views\Attendance\MemberOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638c7ac549d4b2ad552f1f7261901e4b15eb35fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_MemberOut), @"mvc.1.0.view", @"/Views/Attendance/MemberOut.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"638c7ac549d4b2ad552f1f7261901e4b15eb35fe", @"/Views/Attendance/MemberOut.cshtml")]
    public class Views_Attendance_MemberOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 3 - NetProjects\E1\GymManager.Web\GymManager.Web\Views\Attendance\MemberOut.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""modal fade"" id=""membersModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EjemploModal"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""EjemploModalLabel"">Members</h5>
                </div>
                <div class=""modal-body"">
                    <table>
                        <thead>
                            <tr>
                                <td>Action</td>
                                <td>Member ID</td>
                                <td>Date</td>
                            </tr>
                        </thead>
                        <tbody id=""memebersActions"">
                        </tbody>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Quit</button>        ");
            WriteLiteral("            ");
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>


    <!-- Begin page content -->
    <main class=""flex-shrink-0"">
        <div class=""container"">

            <div class=""mt-5"">

                <p><label for=""IDMember"">Member ID:</label></p>
                <p><input id=""IDMember"" type=""text"" name=""In"" /></p>
                <p><button id=""memberbtn"" class=""btn btn-primary"" type=""button"" data-toggle=""modal"" data-target=""#membersModal"">Quit</button></p>
                <input type=""hidden"" id=""action"" value=""out"" />

            </div>
        </div>
    </main>




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
