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
    public interface ICdespesa
    {
        [OperationContract]
        void Cadastrar(Cdespesa obj);

        [OperationContract]
        Cdespesa Buscar(int id);

        [OperationContract]
        List<Cdespesa> Listar();

        [OperationContract]
        void Deletar(Cdespesa obj);

        [OperationContract]
        void Modificar(Cdespesa obj);
    }
}
