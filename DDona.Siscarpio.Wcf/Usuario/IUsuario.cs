using DDona.Siscarpio.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.Siscarpio.Wcf.Usuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuario" in both code and config file together.
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        List<UsuarioListagemDTO> GetAllUsuarios();
    }
}
