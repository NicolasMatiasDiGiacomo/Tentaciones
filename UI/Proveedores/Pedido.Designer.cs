namespace UI.Proveedor
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbCUIT = new System.Windows.Forms.TextBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpProveedor = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbCUITBusqueda = new System.Windows.Forms.TextBox();
            this.lblCUITBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.grpDetallePedido = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cmbEstadoBusqueda = new System.Windows.Forms.ComboBox();
            this.lblEstadoBusqueda = new System.Windows.Forms.Label();
            this.txbDescripcionBusqueda = new System.Windows.Forms.TextBox();
            this.cmbCategoriaBusqueda = new System.Windows.Forms.ComboBox();
            this.txbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.lblCategoriaBusqueda = new System.Windows.Forms.Label();
            this.cmbMarcaBusqueda = new System.Windows.Forms.ComboBox();
            this.lblDescripcionBusqueda = new System.Windows.Forms.Label();
            this.lblMarcaBusqueda = new System.Windows.Forms.Label();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.grpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.grpDetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(443, 39);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(315, 21);
            this.cmbEstado.TabIndex = 21;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(50, 38);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(311, 20);
            this.txbTotal.TabIndex = 20;
            // 
            // txbCUIT
            // 
            this.txbCUIT.Location = new System.Drawing.Point(50, 12);
            this.txbCUIT.Name = "txbCUIT";
            this.txbCUIT.Size = new System.Drawing.Size(311, 20);
            this.txbCUIT.TabIndex = 18;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(764, 15);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(87, 13);
            this.lblFechaPedido.TabIndex = 17;
            this.lblFechaPedido.Text = "Fecha de pedido";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(397, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(367, 15);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(70, 13);
            this.lblTipoPago.TabIndex = 14;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(12, 15);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 13;
            this.lblCUIT.Text = "CUIT";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(443, 12);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(315, 21);
            this.cmbTipoPago.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(982, 671);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // grpProveedor
            // 
            this.grpProveedor.Controls.Add(this.dtpFechaHasta);
            this.grpProveedor.Controls.Add(this.lblFechaHasta);
            this.grpProveedor.Controls.Add(this.dtpFechaDesde);
            this.grpProveedor.Controls.Add(this.lblFechaDesde);
            this.grpProveedor.Controls.Add(this.btnBuscar);
            this.grpProveedor.Controls.Add(this.txbCUITBusqueda);
            this.grpProveedor.Controls.Add(this.lblCUITBusqueda);
            this.grpProveedor.Controls.Add(this.dgvBusqueda);
            this.grpProveedor.Location = new System.Drawing.Point(14, 488);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Size = new System.Drawing.Size(1047, 177);
            this.grpProveedor.TabIndex = 40;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "Proveedores";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(840, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 47;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(718, 23);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(116, 13);
            this.lblFechaHasta.TabIndex = 46;
            this.lblFechaHasta.Text = "Fecha de pedido hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(512, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 45;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(383, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(119, 13);
            this.lblFechaDesde.TabIndex = 44;
            this.lblFechaDesde.Text = "Fecha de pedido desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(966, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbCUITBusqueda
            // 
            this.txbCUITBusqueda.Location = new System.Drawing.Point(47, 19);
            this.txbCUITBusqueda.Name = "txbCUITBusqueda";
            this.txbCUITBusqueda.Size = new System.Drawing.Size(330, 20);
            this.txbCUITBusqueda.TabIndex = 19;
            // 
            // lblCUITBusqueda
            // 
            this.lblCUITBusqueda.AutoSize = true;
            this.lblCUITBusqueda.Location = new System.Drawing.Point(5, 22);
            this.lblCUITBusqueda.Name = "lblCUITBusqueda";
            this.lblCUITBusqueda.Size = new System.Drawing.Size(32, 13);
            this.lblCUITBusqueda.TabIndex = 16;
            this.lblCUITBusqueda.Text = "CUIT";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(8, 45);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(1032, 99);
            this.dgvBusqueda.TabIndex = 15;
            // 
            // grpDetallePedido
            // 
            this.grpDetallePedido.Controls.Add(this.btnEliminarProducto);
            this.grpDetallePedido.Controls.Add(this.dgvDireccion);
            this.grpDetallePedido.Location = new System.Drawing.Point(14, 277);
            this.grpDetallePedido.Name = "grpDetallePedido";
            this.grpDetallePedido.Size = new System.Drawing.Size(1047, 205);
            this.grpDetallePedido.TabIndex = 39;
            this.grpDetallePedido.TabStop = false;
            this.grpDetallePedido.Text = "Detalle de pedido";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(966, 176);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(9, 19);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(1031, 151);
            this.dgvDireccion.TabIndex = 11;
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.btnNuevoProducto);
            this.grpProducto.Controls.Add(this.btnAgregarProducto);
            this.grpProducto.Controls.Add(this.cmbEstadoBusqueda);
            this.grpProducto.Controls.Add(this.lblEstadoBusqueda);
            this.grpProducto.Controls.Add(this.txbDescripcionBusqueda);
            this.grpProducto.Controls.Add(this.cmbCategoriaBusqueda);
            this.grpProducto.Controls.Add(this.txbNombreBusqueda);
            this.grpProducto.Controls.Add(this.lblCategoriaBusqueda);
            this.grpProducto.Controls.Add(this.cmbMarcaBusqueda);
            this.grpProducto.Controls.Add(this.lblDescripcionBusqueda);
            this.grpProducto.Controls.Add(this.lblMarcaBusqueda);
            this.grpProducto.Controls.Add(this.lblNombreBusqueda);
            this.grpProducto.Controls.Add(this.dgvProductos);
            this.grpProducto.Location = new System.Drawing.Point(14, 66);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(1047, 205);
            this.grpProducto.TabIndex = 42;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(848, 176);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(111, 23);
            this.btnNuevoProducto.TabIndex = 38;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(965, 176);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 37;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoBusqueda
            // 
            this.cmbEstadoBusqueda.FormattingEnabled = true;
            this.cmbEstadoBusqueda.Location = new System.Drawing.Point(615, 45);
            this.cmbEstadoBusqueda.Name = "cmbEstadoBusqueda";
            this.cmbEstadoBusqueda.Size = new System.Drawing.Size(222, 21);
            this.cmbEstadoBusqueda.TabIndex = 36;
            // 
            // lblEstadoBusqueda
            // 
            this.lblEstadoBusqueda.AutoSize = true;
            this.lblEstadoBusqueda.Location = new System.Drawing.Point(569, 48);
            this.lblEstadoBusqueda.Name = "lblEstadoBusqueda";
            this.lblEstadoBusqueda.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoBusqueda.TabIndex = 35;
            this.lblEstadoBusqueda.Text = "Estado";
            // 
            // txbDescripcionBusqueda
            // 
            this.txbDescripcionBusqueda.Location = new System.Drawing.Point(527, 19);
            this.txbDescripcionBusqueda.Name = "txbDescripcionBusqueda";
            this.txbDescripcionBusqueda.Size = new System.Drawing.Size(513, 20);
            this.txbDescripcionBusqueda.TabIndex = 20;
            // 
            // cmbCategoriaBusqueda
            // 
            this.cmbCategoriaBusqueda.FormattingEnabled = true;
            this.cmbCategoriaBusqueda.Location = new System.Drawing.Point(341, 45);
            this.cmbCategoriaBusqueda.Name = "cmbCategoriaBusqueda";
            this.cmbCategoriaBusqueda.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoriaBusqueda.TabIndex = 34;
            // 
            // txbNombreBusqueda
            // 
            this.txbNombreBusqueda.Location = new System.Drawing.Point(55, 19);
            this.txbNombreBusqueda.Name = "txbNombreBusqueda";
            this.txbNombreBusqueda.Size = new System.Drawing.Size(397, 20);
            this.txbNombreBusqueda.TabIndex = 19;
            // 
            // lblCategoriaBusqueda
            // 
            this.lblCategoriaBusqueda.AutoSize = true;
            this.lblCategoriaBusqueda.Location = new System.Drawing.Point(283, 48);
            this.lblCategoriaBusqueda.Name = "lblCategoriaBusqueda";
            this.lblCategoriaBusqueda.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaBusqueda.TabIndex = 33;
            this.lblCategoriaBusqueda.Text = "Categoria";
            // 
            // cmbMarcaBusqueda
            // 
            this.cmbMarcaBusqueda.FormattingEnabled = true;
            this.cmbMarcaBusqueda.Location = new System.Drawing.Point(55, 45);
            this.cmbMarcaBusqueda.Name = "cmbMarcaBusqueda";
            this.cmbMarcaBusqueda.Size = new System.Drawing.Size(222, 21);
            this.cmbMarcaBusqueda.TabIndex = 32;
            // 
            // lblDescripcionBusqueda
            // 
            this.lblDescripcionBusqueda.AutoSize = true;
            this.lblDescripcionBusqueda.Location = new System.Drawing.Point(458, 22);
            this.lblDescripcionBusqueda.Name = "lblDescripcionBusqueda";
            this.lblDescripcionBusqueda.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionBusqueda.TabIndex = 17;
            this.lblDescripcionBusqueda.Text = "Descripcion";
            // 
            // lblMarcaBusqueda
            // 
            this.lblMarcaBusqueda.AutoSize = true;
            this.lblMarcaBusqueda.Location = new System.Drawing.Point(9, 48);
            this.lblMarcaBusqueda.Name = "lblMarcaBusqueda";
            this.lblMarcaBusqueda.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaBusqueda.TabIndex = 31;
            this.lblMarcaBusqueda.Text = "Marca";
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(5, 22);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBusqueda.TabIndex = 16;
            this.lblNombreBusqueda.Text = "Nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(8, 72);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1032, 99);
            this.dgvProductos.TabIndex = 15;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(862, 12);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 43;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 701);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpProveedor);
            this.Controls.Add(this.grpDetallePedido);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbCUIT);
            this.Controls.Add(this.lblFechaPedido);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblCUIT);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.grpProveedor.ResumeLayout(false);
            this.grpProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.grpDetallePedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbCUIT;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbCUITBusqueda;
        private System.Windows.Forms.Label lblCUITBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.GroupBox grpDetallePedido;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ComboBox cmbEstadoBusqueda;
        private System.Windows.Forms.Label lblEstadoBusqueda;
        private System.Windows.Forms.TextBox txbDescripcionBusqueda;
        private System.Windows.Forms.ComboBox cmbCategoriaBusqueda;
        private System.Windows.Forms.TextBox txbNombreBusqueda;
        private System.Windows.Forms.Label lblCategoriaBusqueda;
        private System.Windows.Forms.ComboBox cmbMarcaBusqueda;
        private System.Windows.Forms.Label lblDescripcionBusqueda;
        private System.Windows.Forms.Label lblMarcaBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnNuevoProducto;
    }
}