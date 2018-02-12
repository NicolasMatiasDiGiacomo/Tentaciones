using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Ventas
{
    public partial class TipoFacturas : Form
    {
        DAL.DALTipoFactura dalTipoFactura = new DAL.DALTipoFactura();
        Entidades.TipoFactura tipoFactura = new Entidades.TipoFactura();
        Entidades.TipoFactura tipoFacturaSeleccionado = new Entidades.TipoFactura();

        public TipoFacturas(Form parent)
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

            tipoFactura.nombre = txbNombre.Text;
            txbNombre.Clear();
            tipoFactura.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoFactura.crearTipoFactura(tipoFactura);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tipoFactura.nombre = string.IsNullOrWhiteSpace(txbNombre.Text) ? null : txbNombre.Text;
            txbNombre.Clear();
            tipoFactura.descripcion = string.IsNullOrWhiteSpace(txbDescripcion.Text) ? null : txbNombre.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoFactura.buscarTipoFactura(tipoFactura);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tipoFacturaSeleccionado.idTipoFactura == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un tipo de factura");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            tipoFacturaSeleccionado.nombre = txbNombre.Text;
            txbNombre.Clear();
            tipoFacturaSeleccionado.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoFactura.modificarTipoFactura(tipoFacturaSeleccionado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tipoFacturaSeleccionado.idTipoFactura == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un tipo de factura");
                return;
            }

            txbNombre.Clear();
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalTipoFactura.eliminarTipoFactura(tipoFacturaSeleccionado);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            tipoFacturaSeleccionado.idTipoFactura = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idTipoFactura"].Value;
            txbNombre.Text = tipoFacturaSeleccionado.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txbDescripcion.Text = tipoFacturaSeleccionado.descripcion = dgvBusqueda.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
        }
    }
}
