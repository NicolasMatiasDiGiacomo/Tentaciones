using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pais
    {
        private Guid _idPais;

        public Guid idPais
        {
            get { return _idPais; }
            set { _idPais = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _nacionalidad;

        public string nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

    }
}
