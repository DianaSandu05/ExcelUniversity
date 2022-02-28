using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EnrollmentBLL
    {
        EnrollmentDAO dao = new EnrollmentDAO();
        public bool AddEnrollment(EnrollmentDTO model)
        {
    
            Enrollment enrollment = new Enrollment();
            enrollment.EnrollmentID = model.ID;
            var find = dbContext.db.Courses.Where(x => x.ID == model.CourseID && x.AssignmentID == model.AssignmentID);
            enrollment.CourseID = model.CourseID;
            var find1 = dbContext.db.Students.Where(x => x.ID == model.StudentID);
            enrollment.StudentID = model.StudentID;
           
            //   enrollment.TeacherID = TeacherStatic.ID;

            int ID = dao.AddEnrollment(enrollment);
            return true;

        }
        public List<EnrollmentDTO> GetEnrollment()
        {
            return dao.GetEnrollment();
        }
        public List<EnrollmentDTO> GetSchedules()
        {

            return dao.GetSchedules();

        }
        public List<EnrollmentDTO> GetEnrolledCourses()
        {

            return dao.GetEnrolledCourses();

        }
    }
}
