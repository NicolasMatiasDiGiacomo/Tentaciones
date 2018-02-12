namespace UI.Servicios
{
    partial class Backup
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.txbRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(369, 64);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(288, 64);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Location = new System.Drawing.Point(26, 16);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(85, 13);
            this.lblRutaArchivo.TabIndex = 2;
            this.lblRutaArchivo.Text = "Ruta del archivo";
            // 
            // txbRutaArchivo
            // 
            this.txbRutaArchivo.Location = new System.Drawing.Point(117, 12);
            this.txbRutaArchivo.Name = "txbRutaArchivo";
            this.txbRutaArchivo.Size = new System.Drawing.Size(286, 20);
            this.txbRutaArchivo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(409, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbNombreArchivo
            // 
            this.txbNombreArchivo.Location = new System.Drawing.Point(117, 38);
            this.txbNombreArchivo.Name = "txbNombreArchivo";
            this.txbNombreArchivo.Size = new System.Drawing.Size(327, 20);
            this.txbNombreArchivo.TabIndex = 6;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(12, 41);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(99, 13);
            this.lblNombreArchivo.TabIndex = 5;
            this.lblNombreArchivo.Text = "Nombre del archivo";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 99);
            this.Controls.Add(this.txbNombreArchivo);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbRutaArchivo);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Backup";
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.TextBox txbRutaArchivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreArchivo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}