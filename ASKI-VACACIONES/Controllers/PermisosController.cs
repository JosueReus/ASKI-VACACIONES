using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class PermisosController : Controller
    {
        // GET: Permisos
        public ActionResult Index()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Index(PermisosModel model)
        {
            if (Session["User"] != null)
            {
                if (ModelState.IsValid)
                {
                    Service1Client client = new Service1Client();
                    client.addPermisos(model.descripcion);
                    client.Close();

                }
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult Edit(PermisosModel model)
        {
            if (Session["User"] != null)
            {
                Service1Client client = new Service1Client();
                client.editPermisos(model.id, model.descripcion, model.activo);
                client.Close();
                return View();
            }
            else
                return RedirectToAction("Login");
        }
        public ActionResult Delete()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
    }
}