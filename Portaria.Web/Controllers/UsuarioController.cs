using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Portaria.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
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
                if (Validar(usuario.Login, usuario.Senha))
                {
                    FormsAuthentication.SetAuthCookie(usuario.Login, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Dados de login incorretos.");
                }
            }

            return View(usuario);
        }
        
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
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
            if (ModelState.IsValid)
            {
                using (var bd = new PortariaContext())
                {
                    var u = bd.Usuarios.Create();
                    u.CPF = usuario.CPF;
                    u.Login = usuario.Login;
                    u.Nome = usuario.Nome;
                    u.RG = usuario.RG;
                    u.Senha = getMD5Hash(usuario.Senha);
                    u.Tipo = usuario.Tipo;

                    bd.Usuarios.Add(u);
                    bd.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Dados do usuário inválidos.");
            }

            return View(usuario);
        }

        public static string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private bool Validar(string login, string senha)
        {
            bool result = false;

            using (var bd = new PortariaContext())
            {
                var usuario = bd.Usuarios.FirstOrDefault(u => u.Login == login);

                if (usuario != null)
                {
                    if (usuario.Senha == getMD5Hash(senha))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}