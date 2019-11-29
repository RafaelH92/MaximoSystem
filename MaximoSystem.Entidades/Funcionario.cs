using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class Funcionario
    {
        public int Id_func { get; set; }
        public long Cd_func { get; set; }
        public string De_func { get; set; }
        public EnumFuncionario Fg_ativo { get; set; }

    }
}
