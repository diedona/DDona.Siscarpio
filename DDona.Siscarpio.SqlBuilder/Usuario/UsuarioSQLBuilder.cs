using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Siscarpio.SqlBuilder.Usuario
{
    public class UsuarioSQLBuilder
    {
        private UsuarioSQLContainer _sqlContainer = null;

        public UsuarioSQLBuilder()
        {
            _sqlContainer = new UsuarioSQLContainer();
        }

        public string GetUsuarioPedidos()
        {
            return _sqlContainer.UsuarioPedidos();
        }
    }
}
