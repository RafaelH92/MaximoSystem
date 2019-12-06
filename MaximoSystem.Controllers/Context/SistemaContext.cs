using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using MaximoSystem.Controllers.Map;
using MaximoSystem.Entidades;

namespace MaximoSystem.Controllers.Context
{
    class SistemaContext : DbContext 
    {
        public SistemaContext() : base ("Server=CP0490\\SQLEXPRESS; Database=maximosystem; Integrated Security=True;")
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Ccusto> Ccusto  { get; set; }
        public DbSet<Cdespesa> Cdespesa { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<FluxoCaixa> FluxoCaixa { get; set; }
        public DbSet<PrestaConta> PrestaConta { get; set; }
        public DbSet<HistPrestaConta> HistPrestaConta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //ACESSA AS TABELAS/OBJETOS E GERA O CONTEXTO
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new CcustoMap());
            modelBuilder.Configurations.Add(new CdespesaMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new FluxoCaixaMap());
            modelBuilder.Configurations.Add(new PrestaContaMap());
            modelBuilder.Configurations.Add(new HistPrestaContaMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
