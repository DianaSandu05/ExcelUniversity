using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        UserBLL userBll = new UserBLL();
        // GET: Admin/UserLogin
        public ActionResult UserLogin()
        {
            UserDTO userDto = new UserDTO();
            return View(userDto);
        }
        [HttpPost]
        public ActionResult UserLogin(UserDTO userModel)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = userBll.userLogin(userModel);

                if (user.UserID != 0)
                {
                    return RedirectToAction("UserPortal", "User");
                }
                else
                    return View(userModel);

            }
            else
                return View(userModel);
        }

            public ActionResult UserList()
        {

            List<UserDTO> userModel = new List<UserDTO>();
            userModel = userBll.GetUser();
            return View(userModel);
        }
        // GET: Admin/User
        public ActionResult AddUser()
        {
            UserDTO userDto = new UserDTO();
            return View(userDto);
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO userModel)
        {
            if (ModelState.IsValid)
            { 
                if(userBll.AddUser(userModel))
                 {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    userModel = new UserDTO();
                 }
                else          
                    ViewBag.ProcessState = General.Messages.GeneralError;
                
            }
            else
                ViewBag.ProcessState = General.Messages.EmptyArea;
            return View(userModel);
        }
        public ActionResult UserPortal()
        {
            return View();

        }
        public ActionResult LiasionReport()
        {
            return View();
        }
    }
}
