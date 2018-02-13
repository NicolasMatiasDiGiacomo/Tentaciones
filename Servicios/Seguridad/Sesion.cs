using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class Sesion
    {
        private static Sesion _sesion;

        protected Sesion()
        {

        }

        public static Sesion activa()
        {
            if (_sesion == null)
            {
                _sesion = new Sesion();
            }

            return _sesion;
        }

        private Usuario _usuario;

        public Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

    }
}
