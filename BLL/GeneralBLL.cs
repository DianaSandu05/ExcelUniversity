using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class GeneralBLL
    {
        GeneralDAO dao = new GeneralDAO();
        public GeneralDTO GetEnrolledCourses()
        {
            GeneralDTO dto = new GeneralDTO();
            dto.GetEnrolledCourses = dao.GetEnrolledCourses();
            return dto;
        }
       
    }
}
