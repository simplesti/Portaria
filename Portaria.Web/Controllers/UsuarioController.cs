using Portaria.Business;
using Portaria.Core.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;

namespace Portaria.Web.Controllers
{
    public class UsuarioController : ControllerBase
    {
        [Authorize]
        public ActionResult Index()
        {
            var sessao = SessaoAtual();
            if (sessao != null)
            {
                List<Usuario> usuarios;
                using (var bd = new UsuarioBus(sessao))
                {
                    usuarios = bd.Todos().ToList();
                }
                return View(usuarios);
            }

            return RedirectToAction("Login", "Usuario");
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

            return RedirectToAction("LogIn", "Usuario");
        }

        [Authorize]
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Editar(int? id)
        {
            var sessao = SessaoAtual();
            if (sessao != null && id.HasValue)
            {
                using (var bd = new UsuarioBus(sessao))
                {
                    var usuario = bd.BuscarPorId(id.Value);
                    if (usuario != null)
                    {
                        return View(usuario);
                    }
                }
            }
            return RedirectToAction("Index", "Usuario");
        }

        [Authorize]
        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var sessao = SessaoAtual();
                if (sessao != null && usuario != null)
                {
                    using (var bd = new UsuarioBus(sessao))
                    {
                        bd.InserirOuAtualizar(usuario);
                    }
                    return RedirectToAction("Index", "Usuario");
                }
            }
            return View(usuario);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AlterarSenha(string senhaAtual, string senhaNova)
        {
            return RedirectToAction("Index", "Usuario");    
        }

        [Authorize]
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