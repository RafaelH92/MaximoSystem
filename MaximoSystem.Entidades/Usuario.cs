using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoSystem.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, string usuario, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.User = usuario;
            this.Senha = senha;
        }
        public Usuario()
        {
            
        }
    }
}

