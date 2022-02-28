using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;
using DAL;
namespace UI.Areas.Admin.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Admin/Teacher
        TeacherBLL bll = new TeacherBLL();

        // GET: Admin/Courses
       
        public ActionResult TeacherList()
        {
            List<TeacherDTO> model = new List<TeacherDTO>();
            model = bll.GetTeacher();

            return View(model);
        }
        public ActionResult AddTeacher()
        {
            TeacherDTO dto = new TeacherDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult AddTeacher(TeacherDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddTeacher(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new TeacherDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(model);
        }

        UserBLL userBll = new UserBLL();
        // GET: Admin/UserLogin
        public ActionResult UserLogin()
        {
            TeacherDTO dto = new TeacherDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult UserLogin(TeacherDTO model)
        {
            if (ModelState.IsValid)
            {
                TeacherDTO teacher = bll.teacherLogin(model);

                if (teacher.ID != 0)
                {
                    return RedirectToAction("TeacherPortal", "Teacher");
                }
                else
                    return View(model);

            }
            else
                return View(model);
        }

    

    }
}