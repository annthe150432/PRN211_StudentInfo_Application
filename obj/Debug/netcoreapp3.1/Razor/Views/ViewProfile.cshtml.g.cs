#pragma checksum "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012900877f55e830cb8e4d418ad3f0e608e21ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewProfile), @"mvc.1.0.view", @"/Views/ViewProfile.cshtml")]
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
#line 4 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012900877f55e830cb8e4d418ad3f0e608e21ce1", @"/Views/ViewProfile.cshtml")]
    public class Views_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
  
    Student student = ViewData["Student"] as Student;
    Login login = ViewData["Login"] as Login;
    String dob = (String)ViewBag.dob;
    String doi = (String)ViewBag.doi;
    String enrolldate = (String)ViewBag.enrolldate;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012900877f55e830cb8e4d418ad3f0e608e21ce13270", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>FPT Portal</title>
    <link rel=""stylesheet"" href=""/view_prof/assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/view_prof/assets/css/Contact-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/view_prof/assets/css/styles.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012900877f55e830cb8e4d418ad3f0e608e21ce14646", async() => {
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
    <section style=""height: 370px;padding-left: 80px;padding-right: 80px;"">
        <h2 style=""height: 100px;""><br>Student information<br><br></h2>
        <div class=""d-lg-flex""><img width=""1");
                WriteLiteral("50px\" height=\"200px\"");
                BeginWriteAttribute("src", " src=\"", 3933, "\"", 3954, 1);
#nullable restore
#line 59 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
WriteAttributeValue("", 3939, student.Avatar, 3939, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></div>
    </section>
    <main class=""d-lg-flex justify-content-lg-center align-items-lg-start"" style=""border-right-width: 2.4px;height: 950px;"">
        <div class=""col d-inline-block"" style=""width: 370px;margin-left: 32px;border-right-style: dashed;padding-right: 0;padding-left: 0;"">
            <div class=""shadow"">
                <h4 style=""border-bottom-style: solid;border-bottom-color: rgb(33,37,41);"">Profile</h4>
            </div>
            <div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td style=""width: 150px;"">Full name</td>
                                <td>");
#nullable restore
#line 72 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Fullname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Date of Birth</td>\r\n                                <td>");
#nullable restore
#line 76 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(dob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Gender</td>\r\n");
#nullable restore
#line 80 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                                 if ((bool)student.Gender)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>Male</td>\r\n");
#nullable restore
#line 83 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>Female</td>\r\n");
#nullable restore
#line 87 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tr>\r\n                            <tr>\r\n                                <td>ID Card</td>\r\n                                <td>");
#nullable restore
#line 92 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Identity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Address</td>\r\n                                <td>");
#nullable restore
#line 96 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Phone number</td>\r\n                                <td>");
#nullable restore
#line 100 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Phonenumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Email</td>\r\n                                <td>");
#nullable restore
#line 104 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Date of Issue</td>\r\n                                <td>");
#nullable restore
#line 108 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(doi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Place of Issue</td>\r\n                                <td>");
#nullable restore
#line 112 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Poi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div>
                <h4 style=""border-bottom-style: solid;"">Parent</h4>
            </div>
            <div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td style=""width: 130px;"">Name</td>
                                <td>");
#nullable restore
#line 127 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Phone number</td>\r\n                                <td>");
#nullable restore
#line 131 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Address</td>\r\n                                <td>");
#nullable restore
#line 135 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Email</td>\r\n                                <td>");
#nullable restore
#line 139 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Job</td>\r\n                                <td>");
#nullable restore
#line 143 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Place of work</td>\r\n                                <td>");
#nullable restore
#line 147 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ParentPow);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col d-inline-block"" style=""width: 370px;margin-left: 32px;border-right-style: dashed;padding-right: 0;padding-left: 0;"">
            <div class=""shadow"">
                <h4 style=""border-bottom-style: solid;border-bottom-color: rgb(33,37,41);"">Academic</h4>
            </div>
            <div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td style=""width: 150px;"">Roll Number</td>
                                <td>");
#nullable restore
#line 164 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(login.RollNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Old RollNumber</td>\r\n                                <td>");
#nullable restore
#line 168 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.OldId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Member Code</td>\r\n                                <td>");
#nullable restore
#line 172 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.MemberCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Enroll Date</td>\r\n                                <td>");
#nullable restore
#line 176 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(enrolldate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Mode</td>\r\n                                <td>");
#nullable restore
#line 180 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Mode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Status</td>\r\n                                <td>");
#nullable restore
#line 184 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Current Term No</td>\r\n                                <td>");
#nullable restore
#line 188 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.CurrentTerm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Major</td>\r\n                                <td>");
#nullable restore
#line 192 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Major);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Curriculumn</td>\r\n                                <td>");
#nullable restore
#line 196 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Curriculumn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Capstone Project</td>\r\n                                <td>");
#nullable restore
#line 200 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Capstone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div>
                <h4 style=""border-bottom-style: solid;"">Finance</h4>
            </div>
            <div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td style=""width: 130px;"">Term Paid</td>
                                <td>");
#nullable restore
#line 215 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.CurrentTerm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td></td>\r\n                                <td>Account balance (Số dư tài khoản):&nbsp;<span>");
#nullable restore
#line 219 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                                                                                Write(student.CurrentTerm);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>&nbsp;VNĐ</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col d-inline-block"" style=""width: 370px;margin-left: 32px;border-right-style: dashed;padding-right: 0;padding-left: 0;"">
            <div class=""shadow"">
                <h4 style=""border-bottom-style: solid;border-bottom-color: rgb(33,37,41);"">Other</h4>
            </div>
            <div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td style=""width: 200px;"">Ngành cũ</td>
                                <td>");
#nullable restore
#line 236 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.OldMajor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Chuyển ngành</td>\r\n                                <td>");
#nullable restore
#line 240 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ChangeMajorConfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Công nhận SVCQ</td>\r\n                                <td>");
#nullable restore
#line 244 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Svcqconfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Ngày công nhận SVCQ</td>\r\n                                <td>");
#nullable restore
#line 248 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Svcqdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Công nhận SV dự bị</td>\r\n                                <td>");
#nullable restore
#line 252 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.PreparedSvconfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Hạn 7 năm</td>\r\n                                <td>");
#nullable restore
#line 256 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.SevenYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Lớp chính</td>\r\n                                <td>");
#nullable restore
#line 260 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.MainClass);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Loại tài chính</td>\r\n                                <td>");
#nullable restore
#line 264 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.FinancialType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Thôi học</td>\r\n                                <td>");
#nullable restore
#line 268 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.DropConfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Chuyển cơ sở</td>\r\n                                <td>");
#nullable restore
#line 272 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.ChangeCity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ BL/Exchange/kỷ luật</td>\r\n                                <td>");
#nullable restore
#line 276 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.SuspendConfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Công nhận TN</td>\r\n                                <td>");
#nullable restore
#line 280 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Tnconfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>QĐ Rejoin</td>\r\n                                <td>");
#nullable restore
#line 284 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.RejoinConfirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>TT Đến</td>\r\n                                <td>");
#nullable restore
#line 288 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Ttto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Chuyên ngành</td>\r\n                                <td>");
#nullable restore
#line 292 "D:\StudyProject\PRN211\Project\Views\ViewProfile.cshtml"
                               Write(student.Specialize);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </main>
    <footer style=""padding-right: 80px;padding-left: 80px;"">
        <p><strong>Mọi góp ý, thắc mắc xin liên hệ:&nbsp;</strong>Phòng dịch vụ sinh viên: Email:&nbsp;<a href=""mailto:dichvusinhvien@fe.edu.vn"">dichvusinhvien@fe.edu.vn</a>. Điện thoại:&nbsp;<strong>(024)7308.13.13</strong><br></p>
        <p class=""d-lg-flex justify-content-lg-center"">© Powered by&nbsp;<a href=""http://fpt.edu.vn/"">FPT University</a>&nbsp;|&nbsp;&nbsp;<a href=""http://cms.fpt.edu.vn/"">CMS</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.fpt.edu.vn/"">library</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.books24x7.com/"">books24x7</a><br></p>
    </footer>
    <script src=""/view_prof/assets/js/jquery.min.js""></script>
    <script src=""/view_prof/assets/bootstrap/js/bootstrap.min.js""></script>
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
