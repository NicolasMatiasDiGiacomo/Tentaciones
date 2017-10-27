namespace UI.Producto
{
    partial class Producto
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.txbDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.cmbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.nudAltoProducto = new System.Windows.Forms.NumericUpDown();
            this.nudAnchoProducto = new System.Windows.Forms.NumericUpDown();
            this.nudLargoProducto = new System.Windows.Forms.NumericUpDown();
            this.nudPesoProducto = new System.Windows.Forms.NumericUpDown();
            this.lblAltoProducto = new System.Windows.Forms.Label();
            this.lblAnchoProducto = new System.Windows.Forms.Label();
            this.lblLargoProducto = new System.Windows.Forms.Label();
            this.lblPesoProducto = new System.Windows.Forms.Label();
            this.lblStockMaximoProducto = new System.Windows.Forms.Label();
            this.lblStockMinimoProducto = new System.Windows.Forms.Label();
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.lblPrecioCompraProducto = new System.Windows.Forms.Label();
            this.nudStockMaximoProducto = new System.Windows.Forms.NumericUpDown();
            this.nudStockMinimoProducto = new System.Windows.Forms.NumericUpDown();
            this.cmbEstadoProducto = new System.Windows.Forms.ComboBox();
            this.lblEstadoProducto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.txbDescripcionBusqueda = new System.Windows.Forms.TextBox();
            this.txbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.lblDescripcionBusqueda = new System.Windows.Forms.Label();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.cmbEstadoBusqueda = new System.Windows.Forms.ComboBox();
            this.lblEstadoBusqueda = new System.Windows.Forms.Label();
            this.cmbCategoriaBusqueda = new System.Windows.Forms.ComboBox();
            this.lblCategoriaBusqueda = new System.Windows.Forms.Label();
            this.cmbMarcaBusqueda = new System.Windows.Forms.ComboBox();
            this.lblMarcaBusqueda = new System.Windows.Forms.Label();
            this.txbPrecioCompraProducto = new System.Windows.Forms.TextBox();
            this.txbPrecioVentaProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimoProducto)).BeginInit();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 15);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Location = new System.Drawing.Point(64, 12);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(400, 20);
            this.txbNombreProducto.TabIndex = 1;
            // 
            // txbDescripcionProducto
            // 
            this.txbDescripcionProducto.Location = new System.Drawing.Point(539, 12);
            this.txbDescripcionProducto.Name = "txbDescripcionProducto";
            this.txbDescripcionProducto.Size = new System.Drawing.Size(523, 20);
            this.txbDescripcionProducto.TabIndex = 3;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(470, 15);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionProducto.TabIndex = 2;
            this.lblDescripcionProducto.Text = "Descripcion";
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Location = new System.Drawing.Point(21, 42);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaProducto.TabIndex = 4;
            this.lblMarcaProducto.Text = "Marca";
            // 
            // cmbMarcaProducto
            // 
            this.cmbMarcaProducto.FormattingEnabled = true;
            this.cmbMarcaProducto.Location = new System.Drawing.Point(64, 39);
            this.cmbMarcaProducto.Name = "cmbMarcaProducto";
            this.cmbMarcaProducto.Size = new System.Drawing.Size(222, 21);
            this.cmbMarcaProducto.TabIndex = 5;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(292, 38);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarMarca.TabIndex = 6;
            this.btnAgregarMarca.Text = "+";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(607, 38);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarCategoria.TabIndex = 9;
            this.btnAgregarCategoria.Text = "+";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(379, 39);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoriaProducto.TabIndex = 8;
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(321, 42);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaProducto.TabIndex = 7;
            this.lblCategoriaProducto.Text = "Categoria";
            // 
            // nudAltoProducto
            // 
            this.nudAltoProducto.Location = new System.Drawing.Point(102, 67);
            this.nudAltoProducto.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAltoProducto.Name = "nudAltoProducto";
            this.nudAltoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudAltoProducto.TabIndex = 10;
            // 
            // nudAnchoProducto
            // 
            this.nudAnchoProducto.Location = new System.Drawing.Point(301, 67);
            this.nudAnchoProducto.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAnchoProducto.Name = "nudAnchoProducto";
            this.nudAnchoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudAnchoProducto.TabIndex = 11;
            // 
            // nudLargoProducto
            // 
            this.nudLargoProducto.Location = new System.Drawing.Point(503, 67);
            this.nudLargoProducto.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLargoProducto.Name = "nudLargoProducto";
            this.nudLargoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudLargoProducto.TabIndex = 12;
            // 
            // nudPesoProducto
            // 
            this.nudPesoProducto.Location = new System.Drawing.Point(708, 67);
            this.nudPesoProducto.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPesoProducto.Name = "nudPesoProducto";
            this.nudPesoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudPesoProducto.TabIndex = 13;
            // 
            // lblAltoProducto
            // 
            this.lblAltoProducto.AutoSize = true;
            this.lblAltoProducto.Location = new System.Drawing.Point(71, 69);
            this.lblAltoProducto.Name = "lblAltoProducto";
            this.lblAltoProducto.Size = new System.Drawing.Size(25, 13);
            this.lblAltoProducto.TabIndex = 14;
            this.lblAltoProducto.Text = "Alto";
            // 
            // lblAnchoProducto
            // 
            this.lblAnchoProducto.AutoSize = true;
            this.lblAnchoProducto.Location = new System.Drawing.Point(257, 69);
            this.lblAnchoProducto.Name = "lblAnchoProducto";
            this.lblAnchoProducto.Size = new System.Drawing.Size(38, 13);
            this.lblAnchoProducto.TabIndex = 15;
            this.lblAnchoProducto.Text = "Ancho";
            // 
            // lblLargoProducto
            // 
            this.lblLargoProducto.AutoSize = true;
            this.lblLargoProducto.Location = new System.Drawing.Point(463, 69);
            this.lblLargoProducto.Name = "lblLargoProducto";
            this.lblLargoProducto.Size = new System.Drawing.Size(34, 13);
            this.lblLargoProducto.TabIndex = 16;
            this.lblLargoProducto.Text = "Largo";
            // 
            // lblPesoProducto
            // 
            this.lblPesoProducto.AutoSize = true;
            this.lblPesoProducto.Location = new System.Drawing.Point(671, 69);
            this.lblPesoProducto.Name = "lblPesoProducto";
            this.lblPesoProducto.Size = new System.Drawing.Size(31, 13);
            this.lblPesoProducto.TabIndex = 17;
            this.lblPesoProducto.Text = "Peso";
            // 
            // lblStockMaximoProducto
            // 
            this.lblStockMaximoProducto.AutoSize = true;
            this.lblStockMaximoProducto.Location = new System.Drawing.Point(629, 95);
            this.lblStockMaximoProducto.Name = "lblStockMaximoProducto";
            this.lblStockMaximoProducto.Size = new System.Drawing.Size(73, 13);
            this.lblStockMaximoProducto.TabIndex = 25;
            this.lblStockMaximoProducto.Text = "Stock maximo";
            // 
            // lblStockMinimoProducto
            // 
            this.lblStockMinimoProducto.AutoSize = true;
            this.lblStockMinimoProducto.Location = new System.Drawing.Point(427, 95);
            this.lblStockMinimoProducto.Name = "lblStockMinimoProducto";
            this.lblStockMinimoProducto.Size = new System.Drawing.Size(70, 13);
            this.lblStockMinimoProducto.TabIndex = 24;
            this.lblStockMinimoProducto.Text = "Stock minimo";
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(228, 95);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioVentaProducto.TabIndex = 23;
            this.lblPrecioVentaProducto.Text = "Precio venta";
            // 
            // lblPrecioCompraProducto
            // 
            this.lblPrecioCompraProducto.AutoSize = true;
            this.lblPrecioCompraProducto.Location = new System.Drawing.Point(21, 95);
            this.lblPrecioCompraProducto.Name = "lblPrecioCompraProducto";
            this.lblPrecioCompraProducto.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioCompraProducto.TabIndex = 22;
            this.lblPrecioCompraProducto.Text = "Precio compra";
            // 
            // nudStockMaximoProducto
            // 
            this.nudStockMaximoProducto.Location = new System.Drawing.Point(708, 93);
            this.nudStockMaximoProducto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockMaximoProducto.Name = "nudStockMaximoProducto";
            this.nudStockMaximoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudStockMaximoProducto.TabIndex = 21;
            // 
            // nudStockMinimoProducto
            // 
            this.nudStockMinimoProducto.Location = new System.Drawing.Point(503, 93);
            this.nudStockMinimoProducto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockMinimoProducto.Name = "nudStockMinimoProducto";
            this.nudStockMinimoProducto.Size = new System.Drawing.Size(120, 20);
            this.nudStockMinimoProducto.TabIndex = 20;
            // 
            // cmbEstadoProducto
            // 
            this.cmbEstadoProducto.FormattingEnabled = true;
            this.cmbEstadoProducto.Location = new System.Drawing.Point(64, 119);
            this.cmbEstadoProducto.Name = "cmbEstadoProducto";
            this.cmbEstadoProducto.Size = new System.Drawing.Size(222, 21);
            this.cmbEstadoProducto.TabIndex = 27;
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.AutoSize = true;
            this.lblEstadoProducto.Location = new System.Drawing.Point(21, 122);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoProducto.TabIndex = 26;
            this.lblEstadoProducto.Text = "Estado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(899, 356);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(980, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // grpProducto
            // 
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
            this.grpProducto.Controls.Add(this.dgvBusqueda);
            this.grpProducto.Location = new System.Drawing.Point(12, 146);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(1047, 204);
            this.grpProducto.TabIndex = 28;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // txbDescripcionBusqueda
            // 
            this.txbDescripcionBusqueda.Location = new System.Drawing.Point(527, 19);
            this.txbDescripcionBusqueda.Name = "txbDescripcionBusqueda";
            this.txbDescripcionBusqueda.Size = new System.Drawing.Size(513, 20);
            this.txbDescripcionBusqueda.TabIndex = 20;
            // 
            // txbNombreBusqueda
            // 
            this.txbNombreBusqueda.Location = new System.Drawing.Point(55, 19);
            this.txbNombreBusqueda.Name = "txbNombreBusqueda";
            this.txbNombreBusqueda.Size = new System.Drawing.Size(397, 20);
            this.txbNombreBusqueda.TabIndex = 19;
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
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(5, 22);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBusqueda.TabIndex = 16;
            this.lblNombreBusqueda.Text = "Nombre";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(8, 72);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(1032, 126);
            this.dgvBusqueda.TabIndex = 15;
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
            // cmbCategoriaBusqueda
            // 
            this.cmbCategoriaBusqueda.FormattingEnabled = true;
            this.cmbCategoriaBusqueda.Location = new System.Drawing.Point(341, 45);
            this.cmbCategoriaBusqueda.Name = "cmbCategoriaBusqueda";
            this.cmbCategoriaBusqueda.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoriaBusqueda.TabIndex = 34;
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
            // lblMarcaBusqueda
            // 
            this.lblMarcaBusqueda.AutoSize = true;
            this.lblMarcaBusqueda.Location = new System.Drawing.Point(9, 48);
            this.lblMarcaBusqueda.Name = "lblMarcaBusqueda";
            this.lblMarcaBusqueda.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaBusqueda.TabIndex = 31;
            this.lblMarcaBusqueda.Text = "Marca";
            // 
            // txbPrecioCompraProducto
            // 
            this.txbPrecioCompraProducto.Location = new System.Drawing.Point(102, 93);
            this.txbPrecioCompraProducto.Name = "txbPrecioCompraProducto";
            this.txbPrecioCompraProducto.Size = new System.Drawing.Size(120, 20);
            this.txbPrecioCompraProducto.TabIndex = 31;
            // 
            // txbPrecioVentaProducto
            // 
            this.txbPrecioVentaProducto.Location = new System.Drawing.Point(301, 93);
            this.txbPrecioVentaProducto.Name = "txbPrecioVentaProducto";
            this.txbPrecioVentaProducto.Size = new System.Drawing.Size(120, 20);
            this.txbPrecioVentaProducto.TabIndex = 32;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 388);
            this.Controls.Add(this.txbPrecioVentaProducto);
            this.Controls.Add(this.txbPrecioCompraProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.cmbEstadoProducto);
            this.Controls.Add(this.lblEstadoProducto);
            this.Controls.Add(this.lblStockMaximoProducto);
            this.Controls.Add(this.lblStockMinimoProducto);
            this.Controls.Add(this.lblPrecioVentaProducto);
            this.Controls.Add(this.lblPrecioCompraProducto);
            this.Controls.Add(this.nudStockMaximoProducto);
            this.Controls.Add(this.nudStockMinimoProducto);
            this.Controls.Add(this.lblPesoProducto);
            this.Controls.Add(this.lblLargoProducto);
            this.Controls.Add(this.lblAnchoProducto);
            this.Controls.Add(this.lblAltoProducto);
            this.Controls.Add(this.nudPesoProducto);
            this.Controls.Add(this.nudLargoProducto);
            this.Controls.Add(this.nudAnchoProducto);
            this.Controls.Add(this.nudAltoProducto);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.cmbCategoriaProducto);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.cmbMarcaProducto);
            this.Controls.Add(this.lblMarcaProducto);
            this.Controls.Add(this.txbDescripcionProducto);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.txbNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudAltoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimoProducto)).EndInit();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.TextBox txbDescripcionProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.ComboBox cmbMarcaProducto;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.ComboBox cmbCategoriaProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.NumericUpDown nudAltoProducto;
        private System.Windows.Forms.NumericUpDown nudAnchoProducto;
        private System.Windows.Forms.NumericUpDown nudLargoProducto;
        private System.Windows.Forms.NumericUpDown nudPesoProducto;
        private System.Windows.Forms.Label lblAltoProducto;
        private System.Windows.Forms.Label lblAnchoProducto;
        private System.Windows.Forms.Label lblLargoProducto;
        private System.Windows.Forms.Label lblPesoProducto;
        private System.Windows.Forms.Label lblStockMaximoProducto;
        private System.Windows.Forms.Label lblStockMinimoProducto;
        private System.Windows.Forms.Label lblPrecioVentaProducto;
        private System.Windows.Forms.Label lblPrecioCompraProducto;
        private System.Windows.Forms.NumericUpDown nudStockMaximoProducto;
        private System.Windows.Forms.NumericUpDown nudStockMinimoProducto;
        private System.Windows.Forms.ComboBox cmbEstadoProducto;
        private System.Windows.Forms.Label lblEstadoProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpProducto;
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
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.TextBox txbPrecioCompraProducto;
        private System.Windows.Forms.TextBox txbPrecioVentaProducto;
    }
}