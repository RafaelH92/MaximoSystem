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
    public partial class frmPrestacaoContas : Form
    {
        frmFluxoCaixa frmFluxo;
        public frmPrestacaoContas(frmFluxoCaixa frm)
        {
            InitializeComponent();

            frmFluxo = frm;
        }

        private void FrmPrestacaoContas_Load(object sender, EventArgs e)
        {

        }
    }
}
