using Portaria.Business;
using Portaria.Core.Model;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace Portaria.Web.Controllers
{
    public class UsuarioController : ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Login) && !string.IsNullOrEmpty(usuario.Senha))
            {
                using (var bd = new UsuarioBus(null))
                {
                    try
                    {
                        var sessao = bd.EfetuarLogin(usuario.Login, usuario.Senha);
                        if (sessao != null)
                        {
                            FormsAuthentication.SetAuthCookie(sessao.Id.ToString(), false);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = ex.Message;
                        return View(usuario);
                    }
                }
            }

            return View(usuario);
        }

        public ActionResult LogOut()
        {
            using (var bd = new SessaoBus())
            {
                var sessao = SessaoAtual();
                if (sessao != null)
                {
                    bd.FinalizarSessao(sessao);
                    FormsAuthentication.SignOut();
                }
            }

            return RedirectToAction("Login", "Usuario");
        }

        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Usuario usuario)
        {
            var sessao = SessaoAtual();

            if (ModelState.IsValid && sessao != null)
            {
                using (var bd = new UsuarioBus(sessao))
                {
                    try
                    {
                        bd.InserirOuAtualizar(usuario);
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = ex.Message;
                        return View(usuario);
                    }

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Dados do usuário inválidos.");
            }

            return View(usuario);
        }
    }
}