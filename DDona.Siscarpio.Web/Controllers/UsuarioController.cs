using DDona.Siscarpio.Web.UsuarioReference;
using DDona.Siscarpio.Web.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDona.Siscarpio.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            using(UsuarioClient UsuarioClient = new UsuarioClient())
            {
                UsuarioIndexViewModel Index = new UsuarioIndexViewModel();
                Index.Usuarios = UsuarioClient.GetAllUsuarios();

                return View(Index);
            }
        }

        [HttpPost]
        public ActionResult Index(UsuarioIndexViewModel Model)
        {
            using (UsuarioClient UsuarioClient = new UsuarioClient())
            {
                Model.Usuarios = UsuarioClient.GetUsuarios(Model.DadosBusca.Nome, Model.DadosBusca.Username);
                return View(Model);
            }
        }
    }
}