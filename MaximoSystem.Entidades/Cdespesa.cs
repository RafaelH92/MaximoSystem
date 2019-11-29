using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class Cdespesa
    {
        public int Id_cdes { get; set; }
        public long Cd_cdespesa { get; set; }
        public string De_cdespesa { get; set; }
        public EnumAtivoInativo Fg_inativo { get; set; }
    }
}
