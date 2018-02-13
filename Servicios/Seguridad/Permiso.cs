using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class Permiso
    {
        private Guid _idPermiso;

        public Guid idPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _control;

        public string control
        {
            get { return _control; }
            set { _control = value; }
        }

        private string _accion;

        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

    }
}
