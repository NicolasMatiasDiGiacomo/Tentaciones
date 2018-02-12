using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALProveedor : conexionBD
    {
        public List<object> crearProveedor(Entidades.Proveedor proveedor)
        {
            try
            {
                return ejecutarConsulta(proveedor, "ProveedorCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarProveedor(Entidades.Proveedor proveedor)
        {
            try
            {
                return ejecutarConsulta(proveedor, "ProveedorEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProveedor(Entidades.Proveedor proveedor)
        {
            try
            {
                return ejecutarConsulta(proveedor, "ProveedorBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarProveedor(Entidades.Proveedor proveedor)
        {
            try
            {
                return ejecutarConsulta(proveedor, "ProveedorModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProveedorDirecciones(Entidades.Proveedor proveedor, Entidades.Direccion direccion)
        {
            try
            {
                return ejecutarConsulta(proveedor, direccion, "ProveedorBuscarDireccion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarProveedorContactos(Entidades.Proveedor proveedor, Entidades.Contacto contacto)
        {
            try
            {
                return ejecutarConsulta(proveedor, contacto, "ProveedorBuscarContacto");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> crearDetalleProveedor(Entidades.DetalleProveedor detalleProveedor)
        {
            try
            {
                return ejecutarConsulta(detalleProveedor, "ProveedorDetalleCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> crearDetDireccionProv(Entidades.DetDireccionProv detDireccionProv)
        {
            try
            {
                return ejecutarConsulta(detDireccionProv, "ProveedorDetDireccionCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarDetalleProveedor(Entidades.DetalleProveedor detalleProveedor)
        {
            try
            {
                return ejecutarConsulta(detalleProveedor, "ProveedorDetalleEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarDetDireccionProv(Entidades.DetDireccionProv detDireccionProv)
        {
            try
            {
                return ejecutarConsulta(detDireccionProv, "ProveedorDetDireccionEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
