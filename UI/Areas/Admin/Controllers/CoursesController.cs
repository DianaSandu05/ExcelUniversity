using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;

namespace UI.Areas.Admin.Controllers
{
    public class CoursesController : Controller
    {
        CoursesBLL courseBll = new CoursesBLL();
        InquiriesBLL inquiriesBLL = new InquiriesBLL();
      
        // GET: Admin/Courses
       
        public ActionResult AddCourse()
        {
            CoursesDTO courseDto = new CoursesDTO();
            return View(courseDto);
        }
        [HttpPost]
        public ActionResult AddCourse(CoursesDTO courseModel)
        {
            if(ModelState.IsValid)
            {
                if(courseBll.AddCourse(courseModel))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    courseModel = new CoursesDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(courseModel);
        }
       
        //this is for the account manager role user to view the inquiries 
        // remaining part is to create the role parameter so only specific users can view the 
        public ActionResult CourseEnquiries()
        {
            
            List<InquiriesDTO> inquiriesModel = new List<InquiriesDTO>();
            inquiriesModel = inquiriesBLL.GetInquiries();
            return View(inquiriesModel);
        }
        public ActionResult CourseDetail()
        {
            return View();
        }
        public ActionResult EntireListofCourses()
        { 
            return View(); 
        }
       

    }
}
