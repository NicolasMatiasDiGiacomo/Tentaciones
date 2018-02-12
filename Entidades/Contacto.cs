using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contacto
    {
        private Guid _idContacto;

        public Guid idContacto
        {
            get { return _idContacto; }
            set { _idContacto = value; }
        }

        private string _mail;

        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
