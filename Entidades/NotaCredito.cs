using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NotaCredito
    {
        private Guid _idNotaCredito;

        public Guid idNotaCredito
        {
            get { return _idNotaCredito; }
            set { _idNotaCredito = value; }
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

        private Venta _venta;

        public Venta venta
        {
            get { return _venta; }
            set { _venta = value; }
        }

        private string _motivo;

        public string motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }

        private float _total;

        public float total
        {
            get { return _total; }
            set { _total = value; }
        }

    }
}
