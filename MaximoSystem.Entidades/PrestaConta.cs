using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class PrestaConta
    {
        public int Id_pre_con { get; set; }
        public DateTime Dt_movimento { get; set; }
        public int Id_cc { get; set; }
        public int Cd_custo { get; set; }
        public virtual Ccusto Ccusto { get; set; }
        public int Id_cdes { get; set; }
        public int Cd_cdespesa { get; set; }
        public virtual Cdespesa Cdespesa { get; set; }
        public decimal Vl_saida { get; set; }
        public EnumAtivoInativo Fg_disponivel { get; set; }
    }
}
