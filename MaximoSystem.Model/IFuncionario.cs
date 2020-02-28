using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;

namespace MaximoSystem.Model
{
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        void Cadastrar(Funcionario obj);

        [OperationContract]
        Funcionario Buscar(int id);

        [OperationContract]
        List<Funcionario> Listar();

        [OperationContract]
        void Deletar(Funcionario obj);

        [OperationContract]
        void Modificar(Funcionario obj);
    }
}
