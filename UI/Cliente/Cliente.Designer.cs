namespace UI.Cliente
{
    partial class Cliente
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
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbNombresContacto = new System.Windows.Forms.TextBox();
            this.txbApellidosContacto = new System.Windows.Forms.TextBox();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombresContacto = new System.Windows.Forms.Label();
            this.lblApellidosContacto = new System.Windows.Forms.Label();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.txbApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txbCUILBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.lblApellidoBusqueda = new System.Windows.Forms.Label();
            this.lblCUILBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.txbCUIL = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarDireccion = new System.Windows.Forms.Button();
            this.btnGuardarContacto = new System.Windows.Forms.Button();
            this.grpContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.grpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(44, 15);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(31, 13);
            this.lblCUIL.TabIndex = 0;
            this.lblCUIL.Text = "CUIL";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(305, 15);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(704, 15);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(12, 41);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(360, 41);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblNacimiento.TabIndex = 4;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
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
            this.grpContacto.Location = new System.Drawing.Point(15, 66);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(1047, 205);
            this.grpContacto.TabIndex = 5;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contactos";
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
            this.grpDireccion.Location = new System.Drawing.Point(15, 277);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(1047, 205);
            this.grpDireccion.TabIndex = 6;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Direcciones";
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
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txbNombreBusqueda);
            this.grpCliente.Controls.Add(this.btnBuscar);
            this.grpCliente.Controls.Add(this.txbApellidoBusqueda);
            this.grpCliente.Controls.Add(this.txbCUILBusqueda);
            this.grpCliente.Controls.Add(this.lblNombreBusqueda);
            this.grpCliente.Controls.Add(this.lblApellidoBusqueda);
            this.grpCliente.Controls.Add(this.lblCUILBusqueda);
            this.grpCliente.Controls.Add(this.dgvBusqueda);
            this.grpCliente.Location = new System.Drawing.Point(15, 488);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(1047, 177);
            this.grpCliente.TabIndex = 7;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Clientes";
            // 
            // txbNombreBusqueda
            // 
            this.txbNombreBusqueda.Location = new System.Drawing.Point(766, 19);
            this.txbNombreBusqueda.Name = "txbNombreBusqueda";
            this.txbNombreBusqueda.Size = new System.Drawing.Size(274, 20);
            this.txbNombreBusqueda.TabIndex = 21;
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
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(711, 22);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(49, 13);
            this.lblNombreBusqueda.TabIndex = 18;
            this.lblNombreBusqueda.Text = "Nombres";
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
            this.dgvBusqueda.Size = new System.Drawing.Size(1031, 99);
            this.dgvBusqueda.TabIndex = 15;
            // 
            // txbCUIL
            // 
            this.txbCUIL.Location = new System.Drawing.Point(87, 12);
            this.txbCUIL.Name = "txbCUIL";
            this.txbCUIL.Size = new System.Drawing.Size(212, 20);
            this.txbCUIL.TabIndex = 8;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(360, 12);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(338, 20);
            this.txbApellidos.TabIndex = 9;
            // 
            // txbNombres
            // 
            this.txbNombres.Location = new System.Drawing.Point(759, 12);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(303, 20);
            this.txbNombres.TabIndex = 10;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(87, 38);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(267, 21);
            this.cmbNacionalidad.TabIndex = 11;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(983, 671);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(474, 39);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 0;
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
            // btnGuardarContacto
            // 
            this.btnGuardarContacto.Location = new System.Drawing.Point(966, 176);
            this.btnGuardarContacto.Name = "btnGuardarContacto";
            this.btnGuardarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarContacto.TabIndex = 25;
            this.btnGuardarContacto.Text = "Guardar";
            this.btnGuardarContacto.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.ClientSize = new System.Drawing.Size(1074, 701);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.txbCUIL);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpDireccion);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblCUIL);
            this.Name = "Cliente";
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombresContacto;
        private System.Windows.Forms.Label lblApellidosContacto;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbNombresContacto;
        private System.Windows.Forms.TextBox txbApellidosContacto;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbPiso;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreBusqueda;
        private System.Windows.Forms.TextBox txbApellidoBusqueda;
        private System.Windows.Forms.TextBox txbCUILBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.Label lblApellidoBusqueda;
        private System.Windows.Forms.Label lblCUILBusqueda;
        private System.Windows.Forms.TextBox txbCUIL;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Button btnGuardarContacto;
        private System.Windows.Forms.Button btnGuardarDireccion;
    }
}