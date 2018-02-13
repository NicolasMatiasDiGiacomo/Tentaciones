using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALPermiso : conexionBD
    {
        public List<object> crearPermiso(Permiso permiso)
        {
            try
            {
                return ejecutarConsulta(permiso, "PermisoCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarPermiso(Permiso permiso)
        {
            try
            {
                return ejecutarConsulta(permiso, "PermisoEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarPermiso(Permiso permiso)
        {
            try
            {
                return ejecutarConsulta(permiso, "PermisoBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarPermiso(Permiso permiso)
        {
            try
            {
                return ejecutarConsulta(permiso, "PermisoModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
