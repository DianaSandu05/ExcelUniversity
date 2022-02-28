using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DAL
{
    public class EnrollmentDAO:dbContext 
    {

        public int AddEnrollment(Enrollment enrollment)
            {

                try
                {
                    db.Enrollments.Add(enrollment);
                    db.SaveChanges();
                    return enrollment.EnrollmentID;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        public List<EnrollmentDTO> GetSchedules()
        {
            Student student = new Student();
            student = db.Students.FirstOrDefault(x => x.ID == StudentStatic.ID);
            var list = (from e in db.Enrollments.Where(x => x.StudentID == student.ID)
                        join s in db.Students on e.StudentID equals s.ID
                        join c in db.Courses on e.CourseID equals c.ID
                        select new
                        {
                            ID = e.CourseID,
                            courseID = c.ID,
                            CourseName = c.CourseName,
                            studentID = s.ID,
                            studentFName = s.FirstName,
                            studentLName = s.Surname,
                            //      teacherID = t.ID,
                            //      teacherFName = t.FirstName,
                            //    teacherSurname = t.Surname,
                            //  teacherEmail = t.Email
                        }
                             ).Take(4).ToList();

            List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
            foreach (var item in list)
            {
                EnrollmentDTO eDto = new EnrollmentDTO();
                eDto.ID = item.ID;
                eDto.CourseID = item.courseID;
                eDto.StudentID = item.studentID;
                eDto.CourseName = item.CourseName;
                eDto.sFirstName = item.studentFName;
                eDto.sSurname = item.studentLName;

                //         dto.TeacherID = item.teacherID;
                elist.Add(eDto);

            }
            return elist;

        }
        public List<EnrollmentDTO> GetEnrollment()
            {
            var list = (from e in db.Enrollments.Where(x => x.EnrollmentID >0)
                        join s in db.Students on e.StudentID equals s.ID
                        join c in db.Courses on e.CourseID equals c.ID
                        select new
                        {
                            ID = e.CourseID,
                            courseID = c.ID,
                            CourseName = c.CourseName,
                            studentID = s.ID,
                            studentFName = s.FirstName,
                            studentLName = s.Surname,
                      //      teacherID = t.ID,
                      //      teacherFName = t.FirstName,
                        //    teacherSurname = t.Surname,
                          //  teacherEmail = t.Email
                        }
                             ).Take(4).ToList();
                List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
                foreach (var item in list)
                {
                    EnrollmentDTO eDto = new EnrollmentDTO();
                    eDto.ID = item.ID;
                    eDto.CourseID = item.courseID;
                    eDto.StudentID = item.studentID;
                    eDto.CourseName = item.CourseName;
                    eDto.sFirstName = item.studentFName;
                    eDto.sSurname = item.studentLName;
                    
           //         dto.TeacherID = item.teacherID;
                    elist.Add(eDto);
                 }
                return elist;
            }
        //the below method is for calendar. Functionallity for teacher is not done as it's part of other coleague's implementation.
        public List<EnrollmentDTO> GetEnrolledCourses()
        {
            Student student = new Student();
            student = db.Students.FirstOrDefault(x => x.ID == StudentStatic.ID);
            // enrollment.StudentID = StudentStatic.ID;

            var list = (from e in db.Enrollments.Where(x => x.StudentID == student.ID)
                        join s in db.Students on e.StudentID equals s.ID
                        join c in db.Courses on e.CourseID equals c.ID
                        join a in db.Assignments on e.AssignmentsID equals a.ID
                        select new
                        {              
                            courseID = c.ID,
                            CourseName = c.CourseName,
                            studentID = s.ID,
                            studentFName = s.FirstName,
                            studentLName = s.Surname,
                            assignmentId = c.AssignmentID,
                            assignmentDeadline = a.AssignmentDeadline,
                            assignmentSubmission = a.SubmissionDate
                            //     teacherID = t.ID,

                        }
                             ).Take(10).ToList();

            List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
            foreach (var item in list)
            {
                EnrollmentDTO eDto = new EnrollmentDTO();  
                eDto.CourseID = item.courseID;
                eDto.CourseName = item.CourseName;
                eDto.StudentID = item.studentID;
                eDto.sFirstName = item.studentFName;
                eDto.sSurname = item.studentLName;
                eDto.AssignmentDeadline = item.assignmentDeadline;
                eDto.SubmissionDate = item.assignmentSubmission;
                // eDto.TeacherID = item.teacherID; // part of other colleague implementation
                elist.Add(eDto);
            }

            return elist;
        }
      
    }
}
    


