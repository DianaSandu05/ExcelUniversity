using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace DTO
{
    public class CoursesDTO
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime WeeklySchedule { get; set; }
        public int NoHours { get; set; }
        public int Semester { get; set; }
        public int TeacherID { get; set; }
        public int StudentID { get; set; }
        public string searchText { get; set; }
        public string teacherFirstName { get; set; }
        public string teacherSurname { get; set; }
        public string teacherEmail { get; set; }
        public List<CoursesDTO> GetSchedules { get; set; }
        public List<CoursesDTO> GetCourses { get; set; }
        public List<CoursesDTO> GetSearchText { get; set; }
        
    }
    public static class CourseStatic
    {
        public static int ID { get; set; }
        public static string CourseName { get; set; }
        public static DateTime StartDate { get; set; }
        public static DateTime EndDate { get; set; }
        public static DateTime WeeklySchedule { get; set; }
        public static int NoHours { get; set; }
        public static int Semester { get; set; }
        public static int ScheduleID { get; set; }

    }
}
