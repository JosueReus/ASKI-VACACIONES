//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASKI_VACACIONES
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_usuarios
    {
        public tbl_usuarios()
        {
            this.tbl_calendario = new HashSet<tbl_calendario>();
            this.tbl_calendario1 = new HashSet<tbl_calendario>();
            this.tbl_jerarquia = new HashSet<tbl_jerarquia>();
            this.tbl_jerarquia1 = new HashSet<tbl_jerarquia>();
            this.tbl_log_vacaciones = new HashSet<tbl_log_vacaciones>();
            this.tbl_vacaciones = new HashSet<tbl_vacaciones>();
            this.tbl_departamento = new HashSet<tbl_departamento>();
            this.tbl_roles = new HashSet<tbl_roles>();
        }
    
        public int talento_humano { get; set; }
        public string email { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
    
        public virtual ICollection<tbl_calendario> tbl_calendario { get; set; }
        public virtual ICollection<tbl_calendario> tbl_calendario1 { get; set; }
        public virtual ICollection<tbl_jerarquia> tbl_jerarquia { get; set; }
        public virtual ICollection<tbl_jerarquia> tbl_jerarquia1 { get; set; }
        public virtual ICollection<tbl_log_vacaciones> tbl_log_vacaciones { get; set; }
        public virtual ICollection<tbl_vacaciones> tbl_vacaciones { get; set; }
        public virtual ICollection<tbl_departamento> tbl_departamento { get; set; }
        public virtual ICollection<tbl_roles> tbl_roles { get; set; }
    }
}
