using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;

namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {

        AdminBLL adminBll = new AdminBLL(); // create instance of BLL to get model

        // GET: Admin/Login
        public ActionResult Index()
        {
            //create instance of DTO and pass it
            AdminDTO dto = new AdminDTO();
            return View(dto);

        }
        [HttpPost] //method used to post data to the server
        public ActionResult Index(AdminDTO model)
        {
            if (ModelState.IsValid)
            {
                AdminDTO admin = adminBll.getLoginDetails(model);
                if (admin.Username != null)
                {
                    return RedirectToAction("AdminPortal", "Login");
                }
                else
                    return View(model);

            }
            else
                return View(model);
        }
        public ActionResult AdminPortal()
        {
            return View();
        }
     
    }
}
