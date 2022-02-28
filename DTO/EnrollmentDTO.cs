using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EnrollmentDTO
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int AssignmentID { get; set; }
        public DateTime AssignmentDeadline { get; set; }
        public DateTime SubmissionDate { get; set; }
       public string CourseName { get; set; }
       public int TeacherID { get; set; }
        public string sFirstName { get; set; }
        public string sSurname { get; set; }
        public DateTime WeeklySchedule { get; set; }
        public List<EnrollmentDTO> GetEnrollment { get; set; }
        public List<EnrollmentDTO> GetSchedules { get; set; }
    }
}
