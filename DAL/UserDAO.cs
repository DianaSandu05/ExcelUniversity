using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL 
{
    public class UserDAO : dbContext
    {
        //in the below method we do the sql operations
       public UserDTO userLogin(UserDTO userModel)
        {

            UserDTO userDto = new UserDTO();
            User user = new User();
            if (user != null)
            {
               user = db.Users.First(x => x.Username == userModel.Username && x.Password == userModel.Password);
                userDto.UserID = user.ID;
                UserStatic.UserID = userDto.UserID;
                userDto.Username = user.Username;
           //     userDto.FilePath = user.FilePath;
                userDto.FirstName = user.FirstName;
                userDto.SurName = user.Surname;
            }
            return userDto;
        }

        public List<UserDTO> GetUser()
        {
            List<User> list = db.Users.Where(x => x.isAdmin == "False").OrderBy(x => x.UserRole).ToList();
            List<UserDTO> userlist = new List<UserDTO>();
            foreach (var item in list)
            {
                UserDTO userDto = new UserDTO();
                userDto.UserID = item.ID;
                userDto.FirstName = item.FirstName;
                userDto.SurName = item.Surname;
                userDto.Email = item.Email;
                userDto.UserRole = item.UserRole;
                userlist.Add(userDto);
            }
            return userlist;
        }

        public int AddUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
