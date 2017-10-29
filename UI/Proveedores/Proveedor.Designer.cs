namespace UI.Proveedor
{
    partial class Proveedor
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbRazonSocial = new System.Windows.Forms.TextBox();
            this.txbCUIL = new System.Windows.Forms.TextBox();
            this.grpProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txbCUITBusqueda = new System.Windows.Forms.TextBox();
            this.lblRazonSocialBusqueda = new System.Windows.Forms.Label();
            this.lblCUITBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.btnGuardarDireccion = new System.Windows.Forms.Button();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbPiso = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.btnGuardarContacto = new System.Windows.Forms.Button();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbNombresContacto = new System.Windows.Forms.TextBox();
            this.txbApellidosContacto = new System.Windows.Forms.TextBox();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombresContacto = new System.Windows.Forms.Label();
            this.lblApellidosContacto = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.grpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.grpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.grpContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(983, 668);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txbRazonSocial
            // 
            this.txbRazonSocial.Location = new System.Drawing.Point(342, 9);
            this.txbRazonSocial.Name = "txbRazonSocial";
            this.txbRazonSocial.Size = new System.Drawing.Size(720, 20);
            this.txbRazonSocial.TabIndex = 34;
            // 
            // txbCUIL
            // 
            this.txbCUIL.Location = new System.Drawing.Point(50, 9);
            this.txbCUIL.Name = "txbCUIL";
            this.txbCUIL.Size = new System.Drawing.Size(212, 20);
            this.txbCUIL.TabIndex = 33;
            // 
            // grpProveedor
            // 
            this.grpProveedor.Controls.Add(this.btnBuscar);
            this.grpProveedor.Controls.Add(this.txbApellidoBusqueda);
            this.grpProveedor.Controls.Add(this.txbCUITBusqueda);
            this.grpProveedor.Controls.Add(this.lblRazonSocialBusqueda);
            this.grpProveedor.Controls.Add(this.lblCUITBusqueda);
            this.grpProveedor.Controls.Add(this.dgvBusqueda);
            this.grpProveedor.Location = new System.Drawing.Point(15, 457);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Size = new System.Drawing.Size(1047, 205);
            this.grpProveedor.TabIndex = 32;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "Proveedores";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(966, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbApellidoBusqueda
            // 
            this.txbApellidoBusqueda.Location = new System.Drawing.Point(375, 19);
            this.txbApellidoBusqueda.Name = "txbApellidoBusqueda";
            this.txbApellidoBusqueda.Size = new System.Drawing.Size(665, 20);
            this.txbApellidoBusqueda.TabIndex = 20;
            // 
            // txbCUITBusqueda
            // 
            this.txbCUITBusqueda.Location = new System.Drawing.Point(47, 19);
            this.txbCUITBusqueda.Name = "txbCUITBusqueda";
            this.txbCUITBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txbCUITBusqueda.TabIndex = 19;
            // 
            // lblRazonSocialBusqueda
            // 
            this.lblRazonSocialBusqueda.AutoSize = true;
            this.lblRazonSocialBusqueda.Location = new System.Drawing.Point(301, 22);
            this.lblRazonSocialBusqueda.Name = "lblRazonSocialBusqueda";
            this.lblRazonSocialBusqueda.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocialBusqueda.TabIndex = 17;
            this.lblRazonSocialBusqueda.Text = "Razon social";
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
            this.dgvBusqueda.Size = new System.Drawing.Size(1032, 125);
            this.dgvBusqueda.TabIndex = 15;
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.btnGuardarDireccion);
            this.grpDireccion.Controls.Add(this.cmbPais);
            this.grpDireccion.Controls.Add(this.cmbProvincia);
            this.grpDireccion.Controls.Add(this.txbLocalidad);
            this.grpDireccion.Controls.Add(this.txbNumero);
            this.grpDireccion.Controls.Add(this.txbPiso);
            this.grpDireccion.Controls.Add(this.textBox10);
            this.grpDireccion.Controls.Add(this.txbCP);
            this.grpDireccion.Controls.Add(this.txbCalle);
            this.grpDireccion.Controls.Add(this.dgvDireccion);
            this.grpDireccion.Controls.Add(this.lblPais);
            this.grpDireccion.Controls.Add(this.lblProvincia);
            this.grpDireccion.Controls.Add(this.lblLocalidad);
            this.grpDireccion.Controls.Add(this.lblCP);
            this.grpDireccion.Controls.Add(this.lblDepartamento);
            this.grpDireccion.Controls.Add(this.lblPiso);
            this.grpDireccion.Controls.Add(this.lblNumero);
            this.grpDireccion.Controls.Add(this.lblCalle);
            this.grpDireccion.Location = new System.Drawing.Point(15, 246);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(1047, 205);
            this.grpDireccion.TabIndex = 31;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Direcciones";
            // 
            // btnGuardarDireccion
            // 
            this.btnGuardarDireccion.Location = new System.Drawing.Point(966, 176);
            this.btnGuardarDireccion.Name = "btnGuardarDireccion";
            this.btnGuardarDireccion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDireccion.TabIndex = 24;
            this.btnGuardarDireccion.Text = "Guardar";
            this.btnGuardarDireccion.UseVisualStyleBackColor = true;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(813, 47);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(227, 21);
            this.cmbPais.TabIndex = 22;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(536, 47);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(230, 21);
            this.cmbProvincia.TabIndex = 21;
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.Location = new System.Drawing.Point(242, 45);
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(231, 20);
            this.txbLocalidad.TabIndex = 20;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(695, 19);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(79, 20);
            this.txbNumero.TabIndex = 19;
            // 
            // txbPiso
            // 
            this.txbPiso.Location = new System.Drawing.Point(813, 19);
            this.txbPiso.Name = "txbPiso";
            this.txbPiso.Size = new System.Drawing.Size(79, 20);
            this.txbPiso.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(978, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(62, 20);
            this.textBox10.TabIndex = 17;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(42, 45);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(135, 20);
            this.txbCP.TabIndex = 16;
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(42, 19);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(597, 20);
            this.txbCalle.TabIndex = 15;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(9, 71);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(1031, 99);
            this.dgvDireccion.TabIndex = 11;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(780, 50);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(479, 50);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 13;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(183, 49);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(6, 48);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(21, 13);
            this.lblCP.TabIndex = 11;
            this.lblCP.Text = "CP";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(898, 22);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 10;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(780, 22);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "Piso";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(645, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Numero";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(6, 22);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "Calle";
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.btnGuardarContacto);
            this.grpContacto.Controls.Add(this.txbTelefono);
            this.grpContacto.Controls.Add(this.txbMail);
            this.grpContacto.Controls.Add(this.txbNombresContacto);
            this.grpContacto.Controls.Add(this.txbApellidosContacto);
            this.grpContacto.Controls.Add(this.dgvContacto);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Controls.Add(this.lblNombresContacto);
            this.grpContacto.Controls.Add(this.lblApellidosContacto);
            this.grpContacto.Location = new System.Drawing.Point(15, 35);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(1047, 205);
            this.grpContacto.TabIndex = 30;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contactos";
            // 
            // btnGuardarContacto
            // 
            this.btnGuardarContacto.Location = new System.Drawing.Point(966, 176);
            this.btnGuardarContacto.Name = "btnGuardarContacto";
            this.btnGuardarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarContacto.TabIndex = 25;
            this.btnGuardarContacto.Text = "Guardar";
            this.btnGuardarContacto.UseVisualStyleBackColor = true;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(702, 45);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(338, 20);
            this.txbTelefono.TabIndex = 16;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(61, 45);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(580, 20);
            this.txbMail.TabIndex = 15;
            // 
            // txbNombresContacto
            // 
            this.txbNombresContacto.Location = new System.Drawing.Point(590, 19);
            this.txbNombresContacto.Name = "txbNombresContacto";
            this.txbNombresContacto.Size = new System.Drawing.Size(450, 20);
            this.txbNombresContacto.TabIndex = 14;
            // 
            // txbApellidosContacto
            // 
            this.txbApellidosContacto.Location = new System.Drawing.Point(61, 19);
            this.txbApellidosContacto.Name = "txbApellidosContacto";
            this.txbApellidosContacto.Size = new System.Drawing.Size(466, 20);
            this.txbApellidosContacto.TabIndex = 13;
            // 
            // dgvContacto
            // 
            this.dgvContacto.AllowUserToOrderColumns = true;
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(9, 71);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.Size = new System.Drawing.Size(1031, 99);
            this.dgvContacto.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(647, 48);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(29, 48);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail";
            // 
            // lblNombresContacto
            // 
            this.lblNombresContacto.AutoSize = true;
            this.lblNombresContacto.Location = new System.Drawing.Point(533, 22);
            this.lblNombresContacto.Name = "lblNombresContacto";
            this.lblNombresContacto.Size = new System.Drawing.Size(49, 13);
            this.lblNombresContacto.TabIndex = 7;
            this.lblNombresContacto.Text = "Nombres";
            // 
            // lblApellidosContacto
            // 
            this.lblApellidosContacto.AutoSize = true;
            this.lblApellidosContacto.Location = new System.Drawing.Point(6, 22);
            this.lblApellidosContacto.Name = "lblApellidosContacto";
            this.lblApellidosContacto.Size = new System.Drawing.Size(49, 13);
            this.lblApellidosContacto.TabIndex = 6;
            this.lblApellidosContacto.Text = "Apellidos";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(268, 12);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 26;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(12, 12);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 25;
            this.lblCUIT.Text = "CUIT";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 701);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbRazonSocial);
            this.Controls.Add(this.txbCUIL);
            this.Controls.Add(this.grpProveedor);
            this.Controls.Add(this.grpDireccion);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCUIT);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.grpProveedor.ResumeLayout(false);
            this.grpProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbRazonSocial;
        private System.Windows.Forms.TextBox txbCUIL;
        private System.Windows.Forms.GroupBox grpProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbApellidoBusqueda;
        private System.Windows.Forms.TextBox txbCUITBusqueda;
        private System.Windows.Forms.Label lblRazonSocialBusqueda;
        private System.Windows.Forms.Label lblCUITBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.Button btnGuardarDireccion;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbPiso;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Button btnGuardarContacto;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbNombresContacto;
        private System.Windows.Forms.TextBox txbApellidosContacto;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombresContacto;
        private System.Windows.Forms.Label lblApellidosContacto;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
    }
}