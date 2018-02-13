using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class UsuarioPermiso
    {
        private Guid _idUsuario;

        public Guid idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private Guid _idPermiso;

        public Guid idPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }

    }
}
