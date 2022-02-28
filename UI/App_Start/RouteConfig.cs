using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");          
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
                );
            routes.MapRoute(
                name: "Courses",
                url: "{CourseName}",
                defaults: new { controller = "Course", action = "CourseList", CourseName = UrlParameter.Optional }

                );
            routes.MapRoute(
                name: "Enrollment",
                url: "{CourseName}",
                defaults: new { controller = "Enrollment", action = "ViewSchedule", CourseName = UrlParameter.Optional }

                );
          
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
