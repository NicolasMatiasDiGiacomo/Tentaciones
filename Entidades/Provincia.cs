using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private Guid _idProvincia;

        public Guid idProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private Guid _idPais;

        public Guid idPais
        {
            get { return _idPais; }
            set { _idPais = value; }
        }

    }
}
