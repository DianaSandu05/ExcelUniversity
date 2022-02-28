using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TeacherDAO :dbContext 
    {


        public List<TeacherDTO> getTeacher()
        {
            TeacherDTO model = new TeacherDTO();
            List<Teacher> list = db.Teachers.Where(x => x.Username == model.Username).OrderBy(x => x.Username).ToList();
            List<TeacherDTO> studentslist = new List<TeacherDTO>();
            foreach (var item in list)
            {
                TeacherDTO dto = new TeacherDTO();
                dto.ID = item.ID;
                dto.FirstName = item.FirstName;
                dto.SurName = item.Surname;
                dto.Email = item.Email;
                studentslist.Add(dto);
            }
            return studentslist;
        }

        public TeacherDTO teacherLogin(TeacherDTO model)
        {
            TeacherDTO dto = new TeacherDTO();
            Teacher teacher = new Teacher();

            if (teacher != null)
            {
                teacher = db.Teachers.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.ID == model.ID);
                dto.ID = teacher.ID;
                StudentStatic.ID = dto.ID;
                dto.Username = teacher.Username;
                dto.FirstName = teacher.FirstName;
                dto.SurName = teacher.Surname;

            }

            return dto;

        }

        public int AddTeacher(Teacher teacher)
        {
            try
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return teacher.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
