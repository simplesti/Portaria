using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portaria.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                using (var bd = new PortariaContext())
                {
                    var usuario = bd.Usuarios.FirstOrDefault(u => u.Login == User.Identity.Name);
                    if (usuario != null)
                    {
                        ViewBag.NomeUsuario = usuario.Nome;
                        ViewBag.TipoUsuario = usuario.Tipo;
                    }
                }
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
    }
}