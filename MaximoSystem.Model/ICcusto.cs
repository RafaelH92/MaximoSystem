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
    public interface ICcusto
    {
        [OperationContract]
        void Cadastrar(Ccusto obj);

        [OperationContract]
        Ccusto Buscar(int id);

        [OperationContract]
        List<Ccusto>Listar();

        [OperationContract]
        void Deletar(Ccusto obj);

        [OperationContract]
        void Modificar(Ccusto obj);
    }
}
