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

        [HttpPost]
        public ActionResult Adiciona(int cod_atributo, string descricao, bool ativo)
        {
            string msg = validar(descricao, cod_atributo);
            if (string.IsNullOrEmpty(msg))
            {
                AtributoDao _AtributoDao = new AtributoDao();
                if (cod_atributo == 0)
                {
                    msg = _AtributoDao.Insert(descricao, ativo);
                }
                else
                {
                    msg = _AtributoDao.update(cod_atributo, descricao, ativo);
                }                
            }
            return Json(msg);            
        }

        [HttpPost]
        public ActionResult delete(int cod_atributo)
        {
            AtributoDao _AtributoDao = new AtributoDao();
            return Json(_AtributoDao.delete(cod_atributo));
        }

        public string validar (string descricao, int cod_atributo)
        {
            AtributoDao _AtributoDao = new AtributoDao();
            if (string.IsNullOrEmpty(descricao))
            {
                return "Campo descrição obrigatório";
            }
            if (!_AtributoDao.verifica_descricao(cod_atributo, descricao))
            {
                return "Já existe uma descrição com esse nome";
            }
            return "";
        }
    }
}