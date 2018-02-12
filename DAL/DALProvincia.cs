using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALProvincia : conexionBD
    {
        public List<object> crearProvincia(Entidades.Provincia provincia)
        {
            try
            {
                return ejecutarConsulta(provincia, "ProvinciaCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarProvincia(Entidades.Provincia provincia)
        {
            try
            {
                return ejecutarConsulta(provincia, "ProvinciaEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProvincia(Entidades.Provincia provincia)
        {
            try
            {
                return ejecutarConsulta(provincia, "ProvinciaBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarProvincia(Entidades.Provincia provincia)
        {
            try
            {
                return ejecutarConsulta(provincia, "ProvinciaModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
