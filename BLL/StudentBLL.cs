using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAO dao = new StudentDAO();
        public StudentsDTO studentLogin(StudentsDTO model)
        {
            StudentsDTO dto = new StudentsDTO();
            dto = dao.studentLogin(model);
            return dto;
        }
        public List<StudentsDTO> getStudent()
        {
            return dao.getStudent();
        }
        public bool addStudent(StudentsDTO model)
        {
            Student student = new Student();
            student.ID = model.ID;
            student.Username = model.Username;
            student.FirstName = model.FirstName;
            student.Surname = model.SurName;
            student.Email = model.Email;
            student.DoB = model.DoB;
            student.FirstName = model.Feedback;
            student.Results = model.Results;
            student.LastUpdateUserID = AdminStatic.ID;
            // add ImagePath and filePath
            int ID = dao.addStudent(student);
            return true;
        }
    }
}
