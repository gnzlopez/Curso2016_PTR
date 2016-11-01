using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Servicios;
using Entidades;

namespace OMB_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SecurityServices serv = new SecurityServices();
            Usuario user = serv.LoginUsuario("gnzlopez", "1212");
            if (user == null)
            {
                return new HttpUnauthorizedResult("Usuario no existe");
            }
            return View(user);
        }
    }
}