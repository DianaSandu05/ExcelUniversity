using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BLL;

namespace BLL
{
    // we will access this class from UI to get the data
    public class AdminBLL
    {
        //create instance of the class UserDAO from DAL to call the method getLoginDetails

         AdminDAO adminDao = new AdminDAO();
        public AdminDTO getLoginDetails(AdminDTO model)
        {
            //Create instance of UserDTO to be able and assign the instance of userdao
            //which calls the login method with parameter model where the data is stored
              AdminDTO dto = new AdminDTO();
             dto = adminDao.getLoginDetails(model);
            return dto;
        }
    }

}
