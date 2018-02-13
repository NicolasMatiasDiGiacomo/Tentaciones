using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class Rol
    {
        private Guid _idRol;

        public Guid idRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
