using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.DAO;
using MaximoSystem.Entidades;

namespace MaximoSystem.Model
{
    public class UsuarioModel
    {
        public static int Inserir(Usuario objTabela)
        {
            return new UsuarioDAO().Inserir(objTabela);
        }
    }
}
