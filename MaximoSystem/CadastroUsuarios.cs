using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MaximoSystem.Entidades;
using MaximoSystem.Model;

namespace MaximoSystem
{
    public partial class frmCadUsuario : MetroForm
    {
        Usuario objTabela = new Usuario();

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            IniciarOpc();
           
        }

        private string opc = "";

        private void IniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;
                case "Salvar":
                    try
                    {
                        objTabela.Nome = txtNome.Text;
                        objTabela.User = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Inserir(objTabela); 

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} foi cadastrado!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não cadastrado");
                        }

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro " + ex.Message);

                        
                    }
                    break;
                case "Excluir":
                    break;
                case "Editar":
                    break;
                default:
                    break;
            }
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            IniciarOpc();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            IniciarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            IniciarOpc();
        }
    }
}
