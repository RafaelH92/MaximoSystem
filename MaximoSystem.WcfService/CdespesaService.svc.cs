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
    public class CdespesaService : ICdespesa
    {
        private CdespesaRep rep = new CdespesaRep();
        public void Cadastrar(Cdespesa obj)
        {
            rep.Cadastrar(obj);
        }

        public Cdespesa Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public List<Cdespesa> Listar()
        {
            return rep.listar();
        }

        public void Deletar(Cdespesa obj)
        {
            rep.Deletar(obj);
        }

        public void Modificar(Cdespesa obj)
        {
            rep.Modificar(obj);
        }
    }
}
