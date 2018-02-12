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
    public partial class Producto : Form
    {
        DAL.DALProducto dalProducto = new DAL.DALProducto();
        Entidades.Producto producto = new Entidades.Producto();
        Entidades.Producto productoSeleccionado = new Entidades.Producto();
        DAL.DALCategoria dalCategoria = new DAL.DALCategoria();
        DAL.DALMarca dalMarca = new DAL.DALMarca();

#warning limpiar los objetos con cada proceso

        public Producto()
        {
            InitializeComponent();
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado("Disponible", 0));
            estados.Add(new Estado("No disponible", 1));
            cmbEstadoProducto.DataSource = estados;
            cmbEstadoProducto.DisplayMember = "text";
            cmbEstadoProducto.ValueMember = "value";
            cmbCategoriaProducto.DataSource = dalCategoria.buscarCategoria(new Entidades.Categoria());
            cmbCategoriaProducto.DisplayMember = "nombre";
            cmbCategoriaProducto.ValueMember = "idCategoria";
            cmbMarcaProducto.DataSource = dalMarca.buscarMarca(new Entidades.Marca());
            cmbMarcaProducto.DisplayMember = "nombre";
            cmbMarcaProducto.ValueMember = "idMarca";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNombreProducto.Text) || string.IsNullOrWhiteSpace(txbDescripcionProducto.Text) ||
                (int)nudAltoProducto.Value == 0 || (int)nudAnchoProducto.Value == 0 || (int)nudLargoProducto.Value == 0 || (int)nudPesoProducto.Value == 0 ||
                string.IsNullOrWhiteSpace(txbPrecioCompraProducto.Text) || string.IsNullOrWhiteSpace(txbPrecioVentaProducto.Text) ||
                (int)nudStockMinimoProducto.Value == 0 || (int)nudStockMaximoProducto.Value == 0)
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            producto.idCategoria = (Guid)cmbCategoriaProducto.SelectedValue;
            cmbCategoriaProducto.SelectedIndex = 0;
            producto.idMarca = (Guid)cmbMarcaProducto.SelectedValue;
            cmbMarcaProducto.SelectedIndex = 0;
            producto.descripcion = txbDescripcionProducto.Text;
            txbDescripcionProducto.Clear();
            producto.nombre = txbNombreProducto.Text;
            txbNombreProducto.Clear();
            producto.alto = (float)nudAltoProducto.Value;
            nudAltoProducto.Value = 0;
            producto.ancho = (float)nudAnchoProducto.Value;
            nudAnchoProducto.Value = 0;
            producto.largo = (float)nudLargoProducto.Value;
            nudLargoProducto.Value = 0;
            producto.peso = (float)nudPesoProducto.Value;
            nudPesoProducto.Value = 0;
            producto.precioUnitarioCompra = float.Parse(txbPrecioCompraProducto.Text);
            txbPrecioCompraProducto.Clear();
            producto.precioUnitarioVenta = float.Parse(txbPrecioVentaProducto.Text);
            txbPrecioVentaProducto.Clear();
            producto.stockMinimo = (int)nudStockMinimoProducto.Value;
            nudStockMinimoProducto.Value = 0;
            producto.stockMaximo = (int)nudStockMaximoProducto.Value;
            nudStockMaximoProducto.Value = 0;
            producto.estado = Convert.ToBoolean((int)cmbEstadoProducto.SelectedValue);
            cmbEstadoProducto.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProducto.crearProducto(producto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            producto.idCategoria = (Guid)cmbCategoriaProducto.SelectedValue;
            cmbCategoriaProducto.SelectedIndex = 0;
            producto.idMarca = (Guid)cmbMarcaProducto.SelectedValue;
            cmbMarcaProducto.SelectedIndex = 0;
            producto.descripcion = string.IsNullOrWhiteSpace(txbDescripcionProducto.Text) ? null : txbDescripcionProducto.Text;
            txbDescripcionProducto.Clear();
            producto.nombre = string.IsNullOrWhiteSpace(txbNombreProducto.Text) ? null : txbNombreProducto.Text;
            txbNombreProducto.Clear();
            producto.alto = (float)nudAltoProducto.Value;
            nudAltoProducto.Value = 0;
            producto.ancho = (float)nudAnchoProducto.Value;
            nudAnchoProducto.Value = 0;
            producto.largo = (float)nudLargoProducto.Value;
            nudLargoProducto.Value = 0;
            producto.peso = (float)nudPesoProducto.Value;
            nudPesoProducto.Value = 0;
            producto.precioUnitarioCompra = string.IsNullOrWhiteSpace(txbPrecioCompraProducto.Text) ? 0 : float.Parse(txbPrecioCompraProducto.Text);
            txbPrecioCompraProducto.Clear();
            producto.precioUnitarioVenta = string.IsNullOrWhiteSpace(txbPrecioVentaProducto.Text) ? 0 : float.Parse(txbPrecioVentaProducto.Text);
            txbPrecioVentaProducto.Clear();
            producto.stockMinimo = (int)nudStockMinimoProducto.Value;
            nudStockMinimoProducto.Value = 0;
            producto.stockMaximo = (int)nudStockMaximoProducto.Value;
            nudStockMaximoProducto.Value = 0;
            producto.estado = Convert.ToBoolean((int)cmbEstadoProducto.SelectedValue);
            cmbEstadoProducto.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProducto.buscarProducto(producto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado.idProducto == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombreProducto.Text) || string.IsNullOrWhiteSpace(txbDescripcionProducto.Text) ||
                (int)nudAltoProducto.Value == 0 || (int)nudAnchoProducto.Value == 0 || (int)nudLargoProducto.Value == 0 || (int)nudPesoProducto.Value == 0 ||
                string.IsNullOrWhiteSpace(txbPrecioCompraProducto.Text) || string.IsNullOrWhiteSpace(txbPrecioVentaProducto.Text) ||
                (int)nudStockMinimoProducto.Value == 0 || (int)nudStockMaximoProducto.Value == 0)
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            productoSeleccionado.idCategoria = (Guid)cmbCategoriaProducto.SelectedValue;
            cmbCategoriaProducto.SelectedIndex = 0;
            productoSeleccionado.idMarca = (Guid)cmbMarcaProducto.SelectedValue;
            cmbMarcaProducto.SelectedIndex = 0;
            productoSeleccionado.descripcion = txbDescripcionProducto.Text;
            txbDescripcionProducto.Clear();
            productoSeleccionado.nombre = txbNombreProducto.Text;
            txbNombreProducto.Clear();
            productoSeleccionado.alto = (float)nudAltoProducto.Value;
            nudAltoProducto.Value = 0;
            productoSeleccionado.ancho = (float)nudAnchoProducto.Value;
            nudAnchoProducto.Value = 0;
            productoSeleccionado.largo = (float)nudLargoProducto.Value;
            nudLargoProducto.Value = 0;
            productoSeleccionado.peso = (float)nudPesoProducto.Value;
            nudPesoProducto.Value = 0;
            productoSeleccionado.precioUnitarioCompra = float.Parse(txbPrecioCompraProducto.Text);
            txbPrecioCompraProducto.Clear();
            productoSeleccionado.precioUnitarioVenta = float.Parse(txbPrecioVentaProducto.Text);
            txbPrecioVentaProducto.Clear();
            productoSeleccionado.stockMinimo = (int)nudStockMinimoProducto.Value;
            nudStockMinimoProducto.Value = 0;
            productoSeleccionado.stockMaximo = (int)nudStockMaximoProducto.Value;
            nudStockMaximoProducto.Value = 0;
            productoSeleccionado.estado = Convert.ToBoolean((int)cmbEstadoProducto.SelectedValue);
            cmbEstadoProducto.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProducto.modificarProducto(productoSeleccionado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado.idProducto == Guid.Empty)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            cmbCategoriaProducto.SelectedIndex = 0;
            cmbMarcaProducto.SelectedIndex = 0;
            txbDescripcionProducto.Clear();
            txbNombreProducto.Clear();
            nudAltoProducto.Value = 0;
            nudAnchoProducto.Value = 0;
            nudLargoProducto.Value = 0;
            nudPesoProducto.Value = 0;
            txbPrecioCompraProducto.Clear();
            txbPrecioVentaProducto.Clear();
            nudStockMinimoProducto.Value = 0;
            nudStockMaximoProducto.Value = 0;
            cmbEstadoProducto.SelectedIndex = 0;
            dgvBusqueda.DataSource = dalProducto.eliminarProducto(productoSeleccionado);
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            productoSeleccionado.idProducto = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idProducto"].Value;
            cmbCategoriaProducto.SelectedValue = productoSeleccionado.idCategoria = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idCategoria"].Value;
            cmbMarcaProducto.SelectedValue = productoSeleccionado.idMarca = (Guid)dgvBusqueda.Rows[e.RowIndex].Cells["idMarca"].Value;
            txbDescripcionProducto.Text = productoSeleccionado.descripcion = dgvBusqueda.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            txbNombreProducto.Text = productoSeleccionado.nombre = dgvBusqueda.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            producto.alto = (float)dgvBusqueda.Rows[e.RowIndex].Cells["alto"].Value;
            nudAltoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["alto"].Value);
            producto.ancho = (float)dgvBusqueda.Rows[e.RowIndex].Cells["ancho"].Value;
            nudAnchoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["ancho"].Value);
            producto.largo = (float)dgvBusqueda.Rows[e.RowIndex].Cells["largo"].Value;
            nudLargoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["largo"].Value);
            producto.peso = (float)dgvBusqueda.Rows[e.RowIndex].Cells["peso"].Value;
            nudPesoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["peso"].Value);
            producto.precioUnitarioCompra = (float)dgvBusqueda.Rows[e.RowIndex].Cells["precioUnitarioCompra"].Value;
            txbPrecioCompraProducto.Text = dgvBusqueda.Rows[e.RowIndex].Cells["precioUnitarioCompra"].Value.ToString();
            producto.precioUnitarioVenta = (float)dgvBusqueda.Rows[e.RowIndex].Cells["precioUnitarioVenta"].Value;
            txbPrecioVentaProducto.Text = dgvBusqueda.Rows[e.RowIndex].Cells["precioUnitarioVenta"].Value.ToString();
            producto.stockMinimo = (int)dgvBusqueda.Rows[e.RowIndex].Cells["stockMinimo"].Value;
            nudStockMinimoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["stockMinimo"].Value);
            producto.stockMaximo = (int)dgvBusqueda.Rows[e.RowIndex].Cells["stockMaximo"].Value;
            nudStockMaximoProducto.Value = Convert.ToDecimal(dgvBusqueda.Rows[e.RowIndex].Cells["stockMaximo"].Value);
            producto.estado = Convert.ToBoolean(dgvBusqueda.Rows[e.RowIndex].Cells["estado"].Value);
            cmbEstadoProducto.SelectedIndex = Convert.ToInt32(dgvBusqueda.Rows[e.RowIndex].Cells["estado"].Value);
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            UI.Producto.Marca marcaForm = new UI.Producto.Marca(this);
            marcaForm.ShowDialog(this);
            cmbMarcaProducto.DataSource = dalMarca.buscarMarca(new Entidades.Marca());
            cmbMarcaProducto.DisplayMember = "nombre";
            cmbMarcaProducto.ValueMember = "idMarca";
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            UI.Producto.Categoria categoriaForm = new UI.Producto.Categoria(this);
            categoriaForm.ShowDialog(this);
            cmbCategoriaProducto.DataSource = dalCategoria.buscarCategoria(new Entidades.Categoria());
            cmbCategoriaProducto.DisplayMember = "nombre";
            cmbCategoriaProducto.ValueMember = "idCategoria";
        }
    }
}

class Estado
{
    private string _text;

    public string text
    {
        get { return _text; }
        set { _text = value; }
    }

    private int _value;

    public int value
    {
        get { return _value; }
        set { _value = value; }
    }

    public Estado(string text, int value)
    {
        this.text = text;
        this.value = value;
    }

}