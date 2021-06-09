using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class MostradorController : Controller
    {
        // GET: Mostrador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Violencia_Genero()
        {
            return View();
        }
    }
}