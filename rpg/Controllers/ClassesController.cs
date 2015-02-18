using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Models;


namespace rpg.Controllers
{
    public class ClassesController : BaseController
    {
        // GET: Classe
        public ActionResult Index()
        {
            if (!verifica_acesso("Classes", "Visualizar"))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.pagina = "Classes";
            return View();
        }
    }
}