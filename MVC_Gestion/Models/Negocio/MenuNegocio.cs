using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Gestion.Models.Negocio
{
    public class MenuNegocio
    {
        public List<MenuModel> MenuUsuario(int perfil) 
        {
            List<MenuModel> lsMenu = new List<MenuModel>();
            var mu = lista(perfil);

            if (mu != null && mu.LongCount() > 0) 
            {
                foreach (MenuModel um in mu) 
                {
                    if (um.menu_id == um.menu_grupo) 
                    {
                        MenuModel m = new MenuModel();
                        m.menu_nombre = um.menu_nombre;
                        m.menu_id = um.menu_id;
                        m.menu_grupo = 0;
                        m.menu_url = um.menu_url;
                        lsMenu.Add(m);
                    }
                }
            }
            return lsMenu;
        }

        public List<MenuModel> SubMenuUsuario(int perfil) 
        {
            List<MenuModel> lsMenu = new List<MenuModel>();
            var sm = lista(perfil);

            if (sm != null && sm.LongCount() > 0)
            {
                foreach (MenuModel um in sm)
                {
                    MenuModel m = new MenuModel();
                    m.menu_nombre = um.menu_nombre;
                    m.menu_id = um.menu_id;
                    m.menu_grupo = um.menu_grupo;
                    m.menu_url = um.menu_url;
                    lsMenu.Add(m);
                }
            }
            return lsMenu;
        }

        private List<MenuModel> lista(int perfil) 
        {
            List<MenuModel> ls = new List<MenuModel>();

            Models.EntitiesGestion db = new EntitiesGestion();
            IEnumerable<Models.TBLMENU> menu = null;

            if (perfil == 1)
            {
                menu = db.TBLMENU.Where(it => it.MENU_FUNCMAIN == perfil).OrderBy(it => it.MENU_ID);
            }
            if (perfil == 2)
            {
                menu = db.TBLMENU.Where(it => it.MENU_FUNCSEC == perfil).OrderBy(it => it.MENU_ID);
            }

            foreach (Models.TBLMENU m in menu)
            {
                MenuModel mm = new MenuModel();
                mm.menu_id = Convert.ToInt32(m.MENU_ID);
                mm.menu_nombre = m.MENU_NOMBRE;
                mm.menu_grupo = Convert.ToInt32(m.MENU_GRUPO);
                mm.menu_funcmain = Convert.ToInt32(m.MENU_FUNCMAIN);
                mm.menu_funcsec = Convert.ToInt32(m.MENU_FUNCSEC);
                mm.menu_url = m.MENU_URL;
                ls.Add(mm);
            }

            return ls;
        }

        public int usrPerfil(String nick) 
        {
            Models.EntitiesGestion db = new EntitiesGestion();
            var p = db.TBLUSUARIO.Where(it => it.USER_NICK == nick).Select(it => it.USER_PERFIL);
            
            return Convert.ToInt32(p);
        }
    }
}