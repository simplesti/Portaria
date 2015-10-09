using Portaria.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portaria.Web.Controllers
{
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                var sessao = SessaoAtual();
                if (sessao != null)
                {
                    ViewBag.NomeUsuario = sessao.UsuarioLogado.Nome;
                    ViewBag.TipoUsuario = sessao.UsuarioLogado.Tipo;
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