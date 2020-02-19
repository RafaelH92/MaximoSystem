using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades.Enums;

namespace MaximoSystem.Entidades
{
    public class Usuario
    {
        //public int Id { get; set; }
        public string Nome { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
        public EnumAtivoInativo Fg_ativo { get; set; }

    }
}

