using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleProveedor
    {
        private string _CUIT;

        public string CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        private Guid _idContacto;

        public Guid idContacto
        {
            get { return _idContacto; }
            set { _idContacto = value; }
        }

    }
}
