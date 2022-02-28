using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class AppointmentController : Controller
    {
        AppointmentBLL bll = new AppointmentBLL();
        // GET: Admin/Appointment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddApp()
        {
            AppointmentDTO dto = new AppointmentDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult AddApp(AppointmentDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddApp(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new AppointmentDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(model);
        }
    }
}