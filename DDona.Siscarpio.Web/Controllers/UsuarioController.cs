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
                //populando os usuários que carregamos na primeira vez
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

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(CriarEditarUsuarioViewModel Model)
        {
            //validação padrão do ASP.NET MVC
            if(!ModelState.IsValid)
            {
                return View(Model);
            }

            //tentando salvar pelo serviço
            using(UsuarioClient UsuarioClient = new UsuarioClient())
            {
                if(!UsuarioClient.SaveUser(Model.Username, Model.Nome, Model.Password))
                {
                    return View(Model);
                }
            }

            return RedirectToAction("Index");
        }
    }
}