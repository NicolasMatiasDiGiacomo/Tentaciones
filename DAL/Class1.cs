using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Servicios;


namespace DAL
{
    public class Class1 : conexionBD
    {
        /// <summary>
        /// prueba de conexion a la base y traer consulta
        /// CommandType para el tipo consulta, procedure, etc
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        //public override DataTable ejecutarConsulta(string consulta, CommandType tipoComando)
        //{
        //    /*conexion = new SqlConnection(cadenaConexion);
        //    comando = new SqlCommand(consulta,conexion);
        //    comando.CommandType = tipoComando;
        //    adaptador = new SqlDataAdapter(comando);
        //    dataTable = new DataTable();
        //    conexion.Open();
        //    adaptador.Fill(dataTable);
        //    conexion.Close();*/
        //    return dataTable;
        //}
    }
}
