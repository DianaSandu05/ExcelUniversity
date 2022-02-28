using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class InquiryController : Controller
    {
        InquiriesBLL bll = new InquiriesBLL();
        // GET: Admin/Inquiry
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendInquiry()
        {
            InquiriesDTO dto = new InquiriesDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult SendInquiry(InquiriesDTO inquiry)
        {
            if (ModelState.IsValid)
            {
                if (bll.SendInquiry(inquiry))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    inquiry = new InquiriesDTO();
                }
                else
                    ViewBag.ProcessState = General.Messages.GeneralError;

            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(inquiry);

        }
        public ActionResult InquiriesList()
        {
            List<InquiriesDTO> model = new List<InquiriesDTO>();
            model = bll.GetInquiries();
            return View(model);
        }

    }
}