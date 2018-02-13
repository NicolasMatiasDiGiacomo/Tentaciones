using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALUsuarioRol : conexionBD
    {
        public List<object> crearUsuarioRol(UsuarioRol usuarioRol)
        {
            try
            {
                return ejecutarConsulta(usuarioRol, "UsuarioRolCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarUsuarioRol(UsuarioRol usuarioRol)
        {
            try
            {
                return ejecutarConsulta(usuarioRol, "UsuarioRolEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarUsuarioRol(UsuarioRol usuarioRol)
        {
            try
            {
                return ejecutarConsulta(usuarioRol, "UsuarioRolBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarUsuarioRol(UsuarioRol usuarioRol)
        {
            try
            {
                return ejecutarConsulta(usuarioRol, "UsuarioRolModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
