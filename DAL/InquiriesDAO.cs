using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class InquiriesDAO : dbContext 
    {
        public int SendInquiries(Inquiry inquiry)
        {
            try
            {
                db.Inquiries.Add(inquiry);
                db.SaveChanges();
                return inquiry.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<InquiriesDTO> GetInquiries()
        {
            var list = (from e in db.Inquiries.Where(x => x.ID > 0)
                        join s in db.Students on e.StudentID equals s.ID
                        join c in db.Courses on e.CourseID equals c.ID
                        select new
                        {
                            courseID = c.ID,
                            CourseName = c.CourseName,
                            studentID = s.ID,
                            studentFName = s.FirstName,
                            studentLName = s.Surname,
                            inquiryDetails = e.InquiryDetails
                        }
                             ).Take(4).ToList();
            List<InquiriesDTO> ilist = new List<InquiriesDTO>();
            foreach (var item in list)
            {
                InquiriesDTO iDto = new InquiriesDTO();

                iDto.CourseID = item.courseID;
                iDto.CourseName = item.CourseName;
                iDto.StudentID = item.studentID;
                iDto.sFirstName = item.studentFName;
                iDto.sSurname = item.studentLName;
                iDto.InquiryDetails = item.inquiryDetails;
                ilist.Add(iDto);
            }
            User user = new User();
            user = db.Users.FirstOrDefault(x => x.UserRole == UserStatic.UserRole || x.ID == UserStatic.UserID);
            if (user.UserRole == "Account Manager" || user.UserRole == "account manager" || user.UserRole == "Account manager")
            {
                return ilist;
            }
            else
                return ilist;
            
           
        
        }
    }
}
