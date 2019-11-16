using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.DAO;
using MaximoSystem.Entidades;
using System.Data;

namespace MaximoSystem.DAO
{
    public class UsuarioDAO
    {
        public int Inserir(Usuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open(); // ABRE A CONEXÃO COM O BANCO DE DADOS

                cn.CommandText = "INSERT INTO USUARIOS ( [NOME], [USUARIO], [SENHA] ) VALUES (@NOME, @USUARIO, @SENHA) ";
                cn.Parameters.Add("NOME", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("USUARIO", SqlDbType.VarChar).Value = objTabela.User;
                cn.Parameters.Add("SENHA", SqlDbType.VarChar).Value = objTabela.Senha;

                cn.Connection = con; //RELACIONAMENTO DE CONEXÃO

                int qtd = cn.ExecuteNonQuery(); //EXECUTA A QUERY DE INSERIR - VARIÁVEL QTD 1 - CADASTRADO COM SUCESSO, 0 - NÃO CADASTRADO 

                return qtd;

            }
        }
    }
}
