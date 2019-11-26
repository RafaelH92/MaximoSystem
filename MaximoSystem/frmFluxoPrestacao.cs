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
    public partial class frmFluxoPrestacao : Form
    {
        frmFluxoCaixa frmCaixa;
        int idForm;

        public frmFluxoPrestacao(frmFluxoCaixa frm)
        {
            InitializeComponent();

            this.frmCaixa = frm;
        }

        private void FrmFluxoPrestacao_Load(object sender, EventArgs e)
        {

        }
        public int AddForm( int idForm)
        {
            //LIMPA O PAINEL
            frmCaixa.pnlBody.Controls.Clear();


            if (idForm==1)
            {

                //INSTANCIA O FORM DO FLUXO DE CAIXA
                frmMovimentacao newFrm = new frmMovimentacao(frmCaixa);

                //DEFINE O PROPRIEDADE TOPLEVEL COMO FALSE
                newFrm.TopLevel = false;

                newFrm.Height = frmCaixa.pnlBody.Height;
                newFrm.Width = frmCaixa.pnlBody.Width;


                frmCaixa.pnlBody.Controls.Add(newFrm);
                newFrm.Show();
            }
            else
            {
                //INSTANCIA O FORM DA PRESTAÇÃO DE CONTAS
                frmPrestacaoContas newFrm = new frmPrestacaoContas(frmCaixa);

                //DEFINE O PROPRIEDADE TOPLEVEL COMO FALSE
                newFrm.TopLevel = false;

                newFrm.Height = frmCaixa.pnlBody.Height;
                newFrm.Width = frmCaixa.pnlBody.Width;


                frmCaixa.pnlBody.Controls.Add(newFrm);
                newFrm.Show();
            };
                                 

           
            return idForm;
        }

        private void BtnFluxoCaixa_Click(object sender, EventArgs e)
        {
            idForm = 1;

            var Id = AddForm(idForm);


        }

        private void BtnContaDespesa_Click(object sender, EventArgs e)
        {
            idForm = 2;
             var Id = AddForm(idForm);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
