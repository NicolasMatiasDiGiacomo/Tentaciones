using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetDireccionProv
    {
        private string _CUIT;

        public string CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        private Guid _idDireccion;

        public Guid idDireccion
        {
            get { return _idDireccion; }
            set { _idDireccion = value; }
        }

    }
}
