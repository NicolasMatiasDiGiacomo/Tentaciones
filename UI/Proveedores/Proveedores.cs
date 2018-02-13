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

namespace UI.Proveedor
{
    public partial class Proveedor : Form
    {
        DAL.DALProveedor dalProveedor = new DAL.DALProveedor();
        DAL.DALContacto dalContacto = new DAL.DALContacto();
        DAL.DALDireccion dalDireccion = new DAL.DALDireccion();
        DALBitacora dalBitacora = new DALBitacora();
        Entidades.Proveedor proveedor = new Entidades.Proveedor();
        Entidades.Proveedor proveedorSeleccionado = new Entidades.Proveedor();
        Entidades.Contacto contactoSeleccionado = new Entidades.Contacto();
        Entidades.Contacto contactoAsignadoSeleccionado = new Entidades.Contacto();
        Entidades.Direccion direccionSeleccionada = new Entidades.Direccion();
        Entidades.Direccion direccionAsignadaSeleccionada = new Entidades.Direccion();
        Bitacora bitacora = new Bitacora();
        List<object> listaContactos = new List<object>();
        List<object> listaDirecciones = new List<object>();
        List<object> listaContactosAsignados = new List<object>();
        List<object> listaDireccionesAsignadas = new List<object>();
        int filaContactoSeleccionado = -1;
        int filaContactoAsignadoSeleccionado = -1;
        int filaDireccionSeleccionada = -1;
        int filaDireccionAsignadoSeleccionada = -1;
        public Proveedor()
        {
            InitializeComponent();
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado("Disponible", 0));
            estados.Add(new Estado("No disponible", 1));
            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "text";
            cmbEstado.ValueMember = "value";
            dgvContactosDisponibles.DataSource = listaContactos = dalContacto.buscarContacto(new Entidades.Contacto());
            dgvDireccionesDisponibles.DataSource =  listaDirecciones = dalDireccion.buscarDireccion(new Entidades.Direccion());
        }

        private void btnPonerContacto_Click(object sender, EventArgs e)
        {
            if (filaContactoSeleccionado < 0)
            {
                MessageBox.Show("Debe seleccionar un contacto");
                return;
            }

            Entidades.Contacto contacto = new Entidades.Contacto();
            contacto = contactoAsignadoSeleccionado;
            listaContactosAsignados.Add(contacto);
            dgvContactosAsignados.DataSource = null;
            dgvContactosAsignados.DataSource = listaContactosAsignados;
            listaContactos.RemoveAt(filaContactoSeleccionado);
            dgvContactosDisponibles.DataSource = null;
            dgvContactosDisponibles.DataSource = listaContactos;
            filaContactoSeleccionado = -1;
        }

        private void btnSacarContacto_Click(object sender, EventArgs e)
        {
            if (filaContactoAsignadoSeleccionado < 0)
            {
                MessageBox.Show("Debe seleccionar un contacto asignado");
                return;
            }

            Entidades.Contacto contacto = new Entidades.Contacto();
            contacto = contactoSeleccionado;
            listaContactos.Add(contacto);
            dgvContactosDisponibles.DataSource = null;
            dgvContactosDisponibles.DataSource = listaContactos;
            listaContactosAsignados.RemoveAt(filaContactoAsignadoSeleccionado);
            dgvContactosAsignados.DataSource = null;
            dgvContactosAsignados.DataSource = listaContactosAsignados;
            filaContactoAsignadoSeleccionado = -1;
        }

        private void dgvContactosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Entidades.Contacto contacto = new Entidades.Contacto();
            contacto.idContacto = (Guid)dgvContactosDisponibles.Rows[e.RowIndex].Cells["idContacto"].Value;
            contacto.mail = dgvContactosDisponibles.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            contacto.telefono = dgvContactosDisponibles.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            contacto.apellido = dgvContactosDisponibles.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            contacto.nombre = dgvContactosDisponibles.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            contactoAsignadoSeleccionado = contacto;
            filaContactoSeleccionado = e.RowIndex;
        }

        private void dgvContactosAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Entidades.Contacto contacto = new Entidades.Contacto();
            contacto.idContacto = (Guid)dgvContactosAsignados.Rows[e.RowIndex].Cells["idContacto"].Value;
            contacto.mail = dgvContactosAsignados.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            contacto.telefono = dgvContactosAsignados.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            contacto.apellido = dgvContactosAsignados.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            contacto.nombre = dgvContactosAsignados.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            contactoSeleccionado = contacto;
            filaContactoAsignadoSeleccionado = e.RowIndex;
        }

        private void dgvDireccionesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Entidades.Direccion direccion = new Entidades.Direccion();
            direccion.idDireccion = (Guid)dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["idDireccion"].Value;
            direccion.idPais = (Guid)dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["idPais"].Value;
            direccion.idProvincia = (Guid)dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["idProvincia"].Value;
            direccion.localidad = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["localidad"].Value.ToString();
            direccion.codigoPostal = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["codigoPostal"].Value.ToString();
            direccion.calle = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["calle"].Value.ToString();
            direccion.piso = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["piso"].Value.ToString();
            direccion.departamento = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["departamento"].Value.ToString();
            direccion.numero = dgvDireccionesDisponibles.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            direccionAsignadaSeleccionada = direccion;
            filaDireccionSeleccionada = e.RowIndex;
        }


        private void dgvDireccionesAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Entidades.Direccion direccion = new Entidades.Direccion();
            direccion.idDireccion = (Guid)dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["idDireccion"].Value;
            direccion.idPais = (Guid)dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["idPais"].Value;
            direccion.idProvincia = (Guid)dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["idProvincia"].Value;
            direccion.localidad = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["localidad"].Value.ToString();
            direccion.codigoPostal = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["codigoPostal"].Value.ToString();
            direccion.calle = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["calle"].Value.ToString();
            direccion.piso = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["piso"].Value.ToString();
            direccion.departamento = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["departamento"].Value.ToString();
            direccion.numero = dgvDireccionesAsignadas.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            direccionSeleccionada = direccion;
            filaDireccionAsignadoSeleccionada = e.RowIndex;
        }

        private void btnPonerDireccion_Click(object sender, EventArgs e)
        {
            if (filaDireccionSeleccionada < 0)
            {
                MessageBox.Show("Debe seleccionar una direccion");
                return;
            }

            Entidades.Direccion direccion = new Entidades.Direccion();
            direccion = direccionAsignadaSeleccionada;
            listaDireccionesAsignadas.Add(direccion);
            dgvDireccionesAsignadas.DataSource = null;
            dgvDireccionesAsignadas.DataSource = listaDireccionesAsignadas;
            listaDirecciones.RemoveAt(filaDireccionSeleccionada);
            dgvDireccionesDisponibles.DataSource = null;
            dgvDireccionesDisponibles.DataSource = listaDirecciones;
            filaDireccionSeleccionada = -1;
        }

        private void btnSacarDireccion_Click(object sender, EventArgs e)
        {
            if (filaDireccionAsignadoSeleccionada < 0)
            {
                MessageBox.Show("Debe seleccionar una direccion asignada");
                return;
            }

            Entidades.Direccion direccion = new Entidades.Direccion();
            direccion = direccionSeleccionada;
            listaDirecciones.Add(direccion);
            dgvDireccionesDisponibles.DataSource = null;
            dgvDireccionesDisponibles.DataSource = listaDirecciones;
            listaDireccionesAsignadas.RemoveAt(filaDireccionAsignadoSeleccionada);
            dgvDireccionesAsignadas.DataSource = null;
            dgvDireccionesAsignadas.DataSource = listaDireccionesAsignadas;
            filaDireccionAsignadoSeleccionada = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCUIL.Text) || string.IsNullOrWhiteSpace(txbRazonSocial.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            proveedor.CUIT = txbCUIL.Text;
            txbCUIL.Clear();
            proveedor.razonSocial = txbRazonSocial.Text;
            txbRazonSocial.Clear();
            proveedor.estado = Convert.ToBoolean((int)cmbEstado.SelectedValue);
            cmbEstado.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProveedor.crearProveedor(proveedor);
            foreach(Entidades.Contacto c in listaContactosAsignados)
            {
                Entidades.DetalleProveedor detalleProveedor = new Entidades.DetalleProveedor();
                detalleProveedor.CUIT = proveedor.CUIT;
                detalleProveedor.idContacto = c.idContacto; 
                dalProveedor.crearDetalleProveedor(detalleProveedor);
            }
            foreach (Entidades.Direccion d in listaDireccionesAsignadas)
            {
                Entidades.DetDireccionProv detDireccionProv = new Entidades.DetDireccionProv();
                detDireccionProv.CUIT = proveedor.CUIT;
                detDireccionProv.idDireccion = d.idDireccion;
                dalProveedor.crearDetDireccionProv(detDireccionProv);
            }
            dgvContactosAsignados.DataSource = dgvDireccionesAsignadas.DataSource = null;
            listaContactosAsignados = new List<object>();
            listaDireccionesAsignadas = new List<object>();
            dgvContactosDisponibles.DataSource = listaContactos = dalContacto.buscarContacto(new Entidades.Contacto());
            dgvDireccionesDisponibles.DataSource = listaDirecciones = dalDireccion.buscarDireccion(new Entidades.Direccion());
            bitacora.fechaHora = DateTime.Now;
            bitacora.tipo = "Usuario";
            bitacora.usuario = "No tengo";
            bitacora.accion = "Crear";
            bitacora.descripcion = "Crear nuevo proveedor";
            dalBitacora.crearProveedor(bitacora);   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            proveedor.CUIT = string.IsNullOrWhiteSpace(txbCUIL.Text) ? null : txbCUIL.Text;
            txbCUIL.Clear();
            proveedor.razonSocial = string.IsNullOrWhiteSpace(txbRazonSocial.Text) ? null : txbRazonSocial.Text;
            txbRazonSocial.Clear();
            proveedor.estado = Convert.ToBoolean((int)cmbEstado.SelectedValue);
            cmbEstado.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProveedor.buscarProveedor(proveedor);
            dgvContactosAsignados.DataSource = dgvDireccionesAsignadas.DataSource = null;
            listaContactosAsignados = new List<object>();
            listaDireccionesAsignadas = new List<object>();
            dgvContactosDisponibles.DataSource = listaContactos = dalContacto.buscarContacto(new Entidades.Contacto());
            dgvDireccionesDisponibles.DataSource = listaDirecciones = dalDireccion.buscarDireccion(new Entidades.Direccion());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(proveedorSeleccionado.CUIT))
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCUIL.Text) || string.IsNullOrWhiteSpace(txbRazonSocial.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            proveedorSeleccionado.CUIT = txbCUIL.Text;
            txbCUIL.Clear();
            proveedorSeleccionado.razonSocial= txbRazonSocial.Text;
            txbRazonSocial.Clear();
            proveedorSeleccionado.estado = Convert.ToBoolean((int)cmbEstado.SelectedValue);
            cmbEstado.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProveedor.modificarProveedor(proveedorSeleccionado);
            Entidades.DetalleProveedor detalleProveedor = new Entidades.DetalleProveedor();
            detalleProveedor.CUIT = proveedorSeleccionado.CUIT;
            dalProveedor.eliminarDetalleProveedor(detalleProveedor);
            foreach (Entidades.Contacto c in listaContactosAsignados)
            {
                detalleProveedor.idContacto = c.idContacto;
                dalProveedor.crearDetalleProveedor(detalleProveedor);
            }
            Entidades.DetDireccionProv detDireccionProv = new Entidades.DetDireccionProv();
            detDireccionProv.CUIT = proveedorSeleccionado.CUIT;
            dalProveedor.eliminarDetDireccionProv(detDireccionProv);
            foreach (Entidades.Direccion d in listaDireccionesAsignadas)
            {
                detDireccionProv.idDireccion = d.idDireccion;
                dalProveedor.crearDetDireccionProv(detDireccionProv);
            }
            dgvContactosAsignados.DataSource = dgvDireccionesAsignadas.DataSource = null;
            listaContactosAsignados = new List<object>();
            listaDireccionesAsignadas = new List<object>();
            dgvContactosDisponibles.DataSource = listaContactos = dalContacto.buscarContacto(new Entidades.Contacto());
            dgvDireccionesDisponibles.DataSource = listaDirecciones = dalDireccion.buscarDireccion(new Entidades.Direccion());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(proveedorSeleccionado.CUIT))
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }

            txbCUIL.Clear();
            txbRazonSocial.Clear();
            cmbEstado.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProveedor.eliminarProveedor(proveedorSeleccionado);
            dgvContactosAsignados.DataSource = dgvDireccionesAsignadas.DataSource = null;
            listaContactosAsignados = new List<object>();
            listaDireccionesAsignadas = new List<object>();
            dgvContactosDisponibles.DataSource = listaContactos = dalContacto.buscarContacto(new Entidades.Contacto());
            dgvDireccionesDisponibles.DataSource = listaDirecciones = dalDireccion.buscarDireccion(new Entidades.Direccion());
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txbCUIL.Text = proveedorSeleccionado.CUIT= dgvBusqueda.Rows[e.RowIndex].Cells["CUIT"].Value.ToString();
            txbRazonSocial.Text = proveedorSeleccionado.razonSocial = dgvBusqueda.Rows[e.RowIndex].Cells["razonSocial"].Value.ToString();
            proveedorSeleccionado.estado = Convert.ToBoolean(dgvBusqueda.Rows[e.RowIndex].Cells["estado"].Value);
            cmbEstado.SelectedIndex = Convert.ToInt32(dgvBusqueda.Rows[e.RowIndex].Cells["estado"].Value);
            dgvDireccionesAsignadas.DataSource = listaDireccionesAsignadas = dalProveedor.buscarProveedorDirecciones(proveedorSeleccionado, new Entidades.Direccion());
            dgvContactosAsignados.DataSource = listaContactosAsignados = dalProveedor.buscarProveedorContactos(proveedorSeleccionado, new Entidades.Contacto());
        }
    }
}
