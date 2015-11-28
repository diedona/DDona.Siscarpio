using DDona.Siscarpio.ConsoleTeste.UsuarioReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Siscarpio.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UsuarioClient UsuarioClient = new UsuarioClient())
            {
                UsuarioListagemDTO[] Usuarios = UsuarioClient.GetAllUsuarios();

                foreach (var Usuario in Usuarios)
                {
                    Console.WriteLine("{0}) Usuário '{1}' ('{2}')", Usuario.Id, Usuario.Nome, Usuario.Username);
                }
            }
        }
    }
}
