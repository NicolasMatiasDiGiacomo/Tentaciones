using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALTipoPago : conexionBD
    {
        public List<object> crearTipoPago(Entidades.TipoPago tipoPago)
        {
            try
            {
                return ejecutarConsulta(tipoPago, "TipoPagoCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarTipoPago(Entidades.TipoPago tipoPago)
        {
            try
            {
                return ejecutarConsulta(tipoPago, "TipoPagoEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarTipoPago(Entidades.TipoPago tipoPago)
        {
            try
            {
                return ejecutarConsulta(tipoPago, "TipoPagoBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarTipoPago(Entidades.TipoPago tipoPago)
        {
            try
            {
                return ejecutarConsulta(tipoPago, "TipoPagoModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
