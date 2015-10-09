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
        public Sessao SessaoAtual()
        {
            if (User.Identity.Name == null)
            {
                return null;
            }

            using (var bd = new SessaoBus())
            {
                var idSessao = Convert.ToInt32(User.Identity.Name);
                var sessao = bd.BuscaPorId(idSessao);
                return sessao;
            }
        }
    }
}