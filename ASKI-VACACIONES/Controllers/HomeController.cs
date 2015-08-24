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
    }
}