using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class DALUsuario : conexionBD
    {
        public List<object> crearUsuario(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarUsuario(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarUsuario(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> ModificarUsuario(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> validarUsuario(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioValidar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> validarContraseña(Usuario usuario)
        {
            try
            {
                return ejecutarConsulta(usuario, "UsuarioContraseñaValidar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
