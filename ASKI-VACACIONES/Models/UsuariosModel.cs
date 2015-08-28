using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASKI_VACACIONES.Models
{
    public class UsuariosModel
    {
        public int talento_humano { get; set; }

        [Required]
       
       
        public string email { get; set; }

        [Required]
        [EmailAddress]
        public string primer_nombre { get; set; }
         [Required]
        public string segundo_nombre { get; set; }
         [Required]
        public string primer_apellido { get; set; }
         [Required]
        public string segundo_apellido { get; set; }
         [Required]
        public DateTime fecha_ingreso { get; set; }
         [Required]
        public DateTime fecha_creacion { get; set; }
         [Required]
        public string password { get; set; }
         [Required]
        public bool activo { get; set; }
         [Required]
    }
}