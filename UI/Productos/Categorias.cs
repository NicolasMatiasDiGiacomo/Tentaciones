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
    public partial class Categoria : Form
    {
        DAL.DALCategoria dalCategoria = new DAL.DALCategoria();
        Entidades.Categoria categoria = new Entidades.Categoria();
        Entidades.Categoria categoriaSeleccionada = new Entidades.Categoria();
        public Categoria(Form parent)
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

            categoria.nombre = txbNombre.Text;
            txbNombre.Clear();
            categoria.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalCategoria.crearCategoria(categoria);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            categoria.nombre = string.IsNullOrWhiteSpace(txbNombre.Text) ? null : txbNombre.Text;
            txbNombre.Clear();
            categoria.descripcion = string.IsNullOrWhiteSpace(txbDescripcion.Text) ? null : txbNombre.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalCategoria.buscarCategoria(categoria);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada.idCategoria == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            categoriaSeleccionada.nombre = txbNombre.Text;
            txbNombre.Clear();
            categoriaSeleccionada.descripcion = txbDescripcion.Text;
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalCategoria.ModificarCategoria(categoriaSeleccionada);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada.idCategoria == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return;
            }

            txbNombre.Clear();
            txbDescripcion.Clear();
            dgvBusqueda.DataSource = dalCategoria.eliminarCategoria(categoriaSeleccionada);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            categoriaSeleccionada.idCategoria = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idCategoria"].Value;
            txbNombre.Text = categoriaSeleccionada.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txbDescripcion.Text = categoriaSeleccionada.descripcion = dgvBusqueda.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
        }
    }
}
