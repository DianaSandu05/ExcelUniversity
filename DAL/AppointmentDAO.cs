using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppointmentDAO : dbContext
    {
        public int AddApp(Appointment app)
        {
            try
            {
                db.Appointments.Add(app);
                db.SaveChanges();
                return app.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
