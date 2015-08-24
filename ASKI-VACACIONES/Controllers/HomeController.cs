using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Login(){return View();}
        public ViewResult MenuPrincipal() { return View(); }
        public ViewResult Calendario() { return View(); }
        public ViewResult Administracion() { return View(); }
        public ViewResult NuevaSolicitud() { return View(); }
        public ViewResult MisSolicitudes() { return View(); }

       [HttpPost]
        public ActionResult Administracion(UserModel model)
        {

            Service1Client client = new Service1Client();
            client.addDepartamento(model.descripcion, model.estatus);
            client.Close();
            return View();
        }
    }
}