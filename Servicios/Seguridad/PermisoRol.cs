using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class PermisoRol
    {
        private Guid _idRol;

        public Guid idRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        private Guid _idPermiso;

        public Guid idPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }

    }
}
