namespace UI.Producto
{
    partial class Marca
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpMarca = new System.Windows.Forms.GroupBox();
            this.txbDescripcionBusqueda = new System.Windows.Forms.TextBox();
            this.txbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.lblDescripcionBusqueda = new System.Windows.Forms.Label();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(906, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(987, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // grpMarca
            // 
            this.grpMarca.Controls.Add(this.txbDescripcionBusqueda);
            this.grpMarca.Controls.Add(this.txbNombreBusqueda);
            this.grpMarca.Controls.Add(this.lblDescripcionBusqueda);
            this.grpMarca.Controls.Add(this.lblNombreBusqueda);
            this.grpMarca.Controls.Add(this.dgvBusqueda);
            this.grpMarca.Location = new System.Drawing.Point(7, 38);
            this.grpMarca.Name = "grpMarca";
            this.grpMarca.Size = new System.Drawing.Size(1055, 178);
            this.grpMarca.TabIndex = 35;
            this.grpMarca.TabStop = false;
            this.grpMarca.Text = "Marcas";
            // 
            // txbDescripcionBusqueda
            // 
            this.txbDescripcionBusqueda.Location = new System.Drawing.Point(530, 19);
            this.txbDescripcionBusqueda.Name = "txbDescripcionBusqueda";
            this.txbDescripcionBusqueda.Size = new System.Drawing.Size(519, 20);
            this.txbDescripcionBusqueda.TabIndex = 20;
            // 
            // txbNombreBusqueda
            // 
            this.txbNombreBusqueda.Location = new System.Drawing.Point(55, 19);
            this.txbNombreBusqueda.Name = "txbNombreBusqueda";
            this.txbNombreBusqueda.Size = new System.Drawing.Size(400, 20);
            this.txbNombreBusqueda.TabIndex = 19;
            // 
            // lblDescripcionBusqueda
            // 
            this.lblDescripcionBusqueda.AutoSize = true;
            this.lblDescripcionBusqueda.Location = new System.Drawing.Point(461, 22);
            this.lblDescripcionBusqueda.Name = "lblDescripcionBusqueda";
            this.lblDescripcionBusqueda.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionBusqueda.TabIndex = 17;
            this.lblDescripcionBusqueda.Text = "Descripcion";
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(6, 22);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBusqueda.TabIndex = 16;
            this.lblNombreBusqueda.Text = "Nombre";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(9, 45);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(1040, 126);
            this.dgvBusqueda.TabIndex = 15;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(537, 12);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(525, 20);
            this.txbDescripcion.TabIndex = 34;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(468, 15);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 33;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(62, 12);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(400, 20);
            this.txbNombre.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 701);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpMarca);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Marca";
            this.Text = "Marca";
            this.grpMarca.ResumeLayout(false);
            this.grpMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpMarca;
        private System.Windows.Forms.TextBox txbDescripcionBusqueda;
        private System.Windows.Forms.TextBox txbNombreBusqueda;
        private System.Windows.Forms.Label lblDescripcionBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}