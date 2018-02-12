using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALTipoFactura : conexionBD
    {
        public List<object> crearTipoFactura(Entidades.TipoFactura tipoFactura)
        {
            try
            {
                return ejecutarConsulta(tipoFactura, "TipoFacturaCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarTipoFactura(Entidades.TipoFactura tipoFactura)
        {
            try
            {
                return ejecutarConsulta(tipoFactura, "TipoFacturaEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarTipoFactura(Entidades.TipoFactura tipoFactura)
        {
            try
            {
                return ejecutarConsulta(tipoFactura, "TipoFacturaBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarTipoFactura(Entidades.TipoFactura tipoFactura)
        {
            try
            {
                return ejecutarConsulta(tipoFactura, "TipoFacturaModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
