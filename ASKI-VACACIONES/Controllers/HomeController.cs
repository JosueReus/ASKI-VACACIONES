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
        public ViewResult Calendario() { return View(); }
        public ViewResult Ayuda() { return View(); }
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tbl_usuarios user)
        {
            if(ModelState.IsValid)
            {
               
                using(vsystem_askiEntities db = new vsystem_askiEntities())
                {
                    var v = db.tbl_usuarios.Where(x => x.email.Equals(user.email) && x.password.Equals(user.password)).FirstOrDefault();
                    if(v!=null)
                    {
                        Session["User"] = v.primer_nombre.ToString() + " " + v.primer_apellido.ToString();
                        return RedirectToAction("AfterLogin");

                    }
                }
            }
            return View(user);
        }

        public ActionResult AfterLogin()
        {
            if(Session["User"]!=null)
            {
                return RedirectToAction("Calendario");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
       
    }
}