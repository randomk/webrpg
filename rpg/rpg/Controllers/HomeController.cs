using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Filtros;
using rpg.Models;

namespace rpg.Controllers
{
    public class HomeController : BaseController
    {
    
        public ActionResult Index()
        {
            ViewBag.pagina = "Inicio";
            return View();
        }
    }
}