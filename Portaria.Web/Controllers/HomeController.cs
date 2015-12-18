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
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}