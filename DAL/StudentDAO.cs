using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAO : dbContext
    {
       
      
        public List<StudentsDTO> getStudent()
        {
            StudentsDTO model = new StudentsDTO();
            List<Student> list = db.Students.Where(x => x.Username == model.Username).OrderBy(x => x.Username).ToList();
            List<StudentsDTO> studentslist = new List<StudentsDTO>();
            foreach (var item in list)
            {
                StudentsDTO dto = new StudentsDTO();
                dto.ID = item.ID;
                dto.FirstName = item.FirstName;
                dto.SurName = item.Surname;
                dto.Email = item.Email;
                studentslist.Add(dto);
            }
            return studentslist;
        }
   
        public StudentsDTO studentLogin(StudentsDTO model)
        {
            StudentsDTO dto = new StudentsDTO();
            Student student = new Student();
            
            if (student != null)
            {
                student = db.Students.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.ID == model.ID);
                dto.ID = student.ID;
                StudentStatic.ID = dto.ID;
                dto.Username = student.Username;
                dto.FirstName = student.FirstName;
                dto.SurName = student.Surname;
                
            }
            
            return dto;
            
        }

        public int addStudent(Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return student.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
