﻿using ASKI_VACACIONES.Models;
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
        public ViewResult Calendario() { return View(); }
        public ViewResult Ayuda() { return View(); }
     

        //[HttpPost]
        //public ActionResult Administracion(DepartamentoModel model)
        //{

        //    Service1Client client = new Service1Client();
        //    client.addDepartamentos(model.descripcion);
        //    client.Close();
        //    return View();
        //}
               
    }
}