using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AssignmentsDAO : dbContext
    {
        public int AddAssignment(Assignment assignment)
        {
            try
            {
                db.Assignments.Add(assignment);
                db.SaveChanges();
                return assignment.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AssignmentDTO> GetAssignments()
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
                            assignmentID = a.ID,
                            AssignmentDeadline = a.AssignmentDeadline,
                            SubmissionDate = a.SubmissionDate,
                            studentID = s.ID,
                            studentFName = s.FirstName,
                            studentSurname = s.Surname
                        }
                             ).OrderByDescending(x => x.CourseName).ToList();
           
            
            List<AssignmentDTO> asgnlist = new List<AssignmentDTO>();
           
            foreach (var item in list)
            {
                AssignmentDTO dto = new AssignmentDTO();
                dto.CourseID = item.courseID;
                dto.CourseName = item.CourseName;
                dto.AssignmentDeadline = item.AssignmentDeadline;
                dto.SubmissionDate = item.SubmissionDate;
                dto.StudentID = item.studentID;
                asgnlist.Add(dto);
               
            }
            return asgnlist;
        }
    }
}
