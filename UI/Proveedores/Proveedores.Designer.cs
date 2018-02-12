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
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.dgvContactosDisponibles = new System.Windows.Forms.DataGridView();
            this.dgvContactosAsignados = new System.Windows.Forms.DataGridView();
            this.gpbContactos = new System.Windows.Forms.GroupBox();
            this.btnSacarContacto = new System.Windows.Forms.Button();
            this.btnPonerContacto = new System.Windows.Forms.Button();
            this.gpbDirecciones = new System.Windows.Forms.GroupBox();
            this.btnSacarDireccion = new System.Windows.Forms.Button();
            this.btnPonerDireccion = new System.Windows.Forms.Button();
            this.dgvDireccionesDisponibles = new System.Windows.Forms.DataGridView();
            this.dgvDireccionesAsignadas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosAsignados)).BeginInit();
            this.gpbContactos.SuspendLayout();
            this.gpbDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccionesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccionesAsignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(987, 489);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbRazonSocial
            // 
            this.txbRazonSocial.Location = new System.Drawing.Point(430, 12);
            this.txbRazonSocial.Name = "txbRazonSocial";
            this.txbRazonSocial.Size = new System.Drawing.Size(300, 20);
            this.txbRazonSocial.TabIndex = 34;
            // 
            // txbCUIL
            // 
            this.txbCUIL.Location = new System.Drawing.Point(50, 12);
            this.txbCUIL.Name = "txbCUIL";
            this.txbCUIL.Size = new System.Drawing.Size(300, 20);
            this.txbCUIL.TabIndex = 33;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 358);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(1050, 125);
            this.dgvBusqueda.TabIndex = 15;
            this.dgvBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellClick);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(356, 15);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 26;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(12, 15);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 25;
            this.lblCUIT.Text = "CUIT";
            // 
            // dgvContactosDisponibles
            // 
            this.dgvContactosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosDisponibles.Location = new System.Drawing.Point(6, 19);
            this.dgvContactosDisponibles.Name = "dgvContactosDisponibles";
            this.dgvContactosDisponibles.Size = new System.Drawing.Size(490, 125);
            this.dgvContactosDisponibles.TabIndex = 38;
            this.dgvContactosDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactosDisponibles_CellClick);
            // 
            // dgvContactosAsignados
            // 
            this.dgvContactosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosAsignados.Location = new System.Drawing.Point(554, 19);
            this.dgvContactosAsignados.Name = "dgvContactosAsignados";
            this.dgvContactosAsignados.Size = new System.Drawing.Size(490, 125);
            this.dgvContactosAsignados.TabIndex = 39;
            this.dgvContactosAsignados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactosAsignados_CellClick);
            // 
            // gpbContactos
            // 
            this.gpbContactos.Controls.Add(this.btnSacarContacto);
            this.gpbContactos.Controls.Add(this.btnPonerContacto);
            this.gpbContactos.Controls.Add(this.dgvContactosDisponibles);
            this.gpbContactos.Controls.Add(this.dgvContactosAsignados);
            this.gpbContactos.Location = new System.Drawing.Point(12, 35);
            this.gpbContactos.Name = "gpbContactos";
            this.gpbContactos.Size = new System.Drawing.Size(1050, 151);
            this.gpbContactos.TabIndex = 40;
            this.gpbContactos.TabStop = false;
            this.gpbContactos.Text = "Contactos";
            // 
            // btnSacarContacto
            // 
            this.btnSacarContacto.Location = new System.Drawing.Point(502, 81);
            this.btnSacarContacto.Name = "btnSacarContacto";
            this.btnSacarContacto.Size = new System.Drawing.Size(46, 23);
            this.btnSacarContacto.TabIndex = 41;
            this.btnSacarContacto.Text = "<<";
            this.btnSacarContacto.UseVisualStyleBackColor = true;
            this.btnSacarContacto.Click += new System.EventHandler(this.btnSacarContacto_Click);
            // 
            // btnPonerContacto
            // 
            this.btnPonerContacto.Location = new System.Drawing.Point(502, 52);
            this.btnPonerContacto.Name = "btnPonerContacto";
            this.btnPonerContacto.Size = new System.Drawing.Size(46, 23);
            this.btnPonerContacto.TabIndex = 40;
            this.btnPonerContacto.Text = ">>";
            this.btnPonerContacto.UseVisualStyleBackColor = true;
            this.btnPonerContacto.Click += new System.EventHandler(this.btnPonerContacto_Click);
            // 
            // gpbDirecciones
            // 
            this.gpbDirecciones.Controls.Add(this.btnSacarDireccion);
            this.gpbDirecciones.Controls.Add(this.btnPonerDireccion);
            this.gpbDirecciones.Controls.Add(this.dgvDireccionesDisponibles);
            this.gpbDirecciones.Controls.Add(this.dgvDireccionesAsignadas);
            this.gpbDirecciones.Location = new System.Drawing.Point(12, 192);
            this.gpbDirecciones.Name = "gpbDirecciones";
            this.gpbDirecciones.Size = new System.Drawing.Size(1050, 151);
            this.gpbDirecciones.TabIndex = 42;
            this.gpbDirecciones.TabStop = false;
            this.gpbDirecciones.Text = "Direcciones";
            // 
            // btnSacarDireccion
            // 
            this.btnSacarDireccion.Location = new System.Drawing.Point(502, 81);
            this.btnSacarDireccion.Name = "btnSacarDireccion";
            this.btnSacarDireccion.Size = new System.Drawing.Size(46, 23);
            this.btnSacarDireccion.TabIndex = 41;
            this.btnSacarDireccion.Text = "<<";
            this.btnSacarDireccion.UseVisualStyleBackColor = true;
            this.btnSacarDireccion.Click += new System.EventHandler(this.btnSacarDireccion_Click);
            // 
            // btnPonerDireccion
            // 
            this.btnPonerDireccion.Location = new System.Drawing.Point(502, 52);
            this.btnPonerDireccion.Name = "btnPonerDireccion";
            this.btnPonerDireccion.Size = new System.Drawing.Size(46, 23);
            this.btnPonerDireccion.TabIndex = 40;
            this.btnPonerDireccion.Text = ">>";
            this.btnPonerDireccion.UseVisualStyleBackColor = true;
            this.btnPonerDireccion.Click += new System.EventHandler(this.btnPonerDireccion_Click);
            // 
            // dgvDireccionesDisponibles
            // 
            this.dgvDireccionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccionesDisponibles.Location = new System.Drawing.Point(6, 19);
            this.dgvDireccionesDisponibles.Name = "dgvDireccionesDisponibles";
            this.dgvDireccionesDisponibles.Size = new System.Drawing.Size(490, 125);
            this.dgvDireccionesDisponibles.TabIndex = 38;
            this.dgvDireccionesDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDireccionesDisponibles_CellClick);
            // 
            // dgvDireccionesAsignadas
            // 
            this.dgvDireccionesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccionesAsignadas.Location = new System.Drawing.Point(554, 19);
            this.dgvDireccionesAsignadas.Name = "dgvDireccionesAsignadas";
            this.dgvDireccionesAsignadas.Size = new System.Drawing.Size(490, 125);
            this.dgvDireccionesAsignadas.TabIndex = 39;
            this.dgvDireccionesAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDireccionesAsignadas_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(744, 489);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(825, 489);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(906, 489);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(782, 12);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(280, 21);
            this.cmbEstado.TabIndex = 47;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(736, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 46;
            this.lblEstado.Text = "Estado";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 521);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpbDirecciones);
            this.Controls.Add(this.gpbContactos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbRazonSocial);
            this.Controls.Add(this.txbCUIL);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.lblCUIT);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosAsignados)).EndInit();
            this.gpbContactos.ResumeLayout(false);
            this.gpbDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccionesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccionesAsignadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbRazonSocial;
        private System.Windows.Forms.TextBox txbCUIL;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.DataGridView dgvContactosDisponibles;
        private System.Windows.Forms.DataGridView dgvContactosAsignados;
        private System.Windows.Forms.GroupBox gpbContactos;
        private System.Windows.Forms.Button btnSacarContacto;
        private System.Windows.Forms.Button btnPonerContacto;
        private System.Windows.Forms.GroupBox gpbDirecciones;
        private System.Windows.Forms.Button btnSacarDireccion;
        private System.Windows.Forms.Button btnPonerDireccion;
        private System.Windows.Forms.DataGridView dgvDireccionesDisponibles;
        private System.Windows.Forms.DataGridView dgvDireccionesAsignadas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}