#pragma checksum "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcd6e0689da3d24baafcbd536d13fabca024b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditProfile), @"mvc.1.0.view", @"/Views/EditProfile.cshtml")]
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
#line 4 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcd6e0689da3d24baafcbd536d13fabca024b67", @"/Views/EditProfile.cshtml")]
    public class Views_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
  
    String name = (String)ViewBag.name;
    String phone = (String)ViewBag.phone;
    String dob = (String)ViewBag.dob;
    String born = (String)ViewBag.born;
    Boolean gender = (bool)ViewBag.gender;
    String address = (String)ViewBag.address;
    String id = (String)ViewBag.id;
    String doi = (String)ViewBag.doi;
    String poi = (String)ViewBag.poi;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcd6e0689da3d24baafcbd536d13fabca024b673372", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>FPT Portal</title>
    <link rel=""stylesheet"" href=""/edit_prof/assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/edit_prof/assets/css/Contact-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/edit_prof/assets/css/Features-Clean.css"">
    <link rel=""stylesheet"" href=""/edit_prof/assets/css/styles.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcd6e0689da3d24baafcbd536d13fabca024b674829", async() => {
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
    <section style=""height: 90px;padding-left: 20px;padding-right: 20px;"">
        <h4 class=""d-xl-flex justify-content-xl-center"">Update</h4>
        <p class=""text-center d-xl-flex justify-c");
                WriteLiteral(@"ontent-xl-center""><br><em>Đây là những thông tin quan trọng, được nhà trường dùng để in bằng tốt nghiệp, bảng điểm tốt nghiệp và các chứng chỉ cấp cho sinh viên, ngoài ra còn để báo cáo các Bộ ngành liên quan nên sinh viên cần nhập thông tin đầy đủ, chính xác.</em><br><br></p>
    </section>
    <main style=""border-right-width: 2.4px;height: 710px;padding-right: 50px;padding-left: 50px;"">
");
#nullable restore
#line 66 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
         using (Html.BeginForm("EditProfile", "Profile", FormMethod.Post, new { id = "editform" }))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 70px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Họ và Tên:&nbsp;</label><input name=""fullname"" class=""border rounded border-dark d-inline-block"" type=""text"" style=""height: 50px;width: 800px;""");
                BeginWriteAttribute("value", " value=\"", 4961, "\"", 4974, 1);
#nullable restore
#line 68 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 4969, name, 4969, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 60px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Số điện thoại:&nbsp;</label><input name=""phone"" class=""border rounded border-dark d-inline-block"" type=""text"" style=""height: 50px;width: 800px;""");
                BeginWriteAttribute("value", " value=\"", 5316, "\"", 5330, 1);
#nullable restore
#line 69 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 5324, phone, 5324, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  onkeydown = ""return ValidateNumber(this, event);"" ></div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 60px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Ngày sinh:&nbsp;</label><input name=""dob"" class=""form-control-lg"" type=""date"" style=""margin-right: 100px;""");
                BeginWriteAttribute("value", " value=\"", 5684, "\"", 5696, 1);
#nullable restore
#line 70 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 5692, dob, 5692, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><label style=\"margin-right: 100px;\">Nơi sinh:&nbsp;</label><input name=\"born\" class=\"border rounded border-dark\" type=\"text\" style=\"height: 50px;width: 300px;\"");
                BeginWriteAttribute("value", " value=\"", 5857, "\"", 5870, 1);
#nullable restore
#line 70 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 5865, born, 5865, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n            <div class=\"d-block d-xl-flex align-items-xl-center\" style=\"width: 1200px;height: 70px;\">\r\n                <label class=\"d-inline-block d-xl-flex align-items-xl-center\" style=\"width: 300px;\">Giới tính:&nbsp;</label>\r\n");
#nullable restore
#line 73 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
                 if (gender)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-check"" style=""width: 100px;""><input name=""gender"" class=""form-check-input"" type=""radio"" id=""formCheck-1"" checked=""checked"" value=""male""><label class=""form-check-label"" for=""formCheck-1"">Male</label></div>
                    <div class=""form-check"" style=""width: 100px;""><input name=""gender"" class=""form-check-input"" type=""radio"" id=""formCheck-2"" value=""female""><label class=""form-check-label"" for=""formCheck-2"">Female</label></div>
");
#nullable restore
#line 77 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-check"" style=""width: 100px;""><input name=""gender"" class=""form-check-input"" type=""radio"" id=""formCheck-1"" value=""male""><label class=""form-check-label"" for=""formCheck-1"">Male</label></div>
                    <div class=""form-check"" style=""width: 100px;""><input name=""gender"" class=""form-check-input"" type=""radio"" id=""formCheck-2"" checked=""checked"" value=""female""><label class=""form-check-label"" for=""formCheck-2"">Female</label></div>
");
#nullable restore
#line 82 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 70px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">CMT/CCCD:&nbsp;</label><input name=""id"" class=""border rounded border-dark d-inline-block"" type=""text"" style=""height: 50px;width: 800px;""");
                BeginWriteAttribute("value", " value=\"", 7526, "\"", 7537, 1);
#nullable restore
#line 85 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 7534, id, 7534, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  onkeydown = ""return ValidateNumber(this, event);"" ></div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 70px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Ngày cấp:&nbsp;</label><input name=""doi"" class=""form-control-lg"" type=""date"" style=""margin-right: 100px;""");
                BeginWriteAttribute("value", " value=\"", 7891, "\"", 7903, 1);
#nullable restore
#line 86 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 7899, doi, 7899, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><label style=\"margin-right: 101px;\">Nơi cấp:&nbsp;</label><input name=\"poi\" class=\"border rounded border-dark\" type=\"text\" style=\"height: 50px;width: 300px;\"");
                BeginWriteAttribute("value", " value=\"", 8063, "\"", 8075, 1);
#nullable restore
#line 86 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 8071, poi, 8071, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n            <div class=\"d-block d-xl-flex align-items-xl-center\" style=\"width: 1200px;height: 70px;\">\r\n                <label class=\"d-inline-block d-xl-flex align-items-xl-center\" style=\"width: 300px;\">Dân tộc:&nbsp;</label>\r\n                ");
#nullable restore
#line 89 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
           Write(Html.DropDownList("folks", null, new { @class = "border rounded border-dark form-control-lg", style = "width: 233px;margin-right: 100px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <label style=\"margin-right: 98px;\">Tôn giáo:&nbsp;</label>\r\n                ");
#nullable restore
#line 91 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
           Write(Html.DropDownList("religions", null, new { @class = "border rounded border-dark form-control-lg", style = "width: 300px;margin-right: 100px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    
            </div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 70px;"">
                <label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Địa chỉ theo sổ hộ khẩu:&nbsp;</label>
                    ");
#nullable restore
#line 96 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
               Write(Html.DropDownList("provinces", null, new { @class = "form-control-lg", style = "width: 240px;margin-right: 30px;", onchange= "ReloadCity();" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 97 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
               Write(Html.DropDownList("cities", null, new { @class="form-control-lg", style="width: 250px;margin-right: 30px;", onchange = "ReloadDistrict();" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 98 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
               Write(Html.DropDownList("districts", null, new { @class = "form-control-lg", style = "width: 250px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""d-block d-xl-flex align-items-xl-center"" style=""width: 1200px;height: 70px;""><label class=""d-inline-block d-xl-flex align-items-xl-center"" style=""width: 300px;"">Địa chỉ:&nbsp;</label><input name=""address"" class=""border rounded border-dark d-inline-block"" type=""text"" style=""height: 50px;width: 800px;""");
                BeginWriteAttribute("value", " value=\"", 9799, "\"", 9815, 1);
#nullable restore
#line 100 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
WriteAttributeValue("", 9807, address, 9807, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n            <button class=\"btn btn-outline-primary\" type=\"button\" style=\"margin-left: 839px;\" onclick=\"SubmitForm();\">Save</button>\r\n");
#nullable restore
#line 102 "D:\StudyProject\PRN211\Project\Views\EditProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </main>
    <footer style=""padding-right: 80px;padding-left: 80px;"">
        <p><strong>Mọi góp ý, thắc mắc xin liên hệ:&nbsp;</strong>Phòng dịch vụ sinh viên: Email:&nbsp;<a href=""mailto:dichvusinhvien@fe.edu.vn"">dichvusinhvien@fe.edu.vn</a>. Điện thoại:&nbsp;<strong>(024)7308.13.13</strong><br></p>
        <p class=""d-lg-flex justify-content-lg-center"">© Powered by&nbsp;<a href=""http://fpt.edu.vn/"">FPT University</a>&nbsp;|&nbsp;&nbsp;<a href=""http://cms.fpt.edu.vn/"">CMS</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.fpt.edu.vn/"">library</a>&nbsp;|&nbsp;&nbsp;<a href=""http://library.books24x7.com/"">books24x7</a><br></p>
    </footer>
    <script src=""/edit_prof/assets/js/jquery.min.js""></script>
    <script src=""/edit_prof/assets/bootstrap/js/bootstrap.min.js""></script>
    <script>
        function ValidateNumber(txt, evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 &&
                (charCode < 48 || charCode > 57))
                retu");
                WriteLiteral(@"rn false;
            return true;
        }
        function ReloadCity() {
            $(""#editform"").attr(""action"", ""/Profile/ReloadCity"").submit();
        }
        function ReloadDistrict() {
            $(""#editform"").attr(""action"", ""/Profile/ReloadDistrict"").submit();
        }
        function SubmitForm() {
            $(""#editform"").attr(""action"", ""/Profile/EditProfile"").submit();
        }
        $(document).ready(function () {
            const nextURL = 'http://localhost:53435/Profile/Edit';
            const nextTitle = document.title;
            const nextState = {};

            // This will create a new entry in the browser's history, without reloading
            window.history.pushState(nextState, nextTitle, nextURL);

            // This will replace the current entry in the browser's history, without reloading
            window.history.replaceState(nextState, nextTitle, nextURL);
        });
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
