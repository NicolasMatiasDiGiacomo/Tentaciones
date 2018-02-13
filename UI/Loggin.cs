using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Seguridad;

namespace UI
{
    public partial class Loggin : Form
    {
        DAL.DALUsuario dalUsuario = new DAL.DALUsuario();
        Entidades.Usuario usuario = new Entidades.Usuario();
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsuario.Text) || string.IsNullOrWhiteSpace(txbContraseña.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            usuario.usuario = txbUsuario.Text;
            usuario.contraseña = new Criptografia().encriptar(txbContraseña.Text);
            List<object> usuarios = new List<object>(); 
            usuarios = dalUsuario.validarUsuario(usuario);
            if (!usuarios.Any())
            {
                MessageBox.Show("El usuario no es correcto");
                return;
            }

            usuarios = dalUsuario.validarContraseña(usuario);
            if (!usuarios.Any())
            {
                MessageBox.Show("La contraseña no es correcta");
                return;
            }

            Sesion.activa().usuario = (Entidades.Usuario)usuarios.First();
            UI.Menu menuForm = new UI.Menu();
            this.Hide();
            menuForm.ShowDialog(this);
            this.Show();
            txbUsuario.Clear();
            txbContraseña.Clear();
            usuarios = new List<object>();
        }
    }
}
