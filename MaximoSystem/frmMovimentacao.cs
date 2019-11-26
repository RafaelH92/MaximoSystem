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
    public partial class frmMovimentacao : Form
    {
        frmFluxoCaixa frmFluxo;
        public frmMovimentacao(frmFluxoCaixa frm)
        {

            frmFluxo = frm;
            InitializeComponent();
        }

        private void FrmMovimentacao_Load(object sender, EventArgs e)
        {
           
            
            dgvResumo.Rows.Add("R$ 5000,00","R$ 150,00","R$ 120,00","R$ 200,00");

            dgvFluxoCaixa.Rows.Add("1", "20/08/1990", "DIEGO FERRARINI", "GASTOS COM PUTEIRO", "", "R$ 50,00");
            dgvFluxoCaixa.Rows.Add("2", "20/08/1990", "RAFAEL VIADO", "RESTAURAÇÃO DO ANEL", "", "R$ 5000,00");

            dgvFluxoCaixa.ClearSelection();

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmFluxo.AddFormFluxoPrestacao();
        }
    }
}
