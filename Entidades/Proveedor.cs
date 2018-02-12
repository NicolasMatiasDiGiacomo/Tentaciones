using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        private string _CUIT;

        public string CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        private string _razonSocial;

        public string razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        /*private IList<Contacto> _contactos;

        public IList<Contacto> contactos
        {
            get { return _contactos; }
            set { _contactos = value; }
        }

        private IList<Direccion> _direcciones;

        public IList<Direccion> direcciones
        {
            get { return _direcciones; }
            set { _direcciones = value; }
        }*/
    }
}
