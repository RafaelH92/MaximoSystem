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
    public partial class frmFluxoCaixa : MetroFramework.Forms.MetroForm
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void FrmFluxoCaixa_Load(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Close();
        }

        private void BtmCadastros_Click(object sender, EventArgs e)
        {
            pnlItemAtivo.Top = btmCadastros.Top;
            frmCadCustoDespesa frm = new frmCadCustoDespesa();
            frm.TopLevel = false;
            
            frm.Height = pnlBody.Height; 
            frm.Width = pnlBody.Width;

            pnlBody.Controls.Add(frm);
           
            frm.ShowDialog(this);
        }

        private void BtnMovimentacoes_Click(object sender, EventArgs e)
        {
            pnlItemAtivo.Top = btnMovimentacoes.Top;
        }

        private void BtnProcessamento_Click(object sender, EventArgs e)
        {
            pnlItemAtivo.Top = btnProcessamento.Top;
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            pnlItemAtivo.Top = btnRelatorio.Top;
        }
    }
}
