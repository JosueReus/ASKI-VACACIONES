using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service_Asky
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void addDepartamentos(string descripcion)
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            tbl_departamento dep = new tbl_departamento();
            dep.descripcion = descripcion;
            dep.activo = true;
            db.tbl_departamento.Add(dep);
            db.SaveChanges();
            
        }
        public void addRoles(string descripcion)
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            tbl_roles roles = new tbl_roles();
            roles.descripcion = descripcion;
            roles.activo = true;
            db.tbl_roles.Add(roles);
            db.SaveChanges();

        }

         public void addUsuario(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, DateTime fecha_ingreso, string password)
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            tbl_usuarios usuario = new tbl_usuarios();
            usuario.talento_humano = talento_humano;
            usuario.email = email;
            usuario.primer_nombre = primer_nombre;
            usuario.segundo_nombre = segundo_nombre;
            usuario.primer_apellido = primer_apellido;
            usuario.segundo_apellido = segundo_apellido;
            usuario.fecha_ingreso = fecha_ingreso;
            usuario.fecha_creacion = DateTime.Today;
            usuario.password = password;
            usuario.activo = true;
            db.tbl_usuarios.Add(usuario);
            db.SaveChanges();
        }

        public void addPermisos(string descripcion)
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            tbl_permisos permisos = new tbl_permisos();
            permisos.descripcion = descripcion;
            permisos.activo = true;
            db.tbl_permisos.Add(permisos);
            db.SaveChanges();

        }

        public vsystem_askiEntities getDb()
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            return db;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
