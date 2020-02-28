using MaximoSystem.WcfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximoSystem.Entidades;

namespace MaximoSystem
{
    public partial class frmCadFuncionario : Form
    {
        FuncionarioService service = new FuncionarioService();
        
        frmFluxoCaixa frm;
        frmCcustoDespesa frmCusto;
        bool checkCancel = true;


        public frmCadFuncionario(frmFluxoCaixa frmCaixa)
        {
            InitializeComponent();
            frm = frmCaixa;

        }
     
        public frmCadFuncionario(frmCcustoDespesa frmCustos)
        {

            frmCusto = frmCustos;
        }

            private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maximosystemDataSetFuncionarios.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.maximosystemDataSetFuncionarios.FUNCIONARIOS);


            tbControlFunc.SelectTab(0);


            btnExcluir.Visible = false;

            var Id = frmCcustoDespesa.IdForm;


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

            try
            {

                service.Deletar(objGeradoMod());
                MessageBox.Show("O FUNCIONÁRIO " + objGeradoMod().De_func + " FOI DELETADO COM SUCESSO!");
                this.fUNCIONARIOSTableAdapter.Fill(this.maximosystemDataSetFuncionarios.FUNCIONARIOS);
                eventoCancelar(); // RETORNA PARA O ABA DE CADASTRO 

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);

            }



        }

        //EVENTO QUE PASSA O OBJETO PARA SER INSERIDO
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSalvar.Text == "Salvar") {

                    if (txtCodigo.Text == string.Empty)
                    {
                        MessageBox.Show("PREENCHA O CAMPO DE CODIGO");
                        txtCodigo.Focus();

                    }
                    else if (txtDescricao.Text == string.Empty)
                    {
                        MessageBox.Show("PREENCHA O NOME!");
                        txtDescricao.Focus();
                    }
                    else
                    {
                        service.Cadastrar(objGeradoCad());
                        MessageBox.Show("O FUNCIONÁRIO " + objGeradoCad().De_func + " FOI CADASTRADO COM SUCESSO!");
                        this.fUNCIONARIOSTableAdapter.Fill(this.maximosystemDataSetFuncionarios.FUNCIONARIOS); //ATUALIZA O DATA GRID
                        eventoCancelar(); // RETORNA PARA O ABA DE CADASTRO 

                    }

                    
                }

                if (btnSalvar.Text == "Modificar")
                {

                    if (txtCodigo.Text == string.Empty)
                    {
                        MessageBox.Show("PREENCHA O CAMPO DE CODIGO");
                        txtCodigo.Focus();

                    }
                    else if (txtDescricao.Text == string.Empty)
                    {
                        MessageBox.Show("PREENCHA O NOME!");
                        txtDescricao.Focus();
                    }
                    else
                    {
                        service.Modificar(objGeradoMod());
                        MessageBox.Show("O FUNCIONÁRIO " + objGeradoMod().De_func + " FOI MODIFICADO COM SUCESSO!");
                        this.fUNCIONARIOSTableAdapter.Fill(this.maximosystemDataSetFuncionarios.FUNCIONARIOS); //ATUALIZA O DATA GRID
                        eventoCancelar(); // RETORNA PARA O ABA DE CADASTRO 
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);

            }
        }

        //EVENTO QUE PASSA O OBJETO PARA SER MODIFICADO OU EXLUIDO
        public Funcionario objGeradoMod()
        {
            Funcionario obj = new Funcionario();
            obj.Id_func = txtId.Text != "" ? Convert.ToInt32(txtId.Text) : 0;
            obj.Cd_func = txtCodigo.Text != "" ? Convert.ToInt64(txtCodigo.Text) : 0; //CONVERTE LONG PARA STRING UTILIZANDO O IF IN-LINE
            obj.De_func = txtDescricao.Text;
            if (ckbInativo.Checked)
            {
                obj.Fg_ativo = obj.Fg_ativo + 1;
            }
            else
            {
                obj.Fg_ativo = 0;
            } 

            return obj;
        }

        public Funcionario objGeradoCad()
        {
            Funcionario obj = new Funcionario(); 
            obj.Cd_func = txtCodigo.Text != "" ? Convert.ToInt64(txtCodigo.Text) : 0; //CONVERTE LONG PARA STRING UTILIZANDO O IF IN-LINE
            obj.De_func = txtDescricao.Text;

            return obj;
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
            tbControlFunc.SelectTab(1);

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
            txtId.Text = dgvFunc.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgvFunc.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvFunc.CurrentRow.Cells[2].Value.ToString();

            //VERIFICA SE O CADASTRO ESTA ATIVO OU INATIVO E CARREGA NO FORM
            var Chek = dgvFunc.CurrentRow.Cells[3].Value.ToString();
            if (Chek == "0")
            {
                ckbInativo.Checked = false;
            }
            else
            {
                ckbInativo.Checked = true;
            }
            

            txtCodigo.SelectionStart = 0;

            //MUDA O TEXTO CONFORME O EVENTO
            btnSalvar.Text = "Modificar";

            //SEELCUINA A PAGINA 2
            tbControlFunc.SelectTab(1);
        }
        void eventoCancelar()
        {
            checkCancel = false;

            //SELECIONA A TAB
            tbControlFunc.SelectTab(0);

            //DEIXA INVISIVEL O BOTNÃO 'NOVO'
            btnNovo.Visible = true;
            btnModificar.Visible = true;
            btnExcluir.Visible = false;
        }


    }
}
