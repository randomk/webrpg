using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Models;

namespace rpg.Controllers
{
    public class AtributosController : BaseController
    {
        // GET: Atributos
        public ActionResult Index()
        {
            if (!verifica_acesso("Atributos", "Visualizar"))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.pagina = "Atributos";
            ViewBag.paginacao = "<a id=\"Primeira\" disabled=\"disabled\"><<</a>";
            AtributoDao _AtributosDAO = new AtributoDao();
            IList<Atributos> _Atributos = _AtributosDAO.Listar_Atributos_dt();
            return View(_Atributos);
        }
    }
}