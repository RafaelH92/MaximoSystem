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
    class CcustoMap : EntityTypeConfiguration<Ccusto>
    {
        public CcustoMap() // MAPEANDO A CLASSE CCUSTOS
        {
            this.ToTable("CCUSTOS");
            // this.HasKey(d => new { d.Id_cc, d.Cd_custo });
            this.HasKey(d => d.Id_cc);
            this.Property(d => d.Id_cc).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(d => d.Id_cc).HasColumnName("ID_CC");
            this.Property(d => d.Cd_custo).HasColumnName("CD_CUSTO").IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } })); 
            this.Property(d => d.De_custo).HasColumnName("DE_CUSTO").IsRequired();
            this.Property(d => d.Fg_ativo).HasColumnName("FG_INATIVO").IsRequired();
        
        }
    }
}
