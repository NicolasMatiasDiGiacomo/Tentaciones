using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Pago
    {
        private Guid _idPago;

        public Guid idPago
        {
            get { return _idPago; }
            set { _idPago = value; }
        }

        private Cliente _cliente;

        public Cliente cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private TipoPago _tipoPago;

        public TipoPago tipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private float _monto;

        public float monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

    }
}
