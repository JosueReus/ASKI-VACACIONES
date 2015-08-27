using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UsuariosModel model)
        {
            Service1Client client = new Service1Client();
            client.addUsuario(model.talento_humano, model.email, model.primer_nombre,model.segundo_nombre,model.primer_apellido,model.segundo_apellido,model.fecha_ingreso,model.password);
            client.Close();
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}