using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public static class UserStatic
    {
        public static int UserID { get; set; }
        public static bool isAdmin { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string SurName { get; set; }
        public static string UserRole { get; set; }
    }
}
