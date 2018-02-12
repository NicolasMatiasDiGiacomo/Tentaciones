using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALDireccion : conexionBD
    {
        public List<object> crearDireccion(Entidades.Direccion direccion)
        {
            try
            {
                return ejecutarConsulta(direccion, "DireccionCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarDireccion(Entidades.Direccion direccion)
        {

            try
            {
                return ejecutarConsulta(direccion, "DireccionEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarDireccion(Entidades.Direccion direccion)
        {
            try
            {
                return ejecutarConsulta(direccion, "DireccionBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarDireccion(Entidades.Direccion direccion)
        {
            try
            {
                return ejecutarConsulta(direccion, "DireccionModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
