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
    public partial class Contactos : Form
    {
        DAL.DALContacto dalContacto = new DAL.DALContacto();
        Entidades.Contacto contacto = new Entidades.Contacto();
        Entidades.Contacto contactoSeleccionado = new Entidades.Contacto();

        public Contactos(Form parent)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(parent.Name))
            {
                btnBuscar.Hide();
                btnEliminar.Hide();
                btnModificar.Hide();
            }
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            contactoSeleccionado.idContacto = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idContacto"].Value;
            txbMail.Text = contactoSeleccionado.mail = dgvBusqueda.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            txbTelefono.Text = contactoSeleccionado.telefono = dgvBusqueda.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            txbApellidos.Text = contactoSeleccionado.apellido = dgvBusqueda.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            txbNombres.Text = contactoSeleccionado.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbApellidos.Text) || string.IsNullOrWhiteSpace(txbNombres.Text) ||
                string.IsNullOrWhiteSpace(txbMail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) )
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            contacto.apellido = txbApellidos.Text;
            txbApellidos.Clear();
            contacto.nombre = txbNombres.Text;
            txbNombres.Clear();
            contacto.mail = txbMail.Text;
            txbMail.Clear();
            contacto.telefono = txbTelefono.Text;
            txbTelefono.Clear();
            dgvBusqueda.DataSource = dalContacto.crearContacto(contacto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            contacto.apellido = string.IsNullOrWhiteSpace(txbApellidos.Text) ? null : txbApellidos.Text;
            txbApellidos.Clear();
            contacto.nombre = string.IsNullOrWhiteSpace(txbNombres.Text) ? null : txbNombres.Text;
            txbNombres.Clear();
            contacto.mail = string.IsNullOrWhiteSpace(txbMail.Text) ? null : txbMail.Text;
            txbMail.Clear();
            contacto.telefono= string.IsNullOrWhiteSpace(txbTelefono.Text) ? null : txbTelefono.Text;
            txbTelefono.Clear();
            dgvBusqueda.DataSource = dalContacto.buscarContacto(contacto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionado.idContacto == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un contacto");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbApellidos.Text) || string.IsNullOrWhiteSpace(txbNombres.Text) ||
                string.IsNullOrWhiteSpace(txbMail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            contactoSeleccionado.apellido = txbApellidos.Text;
            txbApellidos.Clear();
            contactoSeleccionado.nombre = txbNombres.Text;
            txbNombres.Clear();
            contactoSeleccionado.mail = txbMail.Text;
            txbMail.Clear();
            contactoSeleccionado.telefono = txbTelefono.Text;
            txbTelefono.Clear();
            dgvBusqueda.DataSource = dalContacto.modificarContacto(contactoSeleccionado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionado.idContacto == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un contacto");
                return;
            }

            txbApellidos.Clear();
            txbNombres.Clear();
            txbMail.Clear();
            txbTelefono.Clear();
            dgvBusqueda.DataSource = dalContacto.eliminarContacto(contactoSeleccionado);
        }
    }
}
