using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class HistPrestaConta
    {
        public int Id_his_pre_con { get; set; }
        public DateTime Dt_processamento { get; set; }
        public int Id_cc { get; set; }
        public long Cd_custo { get; set; }
        public virtual Ccusto Ccusto { get; set; }
        public int Id_cdes { get; set; }
        public long Cd_cdespesa { get; set; }
        public virtual Cdespesa Cdespesa { get; set; }
        public decimal Valor { get; set; }
        
    }
}