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
    
    public partial class tbl_jerarquia
    {
        public int jerarquiaid { get; set; }
        public int talento_humano { get; set; }
        public int jefe_talentohumano { get; set; }
        public int departamentoid { get; set; }
    
        public virtual tbl_departamento tbl_departamento { get; set; }
        public virtual tbl_usuarios tbl_usuarios { get; set; }
        public virtual tbl_usuarios tbl_usuarios1 { get; set; }
    }
}
