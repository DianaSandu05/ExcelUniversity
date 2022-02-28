using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class AssignmentsController : Controller
    {
        // GET: Admin/Assignments
        AssignmentsBLL assignmentsBll = new AssignmentsBLL();
        
        public ActionResult AssignmentsList()
        {
            List<AssignmentDTO> model = new List<AssignmentDTO>();
            model = assignmentsBll.GetAssignments();
            return View(model);
        }
        // GET: Admin/User
        public ActionResult AddAssignment()
        {
            AssignmentDTO dto = new AssignmentDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult AddAssignment(AssignmentDTO model)
        {
            if (ModelState.IsValid)
            {
                if (assignmentsBll.AddAssignment_Record(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new AssignmentDTO();
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