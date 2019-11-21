using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximoSystem
{
    
    public partial class frmCadCustoDespesa : Form
    {
        frmFluxoCaixa frm;
        public frmCadCustoDespesa(Form form)
        {
            InitializeComponent();

           // form = this.frm;
        }

        public frmCadCustoDespesa()
        {
        }

        private void FrmCadCustoDespesa_Load(object sender, EventArgs e)
        {

        }

        private void BtnCentroDeCusto_Click(object sender, EventArgs e)
        {
            frm.pnlBody.Controls.Clear();
            frmCadCentroDeCusto frmCusto = new frmCadCentroDeCusto();
            frm.TopLevel = false;
            frm.pnlBody.Controls.Add(frmCusto);
            frm.Show();


        }
    }
}
