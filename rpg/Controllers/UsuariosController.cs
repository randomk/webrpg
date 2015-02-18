using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rpg.Dao;
using rpg.Models;

namespace rpg.Controllers
{
    public class UsuariosController : BaseController
    {
        // GET: Usuario
        public ActionResult Index()
        {
            if (!verifica_acesso("Usuários", "Visualizar"))
            {
                return RedirectToAction("Index", "Login");
            }
            UsuarioDao _UsuarioDao = new UsuarioDao();
            IList<Usuario> _Usuarios = _UsuarioDao.Listar_Usuarios();
            ViewBag.pagina = "Usuário";
            return View(_Usuarios);
        }
    }
}