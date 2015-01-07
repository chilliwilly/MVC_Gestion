using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Gestion.Models.Negocio
{
    public class CodificarPwd
    {
        public String codificar(String pwdIn) 
        {
            String localPwd = "";

            System.Security.Cryptography.MD5CryptoServiceProvider pwd = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pwdIn);
            data = pwd.ComputeHash(data);
            //string localPwd = "";
            for (int i = 0; i < data.Length; i++)
            localPwd += data[i].ToString("x2").ToLower();
            
            return localPwd;
        }
    }
}