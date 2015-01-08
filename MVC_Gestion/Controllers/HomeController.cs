using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Gestion.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/
        [Authorize]
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.Name == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            else 
            {
                return View();
            }            
        }

    }
}
