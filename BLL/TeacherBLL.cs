using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TeacherBLL
    {
        public List<TeacherDTO> GetTeacher()
        {
            throw new NotImplementedException();
        }


        TeacherDAO dao = new TeacherDAO();
        public bool AddTeacher(TeacherDTO model)
        {

            Teacher teacher = new Teacher();
            teacher.ID = model.ID;
            teacher.Username = model.Username;
            teacher.Password = model.Password;
            teacher.FirstName = model.FirstName;
            teacher.Surname = model.SurName;
            int ID = dao.AddTeacher(teacher);
            return true;
        }
       
        public TeacherDTO teacherLogin(TeacherDTO model)
        {
            TeacherDTO dto = new TeacherDTO();
            dto = dao.teacherLogin(model);
            return dto;
        }
      
    }
}
