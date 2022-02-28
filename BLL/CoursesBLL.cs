using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CoursesBLL
    {
        CoursesDAO coursesDao = new CoursesDAO();    
        public bool AddCourse(CoursesDTO courseModel)
        {
           
            Course course = new Course();
            course.ID = courseModel.CourseID;
            course.CourseName = courseModel.CourseName;
            course.StartDate = courseModel.StartDate;
            course.EndDate = courseModel.EndDate;
            course.WeeklySchedule = DateTime.Now;
            course.NoHours = courseModel.NoHours;
            course.LastUpdateUserID = AdminStatic.ID;
            int ID = coursesDao.AddCourse(course);
            return true;
        }

     
       
    }
}
