using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Models;


namespace rpg.Controllers
{
    public class RacasController : BaseController
    {
        // GET: Raca
        public ActionResult Index()
        {
            if (!verifica_acesso("Raças", "Visualizar"))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.pagina = "Raças";
            return View();
        }
    }
}