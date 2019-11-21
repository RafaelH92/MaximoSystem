using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace MaximoSystem
{
    public partial class frmHome : MetroFramework.Forms.MetroForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnTerceiros_Click(object sender, EventArgs e)
        {

        }

        private void BtnFluxoCaixa_Click(object sender, EventArgs e)
        {
            frmFluxoCaixa frm = new frmFluxoCaixa();
            frm.Show();
        }

        private void BtnVerificacoes_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
