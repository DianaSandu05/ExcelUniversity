using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;

namespace UI.Areas.Admin.Models.Atributtes
{
    public class LoginControl : FilterAttribute, IActionFilter
    {
        //
        // Summary:
        //     Called after the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
       public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
        }

    // Summary:
    //     Called before an action method executes.

     public void OnActionExecuting(ActionExecutingContext filterContext)
    {
        if (UserStatic.UserID == 0)
            filterContext.HttpContext.Response.Redirect("Admin/Login/Index");
    }
    
    }
}