using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private Guid _idProducto;

        public Guid idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private Guid _idCategoria;

        public Guid idCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private Guid _idMarca;

        public Guid idMarca
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private float _alto;

        public float alto
        {
            get { return _alto; }
            set { _alto = value; }
        }

        private float _ancho;

        public float ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        private float _largo;

        public float largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        private float _peso;

        public float peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private float _precioUnitarioCompra;

        public float precioUnitarioCompra
        {
            get { return _precioUnitarioCompra; }
            set { _precioUnitarioCompra = value; }
        }

        private float _precioUnitarioVenta;

        public float precioUnitarioVenta
        {
            get { return _precioUnitarioVenta; }
            set { _precioUnitarioVenta = value; }
        }

        private int _stockMinimo;

        public int stockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }

        private int _stockMaximo;

        public int stockMaximo
        {
            get { return _stockMaximo; }
            set { _stockMaximo = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}
