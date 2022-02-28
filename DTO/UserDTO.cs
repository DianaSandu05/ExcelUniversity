using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        //create properties for user
        //bellow line added for user login
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please fill the username area")]
        public  string Username { get; set; }
        [Required(ErrorMessage = "Please fill the username area")]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public  string SurName { get; set; }
        public  DateTime DoB { get; set; }
    //    public  bool isDeleted { get; set; }
     //   public  DateTime DeletedDate { get; set; }

        public  int LastUpdateUserID { get; set; }
        public string FilePath { get; set; }
        public  string isAdmin { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
    }
}
