using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Clientes
{
    public partial class TipoPagos : Form
    {
        DAL.DALTipoPago dalTipoPago = new DAL.DALTipoPago();
        Entidades.TipoPago tipoPago = new Entidades.TipoPago();
        Entidades.TipoPago tipoPagoSeleccionado = new Entidades.TipoPago();

        public TipoPagos(Form parent)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(parent.Name))
            {
                btnBuscar.Hide();
                btnEliminar.Hide();
                btnModificar.Hide();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            tipoPago.nombre = txbNombre.Text;
            txbNombre.Clear();
            tipoPago.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoPago.crearTipoPago(tipoPago);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tipoPago.nombre = string.IsNullOrWhiteSpace(txbNombre.Text) ? null : txbNombre.Text;
            txbNombre.Clear();
            tipoPago.descripcion = string.IsNullOrWhiteSpace(txbDescripcion.Text) ? null : txbNombre.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoPago.buscarTipoPago(tipoPago);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tipoPagoSeleccionado.idTipoPago == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un tipo de pago");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            tipoPagoSeleccionado.nombre = txbNombre.Text;
            txbNombre.Clear();
            tipoPagoSeleccionado.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoPago.modificarTipoPago(tipoPagoSeleccionado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tipoPagoSeleccionado.idTipoPago == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un tipo de pago");
                return;
            }

            txbNombre.Clear();
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoPago.eliminarTipoPago(tipoPagoSeleccionado);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            tipoPagoSeleccionado.idTipoPago = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idTipoPago"].Value;
            txbNombre.Text = tipoPagoSeleccionado.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txbDescripcion.Text = tipoPagoSeleccionado.descripcion = dgvBusqueda.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
        }
    }
}
