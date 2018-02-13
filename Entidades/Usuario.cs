using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private Guid _idUsuario;

        public Guid idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _DNI;

        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _contraseña;

        public string contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        private string _idioma;

        public string idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

    }
}
