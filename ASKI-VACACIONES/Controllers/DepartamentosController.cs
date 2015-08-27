using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamentos
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Edit()
        {
            return PartialView();
        }
        public ActionResult Delete()
        {
            return PartialView();
        }
    }
}