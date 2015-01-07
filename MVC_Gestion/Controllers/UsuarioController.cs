using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Gestion.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.UsuarioModel usr) 
        {
            Models.Negocio.UsuarioNegocio blPwd = new Models.Negocio.UsuarioNegocio();

            if (ModelState.IsValid)
            {
                if (blPwd.usrValido(usr.usr_nick,usr.usr_pwd))
                {
                    FormsAuthentication.SetAuthCookie(usr.usr_nick, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Datos de acceso incorrecto");
                }
            }

            return View(usr);
        }

        //[HttpGet]
        //public ActionResult Logout()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Logout()
        //{
        //    return View();
        //}
    }
}
