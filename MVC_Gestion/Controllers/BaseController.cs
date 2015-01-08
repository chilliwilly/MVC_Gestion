using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Gestion.Models;

namespace MVC_Gestion.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            ViewBag.Menu = BuildMenu();
        }

        private IList<MenuModel> BuildMenu()
        {
            IList<MenuModel> mmList = new List<MenuModel>(){

                // Parent
                new MenuModel(){ menu_id=1, menu_nombre="Inicio", menu_grupo=1, menu_funcmain=1, menu_funcsec=2, menu_url="#"} ,
                new MenuModel(){ menu_id=2, menu_nombre="Mejora", menu_grupo=2, menu_funcmain=1, menu_funcsec=2, menu_url="#"} ,
                new MenuModel(){ menu_id=3, menu_nombre="Seguimiento", menu_grupo=3, menu_funcmain=1, menu_funcsec=0, menu_url="#"} ,
                new MenuModel(){ menu_id=4, menu_nombre="Salir", menu_grupo=4, menu_funcmain=1, menu_funcsec=2, menu_url="#"} ,
                // Children

                new MenuModel() { menu_id=5, menu_nombre="Nueva Mejora", menu_grupo=2, menu_funcmain=1, menu_funcsec=2, menu_url="#" },
                new MenuModel() { menu_id=6, menu_nombre="Ver Mejora", menu_grupo=2, menu_funcmain=1, menu_funcsec=2, menu_url="#" },

                new MenuModel() { menu_id=7, menu_nombre="Ver Mejora", menu_grupo=3, menu_funcmain=1, menu_funcsec=0, menu_url="#"},
                new MenuModel() { menu_id=8, menu_nombre="Nuevo Seguimiento", menu_grupo=3, menu_funcmain=1, menu_funcsec=0, menu_url="#" },
                new MenuModel() { menu_id=9, menu_nombre="Cerrar Seguimiento", menu_grupo=3, menu_funcmain=1, menu_funcsec=0, menu_url="#" },

            };

            return mmList;
        }
    }
}
