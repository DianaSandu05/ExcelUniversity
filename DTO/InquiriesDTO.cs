using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InquiriesDTO
    {
        public int ID { get; set; }
        public string InquiryDetails { get; set; }
        public string CourseName { get; set; }
        public string sFirstName { get; set; }
        public string sSurname { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
    }
}
