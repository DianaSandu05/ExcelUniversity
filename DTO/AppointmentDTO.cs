using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //here we add all the properties
    public class AppointmentDTO
    {
        public int ID { get; set; }
        public DateTime AppDate { get; set; }
        public bool isConfirmed { get; set; }
    }
}
