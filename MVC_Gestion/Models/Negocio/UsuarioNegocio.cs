using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace MVC_Gestion.Models.Negocio
{
    public class UsuarioNegocio
    {
        public bool usrValido(String usr, String pwd) 
        {
            bool valido = false;
            CodificarPwd objPwd = new CodificarPwd();

            using (var db = new Models.EntitiesGestion()) 
            {
                var vUsr = db.TBLUSUARIO.FirstOrDefault(it => it.USER_NICK.Equals(usr));
                
                if (vUsr != null) 
                {
                    if (vUsr.USER_PWD.Equals(objPwd.codificar(pwd)))
                    {
                        valido = true;
                    }
                }                
            }
            return valido;
        }
    }
}