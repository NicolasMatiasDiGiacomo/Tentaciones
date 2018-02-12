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
    public partial class Provincias : Form
    {
        DAL.DALProvincia dalProvincia = new DAL.DALProvincia();
        DAL.DALPais dalPais = new DAL.DALPais();
        Entidades.Provincia provincia = new Entidades.Provincia();
        Entidades.Provincia provinciaSeleccionada = new Entidades.Provincia();

        public Provincias(Form parent)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(parent.Name))
            {
                btnBuscar.Hide();
                btnEliminar.Hide();
                btnModificar.Hide();
            }
            cmbPais.DataSource = dalPais.buscarPais(new Entidades.Pais());
            cmbPais.DisplayMember = "nombre";
            cmbPais.ValueMember = "idPais";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbProvincia.Text) || string.IsNullOrWhiteSpace(cmbPais.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            provincia.nombre = txbProvincia.Text;
            txbProvincia.Clear();
            provincia.idPais = (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedValue = 0;
            dgvBusqueda.DataSource = dalProvincia.crearProvincia(provincia);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            provincia.nombre = string.IsNullOrWhiteSpace(txbProvincia.Text) ? null : txbProvincia.Text;
            txbProvincia.Clear();
            provincia.idPais = string.IsNullOrWhiteSpace(cmbPais.Text) ? Guid.Empty : (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedValue = 0;
            dgvBusqueda.DataSource = dalProvincia.buscarProvincia(provincia);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (provinciaSeleccionada.idProvincia == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una provincia");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbProvincia.Text) || string.IsNullOrWhiteSpace(cmbPais.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            provinciaSeleccionada.idPais = (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedIndex = 0;
            provinciaSeleccionada.nombre = txbProvincia.Text;
            txbProvincia.Clear();
            dgvBusqueda.DataSource = dalProvincia.modificarProvincia(provinciaSeleccionada);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (provinciaSeleccionada.idProvincia == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una provincia");
                return;
            }

            cmbPais.SelectedIndex = 0;
            txbProvincia.Clear();
            dgvBusqueda.DataSource = dalProvincia.eliminarProvincia(provinciaSeleccionada);
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            UI.Clientes.Paises paisForm = new UI.Clientes.Paises(this);
            paisForm.ShowDialog(this);
            cmbPais.DataSource = dalPais.buscarPais(new Entidades.Pais());
            cmbPais.DisplayMember = "nombre";
            cmbPais.ValueMember = "idPais";
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            provinciaSeleccionada.idProvincia = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idProvincia"].Value;
            cmbPais.SelectedValue = provinciaSeleccionada.idPais = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idPais"].Value;
            txbProvincia.Text = provinciaSeleccionada.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
        }
    }
}
