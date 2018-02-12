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
    public partial class Direcciones : Form
    {
        DAL.DALDireccion dalDireccion = new DAL.DALDireccion();
        Entidades.Direccion direccion = new Entidades.Direccion();
        Entidades.Direccion direccionSeleccionada = new Entidades.Direccion();
        DAL.DALPais dalPais = new DAL.DALPais();
        DAL.DALProvincia dalProvincia = new DAL.DALProvincia();
        Entidades.Provincia provinciaSeleccionada = new Entidades.Provincia();

        public Direcciones()
        {
            InitializeComponent();
            cmbPais.DataSource = dalPais.buscarPais(new Entidades.Pais());
            cmbPais.DisplayMember = "nombre";
            cmbPais.ValueMember = "idPais";
            cmbProvincia.DataSource = dalProvincia.buscarProvincia(new Entidades.Provincia());
            cmbProvincia.DisplayMember = "nombre";
            cmbProvincia.ValueMember = "idProvincia";
            
            //filtrar provincias por pais
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPais.Text) || string.IsNullOrWhiteSpace(cmbProvincia.Text) ||
                string.IsNullOrWhiteSpace(txbLocalidad.Text) || string.IsNullOrWhiteSpace(txbCalle.Text) ||
                string.IsNullOrWhiteSpace(txbDepartamento.Text) || string.IsNullOrWhiteSpace(txbPiso.Text) ||
                string.IsNullOrWhiteSpace(txbNumero.Text) || string.IsNullOrWhiteSpace(txbCodigoPostal.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            direccion.idPais = (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedIndex = 0;
            direccion.idProvincia = (Guid)cmbProvincia.SelectedValue;
            cmbProvincia.SelectedIndex = 0;
            direccion.localidad = txbLocalidad.Text;
            txbLocalidad.Clear();
            direccion.calle = txbCalle.Text;
            txbCalle.Clear();
            direccion.departamento = txbDepartamento.Text;
            txbDepartamento.Clear();
            direccion.piso = txbPiso.Text;
            txbPiso.Clear();
            direccion.numero = txbNumero.Text;
            txbNumero.Clear();
            direccion.codigoPostal = txbCodigoPostal.Text;
            txbCodigoPostal.Clear();
            dgvBusqueda.DataSource = dalDireccion.crearDireccion(direccion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            direccion.idPais = string.IsNullOrWhiteSpace(cmbPais.Text) ? Guid.Empty : (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedIndex = 0;
            direccion.idProvincia = string.IsNullOrWhiteSpace(cmbProvincia.Text) ? Guid.Empty :(Guid)cmbProvincia.SelectedValue;
            cmbProvincia.SelectedIndex = 0;
            direccion.localidad = string.IsNullOrWhiteSpace(txbLocalidad.Text) ? null : txbLocalidad.Text;
            txbLocalidad.Clear();
            direccion.calle = string.IsNullOrWhiteSpace(txbCalle.Text) ? null : txbCalle.Text;
            txbCalle.Clear();
            direccion.departamento = string.IsNullOrWhiteSpace(txbDepartamento.Text) ? null : txbDepartamento.Text;
            txbDepartamento.Clear();
            direccion.piso = string.IsNullOrWhiteSpace(txbPiso.Text) ? null : txbPiso.Text;
            txbPiso.Clear();
            direccion.numero = string.IsNullOrWhiteSpace(txbNumero.Text) ? null : txbNumero.Text;
            txbNumero.Clear();
            direccion.codigoPostal = string.IsNullOrWhiteSpace(txbCodigoPostal.Text) ? null : txbCodigoPostal.Text;
            txbCodigoPostal.Clear();
            dgvBusqueda.DataSource = dalDireccion.buscarDireccion(direccion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (direccionSeleccionada.idDireccion == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una direccion");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPais.Text) || string.IsNullOrWhiteSpace(cmbProvincia.Text) ||
                string.IsNullOrWhiteSpace(txbLocalidad.Text) || string.IsNullOrWhiteSpace(txbCalle.Text) ||
                string.IsNullOrWhiteSpace(txbDepartamento.Text) || string.IsNullOrWhiteSpace(txbPiso.Text) ||
                string.IsNullOrWhiteSpace(txbNumero.Text) || string.IsNullOrWhiteSpace(txbCodigoPostal.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            direccionSeleccionada.idPais= (Guid)cmbPais.SelectedValue;
            cmbPais.SelectedIndex = 0;
            direccionSeleccionada.idProvincia = (Guid)cmbProvincia.SelectedValue;
            cmbProvincia.SelectedIndex = 0;
            direccionSeleccionada.localidad = txbLocalidad.Text;
            txbLocalidad.Clear();
            direccionSeleccionada.calle = txbCalle.Text;
            txbCalle.Clear();
            direccionSeleccionada.departamento = txbDepartamento.Text;
            txbDepartamento.Clear();
            direccionSeleccionada.piso = txbPiso.Text;
            txbPiso.Clear();
            direccionSeleccionada.numero = txbNumero.Text;
            txbNumero.Clear();
            direccionSeleccionada.codigoPostal = txbCodigoPostal.Text;
            txbCodigoPostal.Clear();
            dgvBusqueda.DataSource = dalDireccion.modificarDireccion(direccionSeleccionada);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (direccionSeleccionada.idDireccion == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar una direccion");
                return;
            }

            cmbPais.SelectedIndex = 0;
            cmbProvincia.SelectedIndex = 0;
            txbLocalidad.Clear();
            txbCalle.Clear();
            txbDepartamento.Clear();
            txbPiso.Clear();
            txbNumero.Clear();
            txbCodigoPostal.Clear();
            dgvBusqueda.DataSource = dalDireccion.eliminarDireccion(direccionSeleccionada);
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            UI.Clientes.Paises paisForm = new UI.Clientes.Paises(this);
            paisForm.ShowDialog(this);
            cmbPais.DataSource = dalPais.buscarPais(new Entidades.Pais());
            cmbPais.DisplayMember = "nombre";
            cmbPais.ValueMember = "idPais";
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            UI.Clientes.Provincias provinciaForm = new UI.Clientes.Provincias(this);
            provinciaForm.ShowDialog(this);
            cmbProvincia.DataSource = dalProvincia.buscarProvincia(new Entidades.Provincia());
            cmbProvincia.DisplayMember = "nombre";
            cmbProvincia.ValueMember = "idProvincia";
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            direccionSeleccionada.idDireccion = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idDireccion"].Value;
            cmbPais.SelectedValue = direccionSeleccionada.idPais = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idPais"].Value;
            cmbProvincia.SelectedValue = direccionSeleccionada.idProvincia = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idProvincia"].Value;
            txbLocalidad.Text = direccionSeleccionada.localidad = dgvBusqueda.Rows[e.RowIndex].Cells["localidad"].Value.ToString();
            txbCalle.Text = direccionSeleccionada.calle = dgvBusqueda.Rows[e.RowIndex].Cells["calle"].Value.ToString();
            txbDepartamento.Text = direccionSeleccionada.departamento = dgvBusqueda.Rows[e.RowIndex].Cells["departamento"].Value.ToString();
            direccionSeleccionada.piso = dgvBusqueda.Rows[e.RowIndex].Cells["piso"].Value.ToString();
            txbPiso.Text = dgvBusqueda.Rows[e.RowIndex].Cells["piso"].Value.ToString();
            direccionSeleccionada.numero = dgvBusqueda.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txbNumero.Text = dgvBusqueda.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txbCodigoPostal.Text = direccionSeleccionada.codigoPostal = dgvBusqueda.Rows[e.RowIndex].Cells["codigoPostal"].Value.ToString();
        }
    }
}
