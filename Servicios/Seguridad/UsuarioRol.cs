using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class UsuarioRol
    {
        private Guid _idUsuario;

        public Guid idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private Guid _idRol;

        public Guid idRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

    }
}
