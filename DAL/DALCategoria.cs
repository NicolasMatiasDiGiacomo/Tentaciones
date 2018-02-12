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
    public class DALCategoria : conexionBD
    {
        public List<object> crearCategoria(Entidades.Categoria categoria)
        {
            try
            {
                return ejecutarConsulta(categoria, "CategoriaCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> eliminarCategoria(Entidades.Categoria categoria)
        {
            try
            {
                return ejecutarConsulta(categoria, "CategoriaEliminar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> buscarCategoria(Entidades.Categoria categoria)
        {
            try
            {
                return ejecutarConsulta(categoria, "CategoriaBuscar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> ModificarCategoria(Entidades.Categoria categoria)
        {
            try
            {
                return ejecutarConsulta(categoria, "CategoriaModificar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
