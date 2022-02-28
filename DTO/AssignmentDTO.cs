using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssignmentDTO
    {
        public int ID { get; set; }
        public DateTime AssignmentDeadline { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string FilePath { get; set; }
        public string MarkingCriteria { get; set; }
        public string AssignmentStructure { get; set; }
        public string Feedback { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int StudentID { get; set; }
        public int EnrollmentID { get; set; }
      

    }
}
