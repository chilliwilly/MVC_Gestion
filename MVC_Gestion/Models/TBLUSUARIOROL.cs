//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Gestion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLUSUARIOROL
    {
        public decimal ROL_ID { get; set; }
        public decimal USER_ID { get; set; }
    
        public virtual TBLUSUARIO TBLUSUARIO { get; set; }
        public virtual TBLROL TBLROL { get; set; }
    }
}
