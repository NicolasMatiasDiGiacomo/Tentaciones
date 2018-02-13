using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALPermisoRol : conexionBD
    {
        public List<object> crearPermisoRol(PermisoRol permisoRol)
        {
            try
            {
                return ejecutarConsulta(permisoRol, "PermisoRolCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarPermisoRol(PermisoRol permisoRol)
        {
            try
            {
                return ejecutarConsulta(permisoRol, "PermisoRolEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarPermisoRol(PermisoRol permisoRol)
        {
            try
            {
                return ejecutarConsulta(permisoRol, "PermisoRolBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarPermisoRol(PermisoRol permisoRol)
        {
            try
            {
                return ejecutarConsulta(permisoRol, "PermisoRolModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
