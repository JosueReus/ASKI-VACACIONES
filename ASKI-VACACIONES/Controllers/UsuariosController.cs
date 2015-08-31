﻿using ASKI_VACACIONES.Models;
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
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult Index(UsuariosModel model)
        {
            if (Session["User"] != null)
            {
                if (ModelState.IsValid)
                {
            Service1Client client = new Service1Client();
            string num1 = model.talento_humano.ToString().ElementAt(model.talento_humano.ToString().Length - 2) + "";
            string num2 = model.talento_humano.ToString().ElementAt(model.talento_humano.ToString().Length-1) +""; 
            string pass = model.segundo_nombre.ToString() + num1+num2+"" ;
            client.addUsuario(model.talento_humano, model.email, model.primer_nombre, model.segundo_nombre, model.primer_apellido, model.segundo_apellido, model.fecha_ingreso, pass);
            client.Close();
                }
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult Edit()
        {
            if (Session["User"] != null)
                return View();
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