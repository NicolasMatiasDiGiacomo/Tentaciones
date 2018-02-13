using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DALBitacora :conexionBD
    {
        public List<object> crearProveedor(Bitacora bitacora)
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

        public List<object> buscarProveedor(Bitacora bitacora)
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
