using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALRol  : conexionBD
    {
        public List<object> crearRol(Rol rol)
        {
            try
            {
                return ejecutarConsulta(rol, "RolCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarRol(Rol rol)
        {
            try
            {
                return ejecutarConsulta(rol, "RolEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarRol(Rol rol)
        {
            try
            {
                return ejecutarConsulta(rol, "RolBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarRol(Rol rol)
        {
            try
            {
                return ejecutarConsulta(rol, "RolModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
