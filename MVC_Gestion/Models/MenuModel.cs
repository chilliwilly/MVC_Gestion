using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Gestion.Models
{
    public class MenuModel
    {
        public int menu_id { get; set; }
        public String menu_nombre { get; set; }
        public int menu_grupo { get; set; }
        public int menu_funcmain { get; set; }
        public int menu_funcsec { get; set; }
        public String menu_url { get; set; }
    }
}