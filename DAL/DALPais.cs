using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALPais : conexionBD
    {
        public List<object> crearPais(Entidades.Pais pais)
        {
            try
            {
                return ejecutarConsulta(pais, "PaisCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarPais(Entidades.Pais pais)
        {
            try
            {
                return ejecutarConsulta(pais, "PaisEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarPais(Entidades.Pais pais)
        {
            try
            {
                return ejecutarConsulta(pais, "PaisBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarPais(Entidades.Pais pais)
        {
            try
            {
                return ejecutarConsulta(pais, "PaisModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
