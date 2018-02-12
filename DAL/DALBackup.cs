using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace DAL
{
    public class DALBackup : conexionBD
    {
        public List<object> crearBackup(Entidades.Backup backup)
        {
            try
            {
                return ejecutarConsulta(backup, "BackupCrear");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> restaurarBackup(Entidades.Backup backup)
        {
            try
            {
                return ejecutarConsulta(backup, "BackupRestaurar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
