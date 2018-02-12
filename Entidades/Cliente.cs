using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        private string _CUIL;

        public string CUIL
        {
            get { return _CUIL; }
            set { _CUIL = value; }
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

        private Pais _pais;

        public Pais pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        private DateTime _fechaNacimiento;

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private float _credito;

        public float credito
        {
            get { return _credito; }
            set { _credito = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private IList<Contacto> _contactos;

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
        }

    }
}
