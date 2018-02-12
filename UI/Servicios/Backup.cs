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
    public partial class Backup : Form
    {
        DAL.DALBackup dalBackup = new DAL.DALBackup();
        Entidades.Backup backup = new Entidades.Backup();
        public Backup()
        {
            InitializeComponent();
            //string nombre = "Marco";
            //string nombreEncriptado = new Criptografia().encriptar(nombre);
            //string nombreDesencriptado = new Criptografia().desencriptar(nombreEncriptado);
            //MessageBox.Show(nombreEncriptado);
            //MessageBox.Show(nombreDesencriptado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txbRutaArchivo.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbRutaArchivo.Text) || string.IsNullOrWhiteSpace(txbNombreArchivo.Text)) 
            {
                MessageBox.Show("Debe seleccionar una ruta");
                return;
            }

            //revisar donde se puede hacer el backup + validar si esta o no /
            backup.ruta = txbRutaArchivo.Text + "\\" + txbNombreArchivo.Text;
            txbRutaArchivo.Clear();
            txbNombreArchivo.Clear();
            dalBackup.crearBackup(backup);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbRutaArchivo.Text) || string.IsNullOrWhiteSpace(txbNombreArchivo.Text))
            {
                MessageBox.Show("Debe seleccionar una ruta");
                return;
            }

            backup.ruta = txbRutaArchivo.Text + txbNombreArchivo.Text;
            txbRutaArchivo.Clear();
            txbNombreArchivo.Clear();
            dalBackup.restaurarBackup(backup);
        }
    }
}
