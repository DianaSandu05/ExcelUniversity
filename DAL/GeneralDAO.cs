using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class GeneralDAO : dbContext
    {
        public List<CoursesDTO> GetEnrolledCourses()
        {
            List<CoursesDTO> dtolist = new List<CoursesDTO>();
            var list = (from c in db.Courses.Where(x => x.isEnrolled == true)
                        join s in db.Students on c.StudentID equals s.ID
                        join t in db.Teachers on c.TeacherID equals t.ID
                        join aS in db.Assignments on c.AssignmentID equals aS.ID
                        select new
                        {
                            courseID = c.ID,
                            CourseName = c.CourseName,
                            startDate = c.StartDate,
                            endDate = c.EndDate,
                            weeklySchedule = c.WeeklySchedule,
                            noHours = c.NoHours,
                            semester = c.Semester
                        }
                        ).OrderByDescending(x => x.CourseName).Take(4).ToList();
            foreach (var item in list)
            {
                CoursesDTO dto = new CoursesDTO();
                dto.CourseID = item.courseID;
                dto.CourseName = item.CourseName;
                dto.StartDate = item.startDate;
                dto.EndDate = item.endDate;
                dto.WeeklySchedule = Convert.ToDateTime(item.weeklySchedule);
                dto.NoHours = Convert.ToInt32(item.noHours);
                dto.Semester = Convert.ToInt32(item.semester);
            }
            return dtolist;
        }

       
    }
}
