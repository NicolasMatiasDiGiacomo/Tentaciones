using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Direccion
    {
        private Guid _idDireccion;

        public Guid idDireccion
        {
            get { return _idDireccion; }
            set { _idDireccion = value; }
        }

        private Guid _idPais;

        public Guid idPais
        {
            get { return _idPais; }
            set { _idPais = value; }
        }

        private Guid _idProvincia;

        public Guid idProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }

        private string _localidad;

        public string localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        private string _codigoPostal;

        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        private string _calle;

        public string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        private string _piso;

        public string piso
        {
            get { return _piso; }
            set { _piso = value; }
        }

        private string _departamento;

        public string departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private string _numero;

        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
    }
}
