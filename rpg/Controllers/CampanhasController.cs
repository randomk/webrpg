using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Models;

namespace rpg.Controllers
{
    public class CampanhasController : BaseController
    {
        // GET: Campanha
        public ActionResult Index()
        {
            if (!verifica_acesso("Campanhas", "Visualizar"))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.pagina = "Campanhas";
            return View();
        }
    }
}