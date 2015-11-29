using DDona.Siscarpio.Web.UsuarioReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDona.Siscarpio.Web.ViewModel.Usuario
{
    public class UsuarioIndexViewModel
    {
        public BuscaUsuarioViewModel DadosBusca { get; set; }
        public UsuarioListagemDTO[] Usuarios { get; set; }

        public UsuarioIndexViewModel()
        {
            DadosBusca = new BuscaUsuarioViewModel();
        }
    }
}