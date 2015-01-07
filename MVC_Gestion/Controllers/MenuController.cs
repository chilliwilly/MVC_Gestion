using MVC_Gestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Gestion.Controllers
{
    public class MenuController : Controller
    {
        public MenuController() 
        {
            ViewBag.Menu = HacerMenu();
        }

        private IList<MenuModel> HacerMenu() 
        {
            String usrNick = HttpContext.User.Identity.Name;
            Models.Negocio.MenuNegocio mn = new Models.Negocio.MenuNegocio();
            List<MenuModel> ls = new List<MenuModel>();

            if (ModelState.IsValid) 
            {
                if (Request.IsAuthenticated) 
                {
                    if (HttpContext.User.Identity.Name.Equals(usrNick))
                    { 
                        ls.AddRange(mn.MenuUsuario(mn.usrPerfil(usrNick)));
                        ls.AddRange(mn.SubMenuUsuario(mn.usrPerfil(usrNick)));
                    }
                }
            }
            
            return ls;
        }
    }
}
