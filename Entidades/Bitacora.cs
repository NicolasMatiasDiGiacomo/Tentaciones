using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bitacora
    {
        private Guid _idBitacora;

        public Guid idBitacora
        {
            get { return _idBitacora; }
            set { _idBitacora = value; }
        }

        private DateTime _fechaHora;

        public DateTime fechaHora
        {
            get { return _fechaHora; }
            set { _fechaHora = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _accion;
            
        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _error;

        public string error
        {
            get { return _error; }
            set { _error = value; }
        }

    }
}
