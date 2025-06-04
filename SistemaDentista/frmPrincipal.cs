using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDentista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }

        private void MSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAgDentistas_Click(object sender, EventArgs e)
        {
            FrmConDentista frm = new FrmConDentista();
            frm.ShowDialog();
        }

        private void menuPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void menuAgPacientes_Click(object sender, EventArgs e)
        {
            FrmConPaciente frm = new FrmConPaciente();
            frm.ShowDialog();
        }
    }
}
