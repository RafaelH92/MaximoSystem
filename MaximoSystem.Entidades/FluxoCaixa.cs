using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class FluxoCaixa
    {
        public int Id_Flca { get; set; }
        public DateTime Dt_movimento { get; set; }
        public int Id_func { get; set; }
        public long Cd_func { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public string De_operacao { get; set; }
        public decimal Valor { get; set; }
        public EnumTpOper Tp_oper { get; set; }

    }
}
