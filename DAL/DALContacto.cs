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
    public class DALContacto : conexionBD
    {
        public List<object> crearContacto(Entidades.Contacto contacto)
        {
            try
            {
                return ejecutarConsulta(contacto, "ContactoCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarContacto(Entidades.Contacto contacto)
        {
            try
            {
                return ejecutarConsulta(contacto, "ContactoEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarContacto(Entidades.Contacto contacto)
        {
            try
            {
                return ejecutarConsulta(contacto, "ContactoBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> modificarContacto(Entidades.Contacto contacto)
        {
            try
            {
                return ejecutarConsulta(contacto, "ContactoModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
