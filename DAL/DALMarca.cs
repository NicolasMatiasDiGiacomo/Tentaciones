using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALMarca : conexionBD
    {
        public List<object> crearMarcar(Entidades.Marca marca)
        {
            try
            {
                return ejecutarConsulta(marca, "MarcaCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarMarca(Entidades.Marca marca)
        {
            try
            {
                return ejecutarConsulta(marca, "MarcaEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarMarca(Entidades.Marca marca)
        {
            try
            {
                return ejecutarConsulta(marca, "MarcaBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarMarca(Entidades.Marca marca)
        {
            try
            {
                return ejecutarConsulta(marca, "MarcaModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
