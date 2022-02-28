using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int PassID { get; set; }
        public int LiaisonID { get; set; }
        public int LastUpdateUserID { get; set; }

       
    }
    public static class TeacherStatic
    {
        public static int ID { get; set; }
        
        public static string Username { get; set; }
   
        public static string Password { get; set; }
        public static string FilePath { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static DateTime LastUpdateUserID { get; set; }
        public static bool isAdmin { get; set; }
    }
}
