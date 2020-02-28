using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MaximoSystem.Controllers.Repositorios;
using MaximoSystem.Entidades;
using MaximoSystem.Model;

namespace MaximoSystem.WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class FuncionarioService : IFuncionario
    {
        private FuncionarioRep rep = new FuncionarioRep();
        public void Cadastrar(Funcionario obj)
        {
            rep.Cadastrar(obj);
        }

        public Funcionario Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public List<Funcionario> Listar()
        {
            return rep.listar();
        }

        public void Deletar(Funcionario obj)
        {
            rep.Deletar(obj);
        }

        public void Modificar(Funcionario obj)
        {
            rep.Modificar(obj);
        }
    }
}
