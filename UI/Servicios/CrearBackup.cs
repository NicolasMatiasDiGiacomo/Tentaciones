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
    public partial class CrearBackup : Form
    {
        DAL.DALBackup dalBackup = new DAL.DALBackup();
        Entidades.Backup backup = new Entidades.Backup();
        public CrearBackup()
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
            MessageBox.Show("La ruta default es : C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNombreArchivo.Text)) 
            {
                MessageBox.Show("Debe seleccionar una ruta");
                return;
            }

            //revisar donde se puede hacer el backup + validar si esta o no /
            backup.ruta = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + txbNombreArchivo.Text;
            txbNombreArchivo.Clear();
            dalBackup.crearBackup(backup);
        }
    }
}
