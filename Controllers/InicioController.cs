using sistemaESDO.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sistemaESDO.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        [CheckSession]
        public ActionResult Index()
        {
            return View();
        }
    }
}