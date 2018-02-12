using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Entidades;

namespace Servicios
{
    abstract public class conexionBD
    {
        public string cadenaConexion
        {
            get { return string.Format("Data Source={0}\\{1};Initial Catalog={2};Integrated Security=true;", "desktop-53p4890", "sqlexpress", "Tentaciones"); }
        }

        private SqlConnection _conexion;

        public SqlConnection conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        private SqlCommand _comando;

        public SqlCommand comando
        {
            get { return _comando; }
            set { _comando = value; }
        }

        private SqlDataAdapter _adaptador;

        public SqlDataAdapter adaptador
        {
            get { return _adaptador; }
            set { _adaptador = value; }
        }


        private DataTable _dataTable;

        public DataTable dataTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }

        public void abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                conexion.Close();
                throw ex;
            }
        }

        public void setearComando(object entidad)
        {
            SqlCommandBuilder.DeriveParameters(comando);

            foreach (SqlParameter p in comando.Parameters)
            {
                if (!p.ParameterName.Contains("RETURN_VALUE"))
                {
                    string nombrePropiedad = p.ParameterName.Substring(1, p.ParameterName.Length - 1);
                    comando.Parameters[p.ParameterName].Value = entidad.GetType().GetProperty(nombrePropiedad).GetValue(entidad) ?? DBNull.Value;
                }

            }
            //for para recorrer el diccionario o lo que sea
            //fijarse como hacer el getType para pasar cualquier clase de "Entidades" y cargar correctamente los valores
            //no funciona con clases dentro de clases o propiedades no propias de sql
        }


        public List<object> leerComando(Type tipoEntidad)
        {
            List<object> lista = new List<object>();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                object entidad = Activator.CreateInstance(tipoEntidad);
                for (int i = 0; i < entidad.GetType().GetProperties().Length; i++)
                {
                    if (lector.GetType().ToString() == "System.Guid")
                    {
                        entidad.GetType().GetProperty(entidad.GetType().GetProperties()[i].Name).SetValue(entidad, Convert.ChangeType(
                            Guid.Parse(lector.GetValue(lector.GetOrdinal(entidad.GetType().GetProperties()[i].Name)).ToString()),
                            entidad.GetType().GetProperties()[i].PropertyType));
                    }
                    else
                    {
                        entidad.GetType().GetProperty(entidad.GetType().GetProperties()[i].Name).SetValue(entidad, Convert.ChangeType(
                            lector.GetValue(lector.GetOrdinal(entidad.GetType().GetProperties()[i].Name)), entidad.GetType().GetProperties()[i].PropertyType));
                    }
                }
                lista.Add(entidad);
            }
            lector.Close();
            return lista;
        }

        public List<object> ejecutarConsulta(object objeto, string consulta)
        {
            return ejecutarConsulta(objeto, objeto, consulta);
        }

        public List<object> ejecutarConsulta(object objetoEntrada, object objetoSalida, string consulta)
        {
            List<object> lista = new List<object>();
            try
            {
                abrirConexion();
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                setearComando(objetoEntrada);
                lista = leerComando(objetoSalida.GetType());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conexion.Close();
            return lista;
        }

        //abstract public DataTable ejecutarConsulta(string consulta, CommandType tipoComando);

    }
}
