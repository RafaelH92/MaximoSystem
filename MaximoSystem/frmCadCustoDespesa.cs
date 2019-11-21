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
        frmFluxoCaixa frmCaixa;
        public frmCadCustoDespesa(frmFluxoCaixa frm)
        {
            InitializeComponent();

            this.frmCaixa = frm;
        }

       
        private void FrmCadCustoDespesa_Load(object sender, EventArgs e)
        {

        }

        private void BtnCentroDeCusto_Click(object sender, EventArgs e)
        {
            AddFormCadCentroDeCusto();
            
        }

       public void AddFormCadCentroDeCusto()
        {
            //LIMPA O PAINEL
            frmCaixa.pnlBody.Controls.Clear();

            //INSTANCIA O FORM DO CADASTRO DE CENTRO DE CUSTO
            frmCadCentroDeCusto frmCusto = new frmCadCentroDeCusto(frmCaixa);

            //DEFINE O PROPRIEDADE TOPLEVEL COMO FALSE
            frmCusto.TopLevel = false;

            frmCusto.Height = frmCaixa.pnlBody.Height;
            frmCusto.Width = frmCaixa.pnlBody.Width;

            
            frmCaixa.pnlBody.Controls.Add(frmCusto);


            
            frmCusto.Show();

        }
    }
}
