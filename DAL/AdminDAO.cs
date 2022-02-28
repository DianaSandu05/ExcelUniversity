using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    //this class helps to make SQL operations
    //this inherits from DBContext class --> see below
    public class AdminDAO : dbContext
    {
        //in the below method we do the sql operations
        
        public AdminDTO getLoginDetails(AdminDTO model)
        {
            Admin_T admin = new Admin_T();
            AdminDTO dto = new AdminDTO();
            if ( admin.ID != 0)
            {
                admin = db.Admin_T.First(x => x.Username == model.Username && x.Password == model.Password);
                dto.ID = admin.ID;
                dto.Username = admin.Username;
                dto.FirstName = admin.FirstName;
                dto.LastName = admin.LastName;

            }   
            return dto;
            }

        }   
    }


