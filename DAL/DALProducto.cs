using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALProducto : conexionBD
    {
        public List<object> crearProducto(Entidades.Producto producto)
        {
            try
            {
                return ejecutarConsulta(producto, "ProductoCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarProducto(Entidades.Producto producto)
        {
            try
            {
                return ejecutarConsulta(producto, "ProductoEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProducto(Entidades.Producto producto)
        {
            try
            {
                return ejecutarConsulta(producto, "ProductoBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarProducto(Entidades.Producto producto)
        {
            try
            {
                return ejecutarConsulta(producto, "ProductoModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
