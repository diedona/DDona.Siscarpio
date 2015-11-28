using DDona.Siscarpio.Business;
using DDona.Siscarpio.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.Siscarpio.Wcf.Usuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Usuario" in both code and config file together.
    public class Usuario : IUsuario
    {
        public List<UsuarioListagemDTO> GetAllUsuarios()
        {
            UsuarioBusiness UsuarioBusiness = new UsuarioBusiness();
            return UsuarioBusiness.GetAllUsuarios();
        }

        [OperationContract]
        public List<UsuarioListagemDTO> GetUsuarios(string Nome, string Username)
        {
            UsuarioBusiness UsuarioBusiness = new UsuarioBusiness();
            return UsuarioBusiness.GetUsuarios(Nome, Username);
        }

        public bool LogUser(string Username, string Password)
        {
            UsuarioBusiness UsuarioBusiness = new UsuarioBusiness();
            return UsuarioBusiness.LogUser(Username, Password);
        }
    }
}
