using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;

namespace MaximoSystem.Controllers.Map
{
    class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            this.ToTable("FUNCIONARIOS");
            this.HasKey(d => new { d.Id_func, d.Cd_func });
            this.Property(d => d.Id_func).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(d => d.Id_func).HasColumnName("ID_FUNC");
            this.Property(d => d.Cd_func).HasColumnName("CD_FUNC").HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } })); ;
            this.Property(d => d.De_func).HasColumnName("DE_FUNC").IsRequired();
            this.Property(d => d.Fg_ativo).HasColumnName("FG_ATIVO").IsRequired();
               
        }
    }
}
