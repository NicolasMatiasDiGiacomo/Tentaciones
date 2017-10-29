namespace UI.Ventas
{
    partial class Factura
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
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.tbxNombresVenta = new System.Windows.Forms.TextBox();
            this.tbxApellidosVenta = new System.Windows.Forms.TextBox();
            this.lblNombresVenta = new System.Windows.Forms.Label();
            this.lblApellidosVenta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbCUITBusqueda = new System.Windows.Forms.TextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.grpDetalleFactura = new System.Windows.Forms.GroupBox();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarTipoFactura = new System.Windows.Forms.Button();
            this.btnAgregarTipoPago = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.grpDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(332, 15);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(70, 13);
            this.lblTipoPago.TabIndex = 0;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(12, 15);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(79, 13);
            this.lblTipoFactura.TabIndex = 1;
            this.lblTipoFactura.Text = "Tipo de factura";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(643, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(408, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(680, 13);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(150, 20);
            this.tbxTotal.TabIndex = 5;
            // 
            // grpVentas
            // 
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
            this.grpVentas.Controls.Add(this.dgvVentas);
            this.grpVentas.Location = new System.Drawing.Point(12, 39);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(1050, 158);
            this.grpVentas.TabIndex = 47;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "Ventas";
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
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(8, 45);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(1032, 80);
            this.dgvVentas.TabIndex = 15;
            // 
            // grpDetalleFactura
            // 
            this.grpDetalleFactura.Controls.Add(this.btnEliminarFactura);
            this.grpDetalleFactura.Controls.Add(this.dgvDetalleVentas);
            this.grpDetalleFactura.Location = new System.Drawing.Point(12, 203);
            this.grpDetalleFactura.Name = "grpDetalleFactura";
            this.grpDetalleFactura.Size = new System.Drawing.Size(1050, 174);
            this.grpDetalleFactura.TabIndex = 48;
            this.grpDetalleFactura.TabStop = false;
            this.grpDetalleFactura.Text = "Detalle de factura";
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Location = new System.Drawing.Point(966, 145);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFactura.TabIndex = 24;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(9, 19);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.Size = new System.Drawing.Size(1031, 120);
            this.dgvDetalleVentas.TabIndex = 11;
            // 
            // btnAgregarTipoFactura
            // 
            this.btnAgregarTipoFactura.Location = new System.Drawing.Point(303, 11);
            this.btnAgregarTipoFactura.Name = "btnAgregarTipoFactura";
            this.btnAgregarTipoFactura.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarTipoFactura.TabIndex = 49;
            this.btnAgregarTipoFactura.Text = "+";
            this.btnAgregarTipoFactura.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTipoPago
            // 
            this.btnAgregarTipoPago.Location = new System.Drawing.Point(614, 11);
            this.btnAgregarTipoPago.Name = "btnAgregarTipoPago";
            this.btnAgregarTipoPago.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarTipoPago.TabIndex = 50;
            this.btnAgregarTipoPago.Text = "+";
            this.btnAgregarTipoPago.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(987, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 411);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarTipoPago);
            this.Controls.Add(this.btnAgregarTipoFactura);
            this.Controls.Add(this.grpDetalleFactura);
            this.Controls.Add(this.grpVentas);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lblTipoPago);
            this.Name = "Factura";
            this.Text = "Factura";
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.grpDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.TextBox tbxNombresVenta;
        private System.Windows.Forms.TextBox tbxApellidosVenta;
        private System.Windows.Forms.Label lblNombresVenta;
        private System.Windows.Forms.Label lblApellidosVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbCUITBusqueda;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.GroupBox grpDetalleFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.Button btnAgregarTipoFactura;
        private System.Windows.Forms.Button btnAgregarTipoPago;
        private System.Windows.Forms.Button btnGuardar;
    }
}