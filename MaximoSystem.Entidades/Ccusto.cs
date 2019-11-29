using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class Ccusto
    {
        public int Id_cc { get; set; }
        public long Cd_custo { get; set; }
        public string De_custo { get; set; }
        public EnumAtivoInativo Fg_ativo { get; set; }

    }
}
