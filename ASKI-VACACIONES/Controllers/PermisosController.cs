﻿using ASKI_VACACIONES.Models;
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

        public ActionResult Edit()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Edit(PermisosModel model, string submitButton)
        {
            Service1Client client = new Service1Client();
            switch (submitButton)
            {
            case "Buscar":
            string hola= client.getPermisosInfo(model.id);
            ViewBag.Desc = hola;
            client.Close();
            return View();     
                case "Modificar":
                    if (Session["User"] != null)
                    {
                        // var dic = client.getPermisosInfo(model.id);
                        //Session["Name"] = dic.descripcion;
                        client.editPermisos(model.id, model.descripcion, model.activo);
                        client.Close();
                    }
                    return View();
                default:
                    // If they've submitted the form without a submitButton, 
                    // just return the view again.
                    return RedirectToAction("Login");
            }

            
           
        }

        [HttpPost]
        public ActionResult Delete(PermisosModel model)
        {
            Service1Client client = new Service1Client();
            client.deletePermisos(model.id);
            client.Close();
            return View();
        }
        public ActionResult Delete()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Cargar(PermisosModel model)
        {
            Service1Client client = new Service1Client();
            string dic = client.getPermisosInfo(model.id);
            
            client.Close();
            return View(dic);
        }
    }
}