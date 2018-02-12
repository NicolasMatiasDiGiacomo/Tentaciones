using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Clientes
{
    public partial class Pagos : Form
    {
        DAL.DALTipoPago dalTipoPago = new DAL.DALTipoPago();
        public Pagos()
        {
            InitializeComponent();
            cmbTipoPago.DataSource = dalTipoPago.buscarTipoPago(new Entidades.TipoPago());
            cmbTipoPago.DisplayMember = "nombre";
            cmbTipoPago.ValueMember = "idTipoPago";
        }
    }
}
