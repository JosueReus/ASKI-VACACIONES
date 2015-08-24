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

        public void addDepartamento(int iD, string descripcion, int status)
        {
            vsystem_askiEntities db = new vsystem_askiEntities();
            tbl_departamento dep = new tbl_departamento();
            dep.descripcion = descripcion;
            dep.activo = true;
            db.tbl_departamento.Add(dep);
            db.SaveChanges();
            
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
