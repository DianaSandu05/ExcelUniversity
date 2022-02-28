using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class AppointmentBLL
    {
        AppointmentDAO appDao = new AppointmentDAO();
        public bool AddApp(AppointmentDTO model)
        {
            Appointment app = new Appointment();
          
            app.AppDate = model.AppDate;
            app.isConfirmed = model.isConfirmed;
            app.LastUpdateUserID = UserStatic.UserID;
            int ID = appDao.AddApp(app);
            return true;
        }
    }
}
