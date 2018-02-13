using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALUsuario : conexionBD
    {
        public List<object> crearUsuario(Entidades.Usuario usuario)
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

        public List<object> eliminarUsuario(Entidades.Usuario usuario)
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

        public List<object> buscarUsuario(Entidades.Usuario usuario)
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

        public List<object> ModificarUsuario(Entidades.Usuario usuario)
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

        public List<object> validarUsuario(Entidades.Usuario usuario)
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

        public List<object> validarContraseña(Entidades.Usuario usuario)
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
