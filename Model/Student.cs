using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Student
    {
        public Student()
        {
            Applications = new HashSet<Application>();
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Gender { get; set; }
        public string Identity { get; set; }
        public string Address { get; set; }
        public string RealAddress { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public DateTime? Doi { get; set; }
        public string Poi { get; set; }
        public string ParentName { get; set; }
        public string ParentPhone { get; set; }
        public string ParentAddress { get; set; }
        public string ParentEmail { get; set; }
        public string ParentJob { get; set; }
        public string ParentPow { get; set; }
        public string OldId { get; set; }
        public string MemberCode { get; set; }
        public DateTime? EnrollDate { get; set; }
        public string Mode { get; set; }
        public string Status { get; set; }
        public string CurrentTerm { get; set; }
        public string Major { get; set; }
        public string Curriculumn { get; set; }
        public string Capstone { get; set; }
        public string OldMajor { get; set; }
        public string ChangeMajorConfirm { get; set; }
        public string Svcqconfirm { get; set; }
        public DateTime? Svcqdate { get; set; }
        public string PreparedSvconfirm { get; set; }
        public string SevenYear { get; set; }
        public string MainClass { get; set; }
        public string FinancialType { get; set; }
        public string DropConfirm { get; set; }
        public string ChangeCity { get; set; }
        public string SuspendConfirm { get; set; }
        public string Tnconfirm { get; set; }
        public string RejoinConfirm { get; set; }
        public string Ttto { get; set; }
        public string Specialize { get; set; }
        public int? Folk { get; set; }
        public int? Religion { get; set; }
        public string Born { get; set; }
        public string Financial { get; set; }
        public string Avatar { get; set; }

        public virtual Folk FolkNavigation { get; set; }
        public virtual Religion ReligionNavigation { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
