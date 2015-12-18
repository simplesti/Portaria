using Portaria.Business;
using Portaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portaria.Web.Controllers
{
    public class ControllerBase : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (Request.IsAuthenticated)
            {
                var sessao = SessaoAtual();
                if (sessao != null)
                {
                    ViewBag.NomeUsuario = sessao.UsuarioLogado.Nome;
                    ViewBag.TipoUsuario = sessao.UsuarioLogado.Tipo;
                }
            }
        }

        public Sessao SessaoAtual()
        {
            if (User.Identity.Name == null)
            {
                return null;
            }

            using (var bd = new SessaoBus())
            {
                var idSessao = Convert.ToInt32(User.Identity.Name);
                var sessao = bd.BuscarPorId(idSessao);
                return sessao;
            }
        }
    }
}