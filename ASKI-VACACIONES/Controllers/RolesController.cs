using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Agregar()
        {
            return PartialView();
        }

        public ActionResult Modificar()
        {
            return PartialView();
        }
        public ActionResult Eliminar()
        {
            return PartialView();
        }

    }
}