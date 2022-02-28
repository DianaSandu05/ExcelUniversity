using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        StudentBLL bll = new StudentBLL();
        // GET: Admin/Student
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult studentLogin()
        {
            StudentsDTO dto = new StudentsDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult studentLogin(StudentsDTO model)
        {
            if (ModelState.IsValid)
            {
                StudentsDTO student = bll.studentLogin(model);
              
                

                if (student.ID != 0)
                {
                    return RedirectToAction("StudentPortal", "Student");
                    
                    
                }
                else
                    return View(model);
                
            }
            else
                return View(model);
        }
        public ActionResult StudentList()
        {
            List<StudentsDTO> model = new List<StudentsDTO>();
            model = bll.getStudent();
            return View(model);
        }
        public ActionResult addStudent()
        {
            StudentsDTO dto = new StudentsDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult addStudent(StudentsDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.addStudent(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new StudentsDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(model);
        }
        public ActionResult StudentPortal()
        {
            return View();
        }
        
    }
}