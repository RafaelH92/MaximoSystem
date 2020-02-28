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
    
    
    public partial class frmCcustoDespesa : Form
    {
        frmFluxoCaixa frmCaixa;

        public static int IdForm;
        public frmCcustoDespesa(frmFluxoCaixa frm)
        {
            InitializeComponent();

            this.frmCaixa = frm;
        }

       
        private void FrmCadCustoDespesa_Load(object sender, EventArgs e)
        {

        }

        private void BtnCentroDeCusto_Click(object sender, EventArgs e)
        {
            IdForm = 1;
            AddFormCusto();

        }

        private void BtnContaDespesa_Click(object sender, EventArgs e)
        {
            IdForm = 2;
            AddFormDespesa();
           
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

            IdForm = 3;
            AddFormFuncionario();

        }
        public void AddFormCusto()
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

        public void AddFormDespesa()
        {
            //LIMPA O PAINEL
            frmCaixa.pnlBody.Controls.Clear();

            //INSTANCIA O FORM DO CADASTRO DE CONTA DESPESA
            frmCadDespesa frmDespesa = new frmCadDespesa(frmCaixa);

            //DEFINE O PROPRIEDADE TOPLEVEL COMO FALSE
            frmDespesa.TopLevel = false;

            frmDespesa.Height = frmCaixa.pnlBody.Height;
            frmDespesa.Width = frmCaixa.pnlBody.Width;


            frmCaixa.pnlBody.Controls.Add(frmDespesa);



            frmDespesa.Show();

        }

        public void AddFormFuncionario()
        {
            //LIMPA O PAINEL
            frmCaixa.pnlBody.Controls.Clear();

            //INSTANCIA O FORM DO CADASTRO DE FUNCIONÁRIOS
            frmCadFuncionario frmFunc = new frmCadFuncionario(frmCaixa);

            //DEFINE O PROPRIEDADE TOPLEVEL COMO FALSE
            frmFunc.TopLevel = false;

            frmFunc.Height = frmCaixa.pnlBody.Height;
            frmFunc.Width = frmCaixa.pnlBody.Width;


            frmCaixa.pnlBody.Controls.Add(frmFunc);



            frmFunc.Show();

        }

    }
}
