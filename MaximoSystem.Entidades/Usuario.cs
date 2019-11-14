using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoSystem.Entidades
{
    public class Usuario
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string User { get; set; }
        private string Senha { get; set; }

        public Usuario(int id, string nome, string usuario, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.User = usuario;
            this.Senha = senha;
        }
    }
}

