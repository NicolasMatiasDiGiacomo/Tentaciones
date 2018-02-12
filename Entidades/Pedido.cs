using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Pedido
    {
        private Guid _idPedido;

        public Guid idPedido
        {
            get { return _idPedido; }
            set { _idPedido = value; }
        }

        private Proveedor _proveedor;

        public Proveedor proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
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

        private IDictionary<Producto,int> _cantidades;

        public IDictionary<Producto,int> cantidades
        {
            get { return _cantidades; }
            set { _cantidades = value; }
        }

        private IDictionary<Producto, DetallePedido> _precioUnitario;

        public IDictionary<Producto, DetallePedido> precioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        public class DetallePedido
        {
            public int cantidad { get; set; }

            public float precio { get; set; }
        }
    }
}
