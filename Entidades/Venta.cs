using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Venta
    {
        private Guid _idVenta;

        public Guid idVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        private Cliente _cliente;

        public Cliente cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private float _total;

        public float total
        {
            get { return _total; }
            set { _total = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private IDictionary<Producto, int> _productos;

        public IDictionary<Producto, int> productos
        {
            get { return _productos; }
            set { _productos = value; }
        }
    }
}
