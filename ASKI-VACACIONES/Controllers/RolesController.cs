using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RolesModel model)
        {
            Service1Client client = new Service1Client();
            client.addRoles(model.descripcion);
            client.Close();
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}