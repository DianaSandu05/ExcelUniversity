using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class AssignmentsBLL
    {
        AssignmentsDAO dao = new AssignmentsDAO();
       
        public bool AddAssignment_Record(AssignmentDTO model)
        {

            Assignment assignment = new Assignment();
            assignment.ID = model.ID;
            assignment.CourseID = CourseStatic.ID;
            
            assignment.AssignmentDeadline = model.AssignmentDeadline;
            assignment.SubmissionDate = model.SubmissionDate;
            int ID = dao.AddAssignment(assignment);
            return true;
        }
        public List<AssignmentDTO> GetAssignments()
        {

            return dao.GetAssignments();

        }
    }
}
