namespace UI.Clientes
{
    partial class Pago
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.tbxNombresBusqueda = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txbApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txbCUILBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombresBusqueda = new System.Windows.Forms.Label();
            this.lblApellidoBusqueda = new System.Windows.Forms.Label();
            this.lblCUILBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.grpPagos = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbxMonto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.SuspendLayout();
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
            this.grpCliente.Location = new System.Drawing.Point(12, 40);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(1050, 138);
            this.grpCliente.TabIndex = 46;
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
            // grpPagos
            // 
            this.grpPagos.Controls.Add(this.btnSeleccionar);
            this.grpPagos.Controls.Add(this.dgvDireccion);
            this.grpPagos.Location = new System.Drawing.Point(12, 184);
            this.grpPagos.Name = "grpPagos";
            this.grpPagos.Size = new System.Drawing.Size(1050, 174);
            this.grpPagos.TabIndex = 47;
            this.grpPagos.TabStop = false;
            this.grpPagos.Text = "Seleccione pagos";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(966, 145);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 24;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(9, 19);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(1031, 120);
            this.dgvDireccion.TabIndex = 11;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(13, 16);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(70, 13);
            this.lblTipoPago.TabIndex = 48;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(316, 16);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 50;
            this.lblMonto.Text = "Monto";
            // 
            // tbxMonto
            // 
            this.tbxMonto.Location = new System.Drawing.Point(360, 13);
            this.tbxMonto.Name = "tbxMonto";
            this.tbxMonto.Size = new System.Drawing.Size(202, 20);
            this.tbxMonto.TabIndex = 51;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(987, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 391);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.grpPagos);
            this.Controls.Add(this.grpCliente);
            this.Name = "Pago";
            this.Text = "Pago";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.grpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox tbxNombresBusqueda;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txbApellidoBusqueda;
        private System.Windows.Forms.TextBox txbCUILBusqueda;
        private System.Windows.Forms.Label lblNombresBusqueda;
        private System.Windows.Forms.Label lblApellidoBusqueda;
        private System.Windows.Forms.Label lblCUILBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.GroupBox grpPagos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbxMonto;
        private System.Windows.Forms.Button btnGuardar;
    }
}