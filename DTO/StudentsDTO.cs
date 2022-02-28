using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentsDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill the username area")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please fill the username area")]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }
        public string ImagePath { get; set; }
        public  string Results { get; set; }
        public  string Feedback { get; set; }

        public DateTime DoB { get; set; }
        public string FilePath { get; set; }    
        public string Email { get; set; }
        public int EnrollmentID { get; set; }
       

    }
    public static class StudentStatic
    {
        public static int ID { get; set; }
        [Required(ErrorMessage = "Please fill the username area")]
        public static string Username { get; set; }
        [Required(ErrorMessage = "Please fill the password area")]
        public static string Password { get; set; }
        public static string FilePath { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static DateTime LastUpdateUserID { get; set; }
        public static bool isAdmin { get; set; }
    }
}
