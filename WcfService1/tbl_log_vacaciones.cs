//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_log_vacaciones
    {
        public int logid { get; set; }
        public int vacacionesid { get; set; }
        public int th_modifico { get; set; }
        public Nullable<int> estatus_anterior { get; set; }
        public int estatus_actual { get; set; }
        public System.DateTime fecha_modificacion { get; set; }
    
        public virtual tbl_estatus tbl_estatus { get; set; }
        public virtual tbl_estatus tbl_estatus1 { get; set; }
        public virtual tbl_usuarios tbl_usuarios { get; set; }
        public virtual tbl_vacaciones tbl_vacaciones { get; set; }
    }
}
