using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CoursesDAO : dbContext
    {
        public int AddCourse(Course course)
        {

            try
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return course.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
