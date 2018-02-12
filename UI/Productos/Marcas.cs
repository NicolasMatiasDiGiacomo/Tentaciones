using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Producto
{
    public partial class Marca : Form
    {
        DAL.DALMarca dalMarca = new DAL.DALMarca();
        Entidades.Marca marca = new Entidades.Marca();
        Entidades.Marca marcaSeleccionada = new Entidades.Marca();
        public Marca(Form parent)
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

            marca.nombre = txbNombre.Text;
            txbNombre.Clear();
            marca.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalMarca.crearMarcar(marca);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            marca.nombre = string.IsNullOrWhiteSpace(txbNombre.Text) ? null : txbNombre.Text;
            txbNombre.Clear();
            marca.descripcion = string.IsNullOrWhiteSpace(txbDescripcion.Text) ? null : txbNombre.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalMarca.buscarMarca(marca);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            marcaSeleccionada.idMarca = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idMarca"].Value;
            txbNombre.Text = marcaSeleccionada.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txbDescripcion.Text = marcaSeleccionada.descripcion = dgvBusqueda.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (marcaSeleccionada.idMarca == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una marca");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            marcaSeleccionada.nombre = txbNombre.Text;
            txbNombre.Clear();
            marcaSeleccionada.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalMarca.modificarMarca(marcaSeleccionada);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (marcaSeleccionada.idMarca == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una marca");
                return;
            }

            txbNombre.Clear();
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalMarca.eliminarMarca(marcaSeleccionada);
        }
    }
}
