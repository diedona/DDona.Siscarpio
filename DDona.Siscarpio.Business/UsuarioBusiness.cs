using DDona.Siscarpio.Dto.Usuario;
using DDona.Siscarpio.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Siscarpio.Business
{
    public class UsuarioBusiness
    {
        public List<UsuarioListagemDTO> GetAllUsuarios()
        {
            try
            {
                using(SiscarpioContext db = new SiscarpioContext())
                {
                    List<UsuarioListagemDTO> Usuarios = db.Usuarios
                        .OrderBy(x => x.Nome)
                        .Select(x => new UsuarioListagemDTO
                        { 
                            Id = x.Id,
                            Nome = x.Nome,
                            Username = x.Username
                        })
                        .ToList();

                    return Usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
