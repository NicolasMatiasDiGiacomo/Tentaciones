using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALUsuarioPermiso : conexionBD
    {
        public List<object> crearUsuarioPermiso(UsuarioPermiso usuarioPermiso)
        {
            try
            {
                return ejecutarConsulta(usuarioPermiso, "UsuarioPermisoCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarUsuarioPermiso(UsuarioPermiso usuarioPermiso)
        {
            try
            {
                return ejecutarConsulta(usuarioPermiso, "UsuarioPermisoEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarUsuarioPermiso(UsuarioPermiso usuarioPermiso)
        {
            try
            {
                return ejecutarConsulta(usuarioPermiso, "UsuarioPermisoBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarUsuarioPermiso(UsuarioPermiso usuarioPermiso)
        {
            try
            {
                return ejecutarConsulta(usuarioPermiso, "UsuarioPermisoModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
