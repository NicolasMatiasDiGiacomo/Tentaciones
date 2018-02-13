using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace UI.Servicios
{
    public partial class RestaurarBackup : Form
    {
        DALBackup dalBackup = new DALBackup();
        Backup backup = new Backup();
        public RestaurarBackup()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txbRutaArchivo.Text = openFileDialog.FileName;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbRutaArchivo.Text))
            {
                MessageBox.Show("Debe seleccionar una ruta");
                return;
            }

            backup.ruta = txbRutaArchivo.Text;
            txbRutaArchivo.Clear();
            dalBackup.restaurarBackup(backup);
            //se puede filtrar por .bak
        }
    }
}
