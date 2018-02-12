namespace UI.Ventas
{
    partial class Ventas
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
            this.grpDetalleVenta = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.tbxNombresBusqueda = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txbApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txbCUILBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombresBusqueda = new System.Windows.Forms.Label();
            this.lblApellidoBusqueda = new System.Windows.Forms.Label();
            this.lblCUILBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbCUITBusqueda = new System.Windows.Forms.TextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxNombresVenta = new System.Windows.Forms.TextBox();
            this.tbxApellidosVenta = new System.Windows.Forms.TextBox();
            this.lblNombresVenta = new System.Windows.Forms.Label();
            this.lblApellidosVenta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.grpProducto.Location = new System.Drawing.Point(12, 156);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(1050, 166);
            this.grpProducto.TabIndex = 43;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(848, 138);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(111, 23);
            this.btnNuevoProducto.TabIndex = 38;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(964, 138);
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
            this.dgvProductos.Size = new System.Drawing.Size(1032, 60);
            this.dgvProductos.TabIndex = 15;
            // 
            // grpDetalleVenta
            // 
            this.grpDetalleVenta.Controls.Add(this.btnEliminarProducto);
            this.grpDetalleVenta.Controls.Add(this.dgvDireccion);
            this.grpDetalleVenta.Location = new System.Drawing.Point(12, 323);
            this.grpDetalleVenta.Name = "grpDetalleVenta";
            this.grpDetalleVenta.Size = new System.Drawing.Size(1050, 174);
            this.grpDetalleVenta.TabIndex = 44;
            this.grpDetalleVenta.TabStop = false;
            this.grpDetalleVenta.Text = "Detalle de venta";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(966, 145);
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
            this.dgvDireccion.Size = new System.Drawing.Size(1031, 120);
            this.dgvDireccion.TabIndex = 11;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.tbxNombresBusqueda);
            this.grpCliente.Controls.Add(this.btnAsignar);
            this.grpCliente.Controls.Add(this.txbApellidoBusqueda);
            this.grpCliente.Controls.Add(this.txbCUILBusqueda);
            this.grpCliente.Controls.Add(this.lblNombresBusqueda);
            this.grpCliente.Controls.Add(this.lblApellidoBusqueda);
            this.grpCliente.Controls.Add(this.lblCUILBusqueda);
            this.grpCliente.Controls.Add(this.dgvBusqueda);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(1050, 138);
            this.grpCliente.TabIndex = 45;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Clientes";
            // 
            // tbxNombresBusqueda
            // 
            this.tbxNombresBusqueda.Location = new System.Drawing.Point(766, 19);
            this.tbxNombresBusqueda.Name = "tbxNombresBusqueda";
            this.tbxNombresBusqueda.Size = new System.Drawing.Size(274, 20);
            this.tbxNombresBusqueda.TabIndex = 21;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(966, 111);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 22;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // txbApellidoBusqueda
            // 
            this.txbApellidoBusqueda.Location = new System.Drawing.Point(356, 19);
            this.txbApellidoBusqueda.Name = "txbApellidoBusqueda";
            this.txbApellidoBusqueda.Size = new System.Drawing.Size(349, 20);
            this.txbApellidoBusqueda.TabIndex = 20;
            // 
            // txbCUILBusqueda
            // 
            this.txbCUILBusqueda.Location = new System.Drawing.Point(47, 19);
            this.txbCUILBusqueda.Name = "txbCUILBusqueda";
            this.txbCUILBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txbCUILBusqueda.TabIndex = 19;
            // 
            // lblNombresBusqueda
            // 
            this.lblNombresBusqueda.AutoSize = true;
            this.lblNombresBusqueda.Location = new System.Drawing.Point(711, 22);
            this.lblNombresBusqueda.Name = "lblNombresBusqueda";
            this.lblNombresBusqueda.Size = new System.Drawing.Size(49, 13);
            this.lblNombresBusqueda.TabIndex = 18;
            this.lblNombresBusqueda.Text = "Nombres";
            // 
            // lblApellidoBusqueda
            // 
            this.lblApellidoBusqueda.AutoSize = true;
            this.lblApellidoBusqueda.Location = new System.Drawing.Point(301, 22);
            this.lblApellidoBusqueda.Name = "lblApellidoBusqueda";
            this.lblApellidoBusqueda.Size = new System.Drawing.Size(49, 13);
            this.lblApellidoBusqueda.TabIndex = 17;
            this.lblApellidoBusqueda.Text = "Apellidos";
            // 
            // lblCUILBusqueda
            // 
            this.lblCUILBusqueda.AutoSize = true;
            this.lblCUILBusqueda.Location = new System.Drawing.Point(5, 22);
            this.lblCUILBusqueda.Name = "lblCUILBusqueda";
            this.lblCUILBusqueda.Size = new System.Drawing.Size(31, 13);
            this.lblCUILBusqueda.TabIndex = 16;
            this.lblCUILBusqueda.Text = "CUIL";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(8, 45);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(1031, 60);
            this.dgvBusqueda.TabIndex = 15;
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.btnAgregar);
            this.grpVentas.Controls.Add(this.btnEliminar);
            this.grpVentas.Controls.Add(this.tbxNombresVenta);
            this.grpVentas.Controls.Add(this.tbxApellidosVenta);
            this.grpVentas.Controls.Add(this.lblNombresVenta);
            this.grpVentas.Controls.Add(this.lblApellidosVenta);
            this.grpVentas.Controls.Add(this.dtpFechaHasta);
            this.grpVentas.Controls.Add(this.lblFechaHasta);
            this.grpVentas.Controls.Add(this.dtpFechaDesde);
            this.grpVentas.Controls.Add(this.lblFechaDesde);
            this.grpVentas.Controls.Add(this.btnBuscar);
            this.grpVentas.Controls.Add(this.txbCUITBusqueda);
            this.grpVentas.Controls.Add(this.lblCUIL);
            this.grpVentas.Controls.Add(this.dataGridView1);
            this.grpVentas.Location = new System.Drawing.Point(12, 503);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(1050, 158);
            this.grpVentas.TabIndex = 46;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "Ventas";
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
            this.lblFechaHasta.Location = new System.Drawing.Point(799, 23);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 46;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(593, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 45;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(549, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 44;
            this.lblFechaDesde.Text = "Desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(966, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbCUITBusqueda
            // 
            this.txbCUITBusqueda.Location = new System.Drawing.Point(42, 19);
            this.txbCUITBusqueda.Name = "txbCUITBusqueda";
            this.txbCUITBusqueda.Size = new System.Drawing.Size(115, 20);
            this.txbCUITBusqueda.TabIndex = 19;
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(5, 22);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(31, 13);
            this.lblCUIL.TabIndex = 16;
            this.lblCUIL.Text = "CUIL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 80);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(987, 666);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbxNombresVenta
            // 
            this.tbxNombresVenta.Location = new System.Drawing.Point(411, 19);
            this.tbxNombresVenta.Name = "tbxNombresVenta";
            this.tbxNombresVenta.Size = new System.Drawing.Size(132, 20);
            this.tbxNombresVenta.TabIndex = 51;
            // 
            // tbxApellidosVenta
            // 
            this.tbxApellidosVenta.Location = new System.Drawing.Point(218, 19);
            this.tbxApellidosVenta.Name = "tbxApellidosVenta";
            this.tbxApellidosVenta.Size = new System.Drawing.Size(132, 20);
            this.tbxApellidosVenta.TabIndex = 50;
            // 
            // lblNombresVenta
            // 
            this.lblNombresVenta.AutoSize = true;
            this.lblNombresVenta.Location = new System.Drawing.Point(356, 23);
            this.lblNombresVenta.Name = "lblNombresVenta";
            this.lblNombresVenta.Size = new System.Drawing.Size(49, 13);
            this.lblNombresVenta.TabIndex = 49;
            this.lblNombresVenta.Text = "Nombres";
            // 
            // lblApellidosVenta
            // 
            this.lblApellidosVenta.AutoSize = true;
            this.lblApellidosVenta.Location = new System.Drawing.Point(163, 23);
            this.lblApellidosVenta.Name = "lblApellidosVenta";
            this.lblApellidosVenta.Size = new System.Drawing.Size(49, 13);
            this.lblApellidosVenta.TabIndex = 48;
            this.lblApellidosVenta.Text = "Apellidos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(885, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(804, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 701);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpVentas);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpDetalleVenta);
            this.Controls.Add(this.grpProducto);
            this.Name = "Venta";
            this.Text = "Venta";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
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
        private System.Windows.Forms.GroupBox grpDetalleVenta;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox tbxNombresBusqueda;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txbApellidoBusqueda;
        private System.Windows.Forms.TextBox txbCUILBusqueda;
        private System.Windows.Forms.Label lblNombresBusqueda;
        private System.Windows.Forms.Label lblApellidoBusqueda;
        private System.Windows.Forms.Label lblCUILBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbCUITBusqueda;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNombresVenta;
        private System.Windows.Forms.TextBox tbxApellidosVenta;
        private System.Windows.Forms.Label lblNombresVenta;
        private System.Windows.Forms.Label lblApellidosVenta;
    }
}