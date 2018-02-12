using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using DAL;
using Entidades;


namespace UI.Cliente
{
    public partial class Cliente : Form
    {
        DAL.DALContacto dalContacto = new DAL.DALContacto();
        Entidades.Contacto contacto = new Entidades.Contacto();
        Entidades.Contacto contactoSeleccionado = new Entidades.Contacto();
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnGuardarContacto_Click(object sender, EventArgs e)
        {
            contacto.apellido = string.IsNullOrWhiteSpace(txbApellidosContacto.Text) ? null : txbApellidosContacto.Text;
            contacto.nombre = string.IsNullOrWhiteSpace(txbNombresContacto.Text) ? null : txbNombresContacto.Text;
            contacto.mail = string.IsNullOrWhiteSpace(txbMail.Text) ? null : txbMail.Text;
            contacto.telefono = string.IsNullOrWhiteSpace(txbTelefono.Text) ? null : txbTelefono.Text;
            //dalContacto.CrearContacto(contacto);

            //contacto.idContacto = Guid.Parse("DCEE7BE6-E7A3-4F6E-9313-BD9A7E22D4F5");
            //dalContacto.EliminarContacto(contacto);

            //dgvContacto.DataSource = dalContacto.ejecutarConsulta("select* from[Tentaciones].INFORMATION_SCHEMA.PARAMETERSwhere specific_name = 'ObtenerParametros'; ", CommandType.Text);
            dgvContacto.DataSource = dalContacto.buscarContacto(contacto);
        }

        private void dgvContacto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            contactoSeleccionado.idContacto = (Guid)dgvContacto.Rows[e.RowIndex].Cells["idContacto"].Value;
            contactoSeleccionado.mail = dgvContacto.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            contactoSeleccionado.telefono = dgvContacto.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            contactoSeleccionado.apellido = dgvContacto.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            contactoSeleccionado.nombre = dgvContacto.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
        }

        private void btnGuardarDireccion_Click(object sender, EventArgs e)
        {
            dgvContacto.DataSource = dalContacto.eliminarContacto(contactoSeleccionado);
            dgvContacto.DataSource = dalContacto.buscarContacto(contacto);
        }
    }
}
