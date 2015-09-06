using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.EstaAtenticado = "Esta autenticado";
            }

            Console.WriteLine();

            return View();
        }
    }
}