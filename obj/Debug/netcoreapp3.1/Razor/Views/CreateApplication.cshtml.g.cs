#pragma checksum "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52018f9bbe4f91c826efd5cfab0322f013474709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateApplication), @"mvc.1.0.view", @"/Views/CreateApplication.cshtml")]
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
#line 4 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52018f9bbe4f91c826efd5cfab0322f013474709", @"/Views/CreateApplication.cshtml")]
    public class Views_CreateApplication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
  
    List<ApplicationType> types = (List<ApplicationType>) ViewBag.types;
    String finance = ViewData["finance"] as String;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52018f9bbe4f91c826efd5cfab0322f0134747093171", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>FPT Portal</title>
    <link rel=""stylesheet"" href=""/create_app/assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/create_appassets/css/Contact-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/create_appassets/css/styles.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52018f9bbe4f91c826efd5cfab0322f0134747094548", async() => {
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
        <h2 style=""height: 150px;""><br>Send an application to Academic Administration dept (Gửi đơn cho Phòng quản lý");
                WriteLiteral(@" đào tạo)<br><br></h2>
        <p><br><strong><em>Lưu ý: V/v gửi đơn/email đến Phòng TC&amp;QLĐT</em></strong><br><strong><em>Phòng TC&amp;QLĐT sẽ trả lời đơn/email của sinh viên trong vòng 48h (trừ đơn xin phúc tra, chuyển cơ sở; không tính ngày nghỉ). Để hạn chế SPAM, Phòng TC&amp;QLĐT sẽ giãn thời gian trả lời đơn/email có tính chất SPAM theo nguyên tắc: Khi sinh viên gửi N đơn/email (N&gt;1) cho cùng một yêu cầu thì thời gian trả lời trong vòng N x 48h. Vì vậy sinh viên cần cân nhắc trước khi gửi đơn/email với cùng một nội dung để nhận được trả lời/giải quyết nhanh nhất theo quy định.</em></strong><br><br></p>
        <p class=""text-center"">Account balance (Số dư tài khoản):&nbsp;<strong>");
#nullable restore
#line 56 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
                                                                          Write(finance);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>&nbsp;VNĐ<br></p>
    </section>
    <main style=""height: 450px;"">
        <section class=""contact-clean"" style=""padding-left: 80px;"">
            <p style=""color:red; display: none"" id=""alertType"">Please choose application type</p>
            <p style=""color:red; display: none"" id=""alertPurpose"">Please provide the purpose</p>
");
#nullable restore
#line 62 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
             using (Html.BeginForm("AddApplication", "Application", FormMethod.Post, new { id = "form", EncType = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"d-inline-block\">\r\n                    <label class=\"d-inline-block\" style=\"width: 200px;\">Application Type:&nbsp;</label>\r\n                    <select id=\"typeSelect\" name=\"tid\">\r\n                        <option value=\"0\"");
                BeginWriteAttribute("selected", " selected=\"", 5266, "\"", 5277, 0);
                EndWriteAttribute();
                WriteLiteral(">Choose Application Type (Chọn loại đơn)</option>\r\n");
#nullable restore
#line 68 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
                         foreach (var type in types)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <option");
                BeginWriteAttribute("value", " value=\"", 5447, "\"", 5463, 1);
#nullable restore
#line 70 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
WriteAttributeValue("", 5455, type.Id, 5455, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 70 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
                                                Write(type.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 71 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""d-lg-flex align-items-lg-start""><label class=""d-flex d-lg-flex"" style=""width: 200px;"">Purpose:&nbsp;</label><textarea name=""purpose"" id=""purpose"" class=""form-control-lg d-lg-flex justify-content-lg-center align-items-lg-start"" rows=""200"" cols=""70"" style=""height: 138px;""></textarea></div>
                <div style=""margin-top: 11px;"">
                    <label style=""width: 200px;"">File Attach:&nbsp;</label><input asp-for=""FileUpload.FormFile"" name=""file"" type=""file"" accept="".xlsx,.pdf,.docx,.doc,.xls,.jpg,.png,.zip"">
                    <div class=""d-lg-flex justify-content-lg-center"" style=""margin-right: 0px;padding-right: 0px;"">
                        <p style=""padding-right: 0px;"">Extension File: ""xlsx"", ""pdf"", ""docx"", ""doc"", ""xls"", ""jpg"", ""png"",""zip"" =&gt; Template&nbsp;<a href=""https://fap.fpt.edu.vn/temp/pdf/AppTemplate.zip"">Click here</a><br></p>
                    </div>
                </div>
               ");
                WriteLiteral(" <div class=\"d-lg-flex justify-content-lg-center\" style=\"margin-top: 45px;\"><button class=\"btn btn-primary\" type=\"button\" onclick=\"onSave()\">Send</button></div>\r\n");
#nullable restore
#line 82 "D:\StudyProject\PRN211\Project\Views\CreateApplication.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </section>
    </main>
    <footer style=""padding-right: 80px;padding-left: 80px;"">
        <p><strong>Mọi góp ý, thắc mắc xin liên hệ:&nbsp;</strong>Phòng dịch vụ sinh viên: Email:&nbsp;<a href=""mailto:dichvusinhvien@fe.edu.vn"">dichvusinhvien@fe.edu.vn</a>. Điện thoại:&nbsp;<strong>(024)7308.13.13</strong><br></p>
        <p class=""d-lg-flex justify-content-lg-center"">© Powered by&nbsp;<a href=""http://fpt.edu.vn/"">FPT University</a>&nbsp;|&nbsp;&nbsp;<a href=""http://cms.fpt.edu.vn/"">CMS</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.fpt.edu.vn/"">library</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.books24x7.com/"">books24x7</a><br></p>
    </footer>
    <script src=""/create_appassets/js/jquery.min.js""></script>
    <script src=""/create_appassets/bootstrap/js/bootstrap.min.js""></script>
    <script>
        function onSave() {
            var e = document.getElementById(""typeSelect"");
            var selected = e.value;
            var text = document.getElementById(""purpose"").value;
     ");
                WriteLiteral(@"       if (selected == 0) {
                document.getElementById(""alertType"").style.display = ""block"";
            }
            else if (text == """") {
                document.getElementById(""alertType"").style.display = ""none"";
                document.getElementById(""alertPurpose"").style.display = ""block"";
            }
            else {
                document.getElementById(""form"").submit();
            }
        }
    </script>
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