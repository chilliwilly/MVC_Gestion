using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Gestion.Models
{
    public class UsuarioModel
    {
        [Required]
        [StringLength(70)]
        [Display(Name = "Usuario : ")]
        public string usr_nick { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Contraseña : ")]
        public string usr_pwd { get; set; }
    }
}