using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Factura
    {
        private Guid _idFactura;

        public Guid idFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        private TipoFactura _tipoFactura;

        public TipoFactura tipoFactura
        {
            get { return _tipoFactura; }
            set { _tipoFactura = value; }
        }

        private TipoPago _tipoPago;

        public TipoPago tipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }

        private float _total;

        public float total
        {
            get { return _total; }
            set { _total = value; }
        }

        private IList<Venta> _ventas;

        public IList<Venta> ventas
        {
            get { return _ventas; }
            set { _ventas = value; }
        }

    }
}
