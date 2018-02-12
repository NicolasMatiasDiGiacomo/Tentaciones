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
    public partial class Paises : Form
    {
        DAL.DALPais dalPais = new DAL.DALPais();
        Entidades.Pais pais = new Entidades.Pais();
        Entidades.Pais paisSeleccionado = new Entidades.Pais();
        public Paises(Form parent)
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
            if (string.IsNullOrWhiteSpace(txbPais.Text) || string.IsNullOrWhiteSpace(txbNacionalidad.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            pais.nombre = txbPais.Text;
            txbPais.Clear();
            pais.nacionalidad = txbNacionalidad.Text;
            txbNacionalidad.Clear();
            dgvBusqueda.DataSource = dalPais.crearPais(pais);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pais.nombre = string.IsNullOrWhiteSpace(txbPais.Text) ? null : txbPais.Text;
            txbPais.Clear();
            pais.nacionalidad = string.IsNullOrWhiteSpace(txbNacionalidad.Text) ? null : txbNacionalidad.Text;
            txbNacionalidad.Clear();
            dgvBusqueda.DataSource = dalPais.buscarPais(pais);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (paisSeleccionado.idPais == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un pais");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbPais.Text) || string.IsNullOrWhiteSpace(txbNacionalidad.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            paisSeleccionado.nombre = txbPais.Text;
            txbPais.Clear();
            paisSeleccionado.nacionalidad = txbNacionalidad.Text;
            txbNacionalidad.Clear();
            dgvBusqueda.DataSource = dalPais.modificarPais(paisSeleccionado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (paisSeleccionado.idPais == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un pais");
                return;
            }

            txbPais.Clear();
            txbNacionalidad.Clear();
            dgvBusqueda.DataSource = dalPais.eliminarPais(paisSeleccionado);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            paisSeleccionado.idPais = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idPais"].Value;
            txbPais.Text = paisSeleccionado.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txbNacionalidad.Text = paisSeleccionado.nacionalidad = dgvBusqueda.Rows[e.RowIndex].Cells["nacionalidad"].Value.ToString();
        }
    }
}
