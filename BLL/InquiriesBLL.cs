using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class InquiriesBLL
    {
        InquiriesDAO dao = new InquiriesDAO();
        public bool SendInquiry(InquiriesDTO model)
        {

            Inquiry inquiry = new Inquiry();
            inquiry.InquiryDetails = model.InquiryDetails;
            var find1 = dbContext.db.Students.Where(x => x.ID == model.StudentID);
            inquiry.StudentID = model.StudentID;
            var find = dbContext.db.Courses.Where(x => x.ID == model.CourseID);
            inquiry.CourseID = model.CourseID;
            int ID = dao.SendInquiries(inquiry);
            return true;
        }
        public List<InquiriesDTO> GetInquiries()
        {
            return dao.GetInquiries();
        }
    }
}
