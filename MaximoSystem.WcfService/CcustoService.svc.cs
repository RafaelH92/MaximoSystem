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
    public class CcustoService : ICcusto
    {
        private CcustoRep rep = new CcustoRep();
        public void Cadastrar (Ccusto obj)
        {
            rep.Cadastrar(obj);
        }

        public Ccusto Buscar (int id)
        {
           return rep.Buscar(id);
        }

        public List<Ccusto> Listar()
        {
            return rep.listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Modificar(Ccusto objNew)
        {
            rep.Modificar(objNew);
        }
    }
}
