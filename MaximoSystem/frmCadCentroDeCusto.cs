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
    public partial class frmCadCentroDeCusto : Form
    {
        frmFluxoCaixa frm;
        public frmCadCentroDeCusto(frmFluxoCaixa frmCaixa)
        {
            InitializeComponent();
            this.frm = frmCaixa;
        }

        

        private void FrmCadCentroDeCusto_Load(object sender, EventArgs e)
        {
            tbControlCusto.SelectTab(0);

            btnModificar.Visible = false;
            btnExcluir.Visible = false;

           


            dgvCusto.Rows.Add(50302, "AGRICOLA","S");
            dgvCusto.Rows.Add(50337, "TRANSPORTE", "S");
            dgvCusto.Rows.Add(50369, "INDUSTRIA", "S");
            dgvCusto.Rows.Add(50306, "REFEITÓRIO", "S");

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
           
            frm.AddFormCadCustoDespesa();
        }
    }
}
