using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALBitacora :conexionBD
    {
        public List<object> crearProveedor(Entidades.Bitacora bitacora)
        {
            try
            {
                return ejecutarConsulta(bitacora, "BitacoraCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProveedor(Entidades.Bitacora bitacora)
        {
            try
            {
                return ejecutarConsulta(bitacora, "BitacoraBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
