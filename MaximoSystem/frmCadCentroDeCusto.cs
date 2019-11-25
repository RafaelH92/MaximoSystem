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
        frmCadCustoDespesa frmCusto;
        bool checkCancel = true;
      
        public frmCadCentroDeCusto(frmFluxoCaixa frmCaixa)
        {
            InitializeComponent();
            frm = frmCaixa;
        }
        public frmCadCentroDeCusto(frmCadCustoDespesa frmCustos)
        {

            frmCusto = frmCustos;
        }


            private void FrmCadCentroDeCusto_Load(object sender, EventArgs e)
        {
            tbControlCusto.SelectTab(0);


            btnExcluir.Visible = false;

            var Id = frmCadCustoDespesa.IdForm;

            if (Id == 1)
            {
                populaGridCusto();
            }
            else
            {
                populaGridDespesa();
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {

            frm.AddFormCadCustoDespesa();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            eventoNovo();

            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            eventoModificar();

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

           
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            eventoCancelar();
        }

        private void TbControlCusto_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = checkCancel;
            checkCancel = true;
        }
        void eventoNovo()
        {
            checkCancel = false;

            //SELECIONA A TAB
            tbControlCusto.SelectTab(1);

            //MUDA O TEXTO CONFORME O EVENTO
            btnSalvar.Text = "Salvar";

            //DEIXA INVISIVEL O BOTNÃO 'NOVO'
            btnNovo.Visible = false;
            btnModificar.Visible = false;

            //LIMPA AS TXT
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            ckbInativo.Checked = false;

            // ATRIBUI O FOCO NA TXT CÓDIGO
            txtCodigo.Focus();
        }
        void eventoModificar()
        {
            checkCancel = false;

            btnNovo.Visible = false;
            btnModificar.Visible = false;
            btnExcluir.Visible = true;

            //PASSA PARA AS TXT OS VALORES SELECIONADOS NO GRID
            txtCodigo.Text = dgvCusto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvCusto.CurrentRow.Cells[1].Value.ToString();


            txtCodigo.SelectionStart = 0;

            //MUDA O TEXTO CONFORME O EVENTO
            btnSalvar.Text = "Modificar";

            //SEELCUINA A PAGINA 2
            tbControlCusto.SelectTab(1);
        }
        void eventoCancelar()
        {
            checkCancel = false;

            //SELECIONA A TAB
            tbControlCusto.SelectTab(0);

            //DEIXA INVISIVEL O BOTNÃO 'NOVO'
            btnNovo.Visible = true;
            btnModificar.Visible = true;
            btnExcluir.Visible = false;
        }

        public void populaGridCusto()
        {
            dgvCusto.Rows.Add(50302, "AGRICOLA", "S");
            dgvCusto.Rows.Add(50337, "TRANSPORTE", "S");
            dgvCusto.Rows.Add(50369, "INDUSTRIA", "S");
            dgvCusto.Rows.Add(50306, "REFEITÓRIO", "S");
            dgvCusto.Rows.Add(50302, "AGRICOLA", "S");
            dgvCusto.Rows.Add(50337, "TRANSPORTE", "S");
            dgvCusto.Rows.Add(50369, "INDUSTRIA", "S");
            dgvCusto.Rows.Add(50306, "REFEITÓRIO", "S");
            dgvCusto.ClearSelection();
        }

        public void populaGridDespesa()
        {
            dgvCusto.Rows.Add(20110, "CONSERVAÇÃO/LIMPEZA", "S");
            dgvCusto.Rows.Add(20111, "MATERIAIS DIVERSOS", "S");
            dgvCusto.Rows.Add(20112, "FRETES E CARRETOS PESSOA FÍSICA", "S");
            dgvCusto.ClearSelection();
        }
    }
}
