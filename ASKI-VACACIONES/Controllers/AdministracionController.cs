using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ViewResult Administracion()
        { 
            return View(); 
        }

        [HttpPost]
        public ActionResult Administracion(DepartamentoModel model)
        {

            Service1Client client = new Service1Client();
            client.addDepartamentos(model.descripcion);
            client.Close();
            return View();
        }


        /*[HttpPost]
        [ActionName("Administracion")]
        public ActionResult Administracion(RolesModel model)
        {
            Service1Client client = new Service1Client();
            client.addRoles(model.descripcion);
            return View();

        }*/
    }
}