using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;


namespace UI.Areas.Admin.Controllers
{
    public class EnrollmentController : Controller
    {
       
        EnrollmentBLL bll = new EnrollmentBLL();
        // GET: Admin/Enrollment
        public ActionResult EnrollmentList()
        {
            List<EnrollmentDTO> model = new List<EnrollmentDTO>();
            model = bll.GetEnrollment();

            return View(model);
        }

        public ActionResult addEnrollment()
        {
            EnrollmentDTO dto = new EnrollmentDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult addEnrollment(EnrollmentDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddEnrollment(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new EnrollmentDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(model);
         
        }
      
        public ActionResult ViewSchedule()
        {
           
            List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
            elist = bll.GetSchedules();
            return View(elist);
        }
        public ActionResult EnrolledCoursesList()
        {
            List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
            elist = bll.GetEnrolledCourses();
            return View(elist);
        }
        public ActionResult AssignmentsList()
        {
            List<EnrollmentDTO> elist = new List<EnrollmentDTO>();
            elist = bll.GetEnrolledCourses();
            return View(elist);
        }
    }
}