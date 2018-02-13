using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DALBackup : conexionBD
    {
        public List<object> crearBackup(Backup backup)
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

        public List<object> restaurarBackup(Backup backup)
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
