using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class UserBLL
    {
        //create instance of the class UserDAO from DAL to call the method getLoginDetails
        UserDAO userDao = new UserDAO();


        public UserDTO userLogin(UserDTO userModel)
        {
            
            UserDTO userDto = new UserDTO();
            userDto = userDao.userLogin(userModel);
            return userDto;
        }

        public List<UserDTO> GetUser()
        {
            return userDao.GetUser();
        }

        public bool AddUser(UserDTO userModel)
        {
            User user = new User();
            user.Username = userModel.Username;
            user.Password = userModel.Password;
            user.Email = userModel.Email;
            user.FirstName = userModel.FirstName;
            user.Surname = userModel.SurName;
           user.isAdmin = userModel.isAdmin;
         
            
            user.UserRole = userModel.UserRole;
            //    user.FilePath = userModel.FilePath;
            //   user.IsDeleted = userModel.isDeleted;
            //    user.DeletedDate = DateTime.Now;
            user.LastUpdateUserID = AdminStatic.ID;
              user.LastUpdateDate = DateTime.Now;
       //    user.ScheduleID = ScheduleDTO.ScheduleID;
       //     user.LiaisonID = LiaisonReportDTO.LiaisonID;
         ///  user.PassID = ForgottenPassDTO.PassID;
            int ID = userDao.AddUser(user);
            return true;
            
            
            
        }
    }
}
