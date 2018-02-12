using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NotaDebito
    {
        private Guid _notaDebito;

        public Guid notaDebito
        {
            get { return _notaDebito; }
            set { _notaDebito = value; }
        }

        private Venta _venta;

        public Venta venta
        {
            get { return _venta; }
            set { _venta = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
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
