namespace UI.Clientes
{
    partial class Pagos
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
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbxMonto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarTipoPago = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
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
            this.grpPagos.Controls.Add(this.dgvPagos);
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
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(9, 19);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(1031, 120);
            this.dgvPagos.TabIndex = 11;
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
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(89, 12);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(218, 21);
            this.cmbTipoPago.TabIndex = 49;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(342, 16);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 50;
            this.lblMonto.Text = "Monto";
            // 
            // tbxMonto
            // 
            this.tbxMonto.Location = new System.Drawing.Point(385, 12);
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
            // btnAgregarTipoPago
            // 
            this.btnAgregarTipoPago.Location = new System.Drawing.Point(313, 12);
            this.btnAgregarTipoPago.Name = "btnAgregarTipoPago";
            this.btnAgregarTipoPago.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarTipoPago.TabIndex = 53;
            this.btnAgregarTipoPago.Text = "+";
            this.btnAgregarTipoPago.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 391);
            this.Controls.Add(this.btnAgregarTipoPago);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.grpPagos);
            this.Controls.Add(this.grpCliente);
            this.Name = "Pagos";
            this.Text = "Pago";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.grpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbxMonto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarTipoPago;
    }
}