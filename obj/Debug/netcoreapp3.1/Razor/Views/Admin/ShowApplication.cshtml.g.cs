#pragma checksum "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38467eb1c6bc5548bb07d59c768f546ab6430708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowApplication), @"mvc.1.0.view", @"/Views/Admin/ShowApplication.cshtml")]
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
#line 4 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38467eb1c6bc5548bb07d59c768f546ab6430708", @"/Views/Admin/ShowApplication.cshtml")]
    public class Views_Admin_ShowApplication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
  
    List<Application> appls = (List<Application>)ViewBag.appls;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38467eb1c6bc5548bb07d59c768f546ab64307083137", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>FPT Portal</title>
    <link rel=""stylesheet"" href=""/under_construction/assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/under_construction/assets/fonts/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""/under_construction/assets/css/Contact-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/under_construction/assets/css/Features-Clean.css"">
    <link rel=""stylesheet"" href=""/under_construction/assets/css/styles.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38467eb1c6bc5548bb07d59c768f546ab64307084724", async() => {
                WriteLiteral(@"
    <h1 style=""padding-left: 100px;""><br>FPT University Academic Portal<br><br></h1>
    <nav class=""navbar navbar-light navbar-expand-md border rounded shadow"" style=""background: rgb(96,242,252);"">
        <div class=""container-fluid"">
            <a class=""navbar-brand"" href=""#"">Home</a><button data-toggle=""collapse"" class=""navbar-toggler"" data-target=""#navcol-1""><span class=""sr-only"">Toggle navigation</span><span class=""navbar-toggler-icon""></span></button>
            <div class=""collapse navbar-collapse"" id=""navcol-1"">
                <ul class=""navbar-nav d-inline-flex float-right"">
                    <li class=""nav-item shadow float-right""></li>
                    <li class=""nav-item""></li>
                    <li class=""nav-item""></li>
                </ul>
                <ul class=""navbar-nav"">
                    <li class=""nav-item""></li>
                    <li class=""nav-item""></li>
                    <li class=""nav-item""></li>
                    <li class=""nav-item dropdown""");
                WriteLiteral(@">
                        <a class=""dropdown-toggle nav-link"" aria-expanded=""false"" data-toggle=""dropdown"" href=""#"">Information Access</a>
                        <div class=""dropdown-menu""><a class=""dropdown-item"" href=""/Home/Construction"">Weekly Timetable</a><a class=""dropdown-item"" href=""/Home/Construction"">Exam Schedule</a></div>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""dropdown-toggle nav-link"" aria-expanded=""false"" data-toggle=""dropdown"" href=""#"">Registration/Application</a>
                        <div class=""dropdown-menu""><a class=""dropdown-item"" href=""/Home/Construction"">Suspend semester</a><a class=""dropdown-item"" href=""/Home/Construction"">Register Course</a><a class=""dropdown-item"" href=""/Application/Create"">Send Application</a><a class=""dropdown-item"" href=""/Application/List"">View Application</a></div>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""dropdow");
                WriteLiteral(@"n-toggle nav-link"" aria-expanded=""false"" data-toggle=""dropdown"" href=""#"">Others</a>
                        <div class=""dropdown-menu""><a class=""dropdown-item"" href=""/Profile/Views"">Student Profile</a><a class=""dropdown-item"" href=""/Profile/Edit"">Update Profile</a><a class=""dropdown-item"" href=""/Home/Construction"">Certificate</a></div>
                    </li>
                </ul>
            </div>
            <section style=""width: 234px;height: 52px;padding-top: 13px;""><a class=""text-monospace shadow d-inline-block"" href=""/Profile/Views"" style=""width: 76px;"">Profile</a><a class=""text-monospace shadow d-inline-block"" href=""#"" style=""width: 76px;"">Campus</a><a class=""text-monospace shadow d-inline-block"" href=""/Home/Logout"" style=""margin-left: 0px;width: 76px;"">Logout</a></section>
        </div>
    </nav>
    <main style=""height: 500px;border-left-style: solid;"">
        <h3 style=""padding-left: 76px;padding-top: 52px;"">Thông tin xử lý đơn từ</h3>
        <div class=""table-responsive"" style=");
                WriteLiteral(@"""padding-left: 50px;padding-right: 50px;"">
            <table class=""table table-striped table-hover table-sm"">
                <thead class=""text-primary"" style=""border-bottom-style: solid;border-bottom-color: var(--blue);"">
                    <tr>
                        <th style=""width: 100.6px;"">Student</th>
                        <th style=""width: 598.6px;"">Purpose</th>
                        <th style=""width: 183.2px;"">Created Date</th>
                        <th style=""width: 116px;"">Note</th>
                        <th style=""width: 70.8px;"">File</th>
                        <th class=""text-center"" style=""width: 162.4px;"">Status</th>
                        <th>Updated Date</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 70 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                     if (appls != null)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                         foreach (var app in appls)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 76 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                       Write(app.StudentNavigation.MemberCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                       Write(app.Purpose);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                        Write((DateTime)app.CreatedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(".ToString(\"dd/MM/yyyy\")</td>\r\n                        <td><input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 5155, "\"", 5172, 1);
#nullable restore
#line 79 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 5163, app.Note, 5163, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"border:none\"");
                BeginWriteAttribute("id", " id=\"", 5193, "\"", 5210, 2);
                WriteAttributeValue("", 5198, "note-", 5198, 5, true);
#nullable restore
#line 79 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 5203, app.Id, 5203, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td>\r\n");
#nullable restore
#line 81 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                             if (app.File != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 5368, "\"", 5410, 2);
                WriteAttributeValue("", 5375, "/Application/Download?appid=", 5375, 28, true);
#nullable restore
#line 83 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 5403, app.Id, 5403, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">download</a>\r\n");
#nullable restore
#line 84 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n\r\n");
#nullable restore
#line 87 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                         if (app.Status == 2)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <td class=""text-center text-success"">
                                <div class=""dropdown"">
                                    <button class=""btn btn-outline-primary dropdown-toggle text-left"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Dropdown </button>
                                    <div class=""dropdown-menu""><a class=""dropdown-item text-center text-success""");
                BeginWriteAttribute("href", " href=\"", 5980, "\"", 5987, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5988, "\"", 6099, 9);
                WriteAttributeValue("", 5998, "this.href", 5998, 9, true);
                WriteAttributeValue(" ", 6007, "=", 6008, 2, true);
                WriteAttributeValue(" ", 6009, "\'/Admin/Decide?id=", 6010, 19, true);
#nullable restore
#line 92 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 6028, app.Id, 6028, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6035, "&status=1&note=\'", 6035, 16, true);
                WriteAttributeValue(" ", 6051, "+", 6052, 2, true);
                WriteAttributeValue(" ", 6053, "document.getElementById(\'note-", 6054, 31, true);
#nullable restore
#line 92 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 6084, app.Id, 6084, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6091, "\').value", 6091, 8, true);
                EndWriteAttribute();
                WriteLiteral("><strong>ACCEPT</strong></a><a class=\"dropdown-item text-center text-danger\"");
                BeginWriteAttribute("href", " href=\"", 6176, "\"", 6183, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 6184, "\"", 6295, 9);
                WriteAttributeValue("", 6194, "this.href", 6194, 9, true);
                WriteAttributeValue(" ", 6203, "=", 6204, 2, true);
                WriteAttributeValue(" ", 6205, "\'/Admin/Decide?id=", 6206, 19, true);
#nullable restore
#line 92 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 6224, app.Id, 6224, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6231, "&status=0&note=\'", 6231, 16, true);
                WriteAttributeValue(" ", 6247, "+", 6248, 2, true);
                WriteAttributeValue(" ", 6249, "document.getElementById(\'note-", 6250, 31, true);
#nullable restore
#line 92 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
WriteAttributeValue("", 6280, app.Id, 6280, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6287, "\').value", 6287, 8, true);
                EndWriteAttribute();
                WriteLiteral("><strong>REJECT</strong></a></div>\r\n                                </div>\r\n                            </td>\r\n");
#nullable restore
#line 95 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                        }
                        else if (app.Status == 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td class=\"text-center text-success\"><strong>APPROVE</strong></td>\r\n");
#nullable restore
#line 99 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td class=\"text-center text-danger\"><strong>REJECT</strong></td>\r\n");
#nullable restore
#line 103 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>");
#nullable restore
#line 104 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                       Write(app.UpdateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 106 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\StudyProject\PRN211\Project\Views\Admin\ShowApplication.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
            </table>
        </div>
    </main>
    <footer style=""padding-right: 80px;padding-left: 80px;"">
        <p><strong>Mọi góp ý, thắc mắc xin liên hệ:&nbsp;</strong>Phòng dịch vụ sinh viên: Email:&nbsp;<a href=""mailto:dichvusinhvien@fe.edu.vn"">dichvusinhvien@fe.edu.vn</a>. Điện thoại:&nbsp;<strong>(024)7308.13.13</strong><br></p>
        <p class=""d-lg-flex justify-content-lg-center"">© Powered by&nbsp;<a href=""http://fpt.edu.vn/"">FPT University</a>&nbsp;|&nbsp;&nbsp;<a href=""http://cms.fpt.edu.vn/"">CMS</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.fpt.edu.vn/"">library</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.books24x7.com/"">books24x7</a><br></p>
    </footer>
    <script src=""/under_construction/assets/js/jquery.min.js""></script>
    <script src=""/under_construction/assets/bootstrap/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
