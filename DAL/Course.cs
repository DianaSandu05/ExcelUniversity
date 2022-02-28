//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.Inquiries = new HashSet<Inquiry>();
            this.Assignments = new HashSet<Assignment>();
            this.Enrollments = new HashSet<Enrollment>();
        }
    
        public int ID { get; set; }
        public string CourseName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<System.DateTime> WeeklySchedule { get; set; }
        public Nullable<int> NoHours { get; set; }
        public Nullable<int> Semester { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> AssignmentID { get; set; }
        public int LastUpdateUserID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isEnrolled { get; set; }
    
        public virtual Admin_T Admin_T { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Inquiry> Inquiries { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}