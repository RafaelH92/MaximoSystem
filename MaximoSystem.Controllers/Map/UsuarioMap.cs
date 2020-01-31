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
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            this.ToTable("USUARIOS");
            this.HasKey(d => new { d.Id, d.User });
            this.Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(d => d.Id).HasColumnName("ID_USUARIO");
            this.Property(d => d.Nome).HasColumnName("NOME_USUARIO").IsRequired();
            this.Property(d => d.User).HasColumnName("USUARIO_SISTEMA").IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } })); ;
            this.Property(d => d.Senha).HasColumnName("SENHA_USUARIO").IsRequired();
            this.Property(d => d.Fg_ativo).HasColumnName("FG_USUARIO").IsRequired();
            
            
        }
    }
}
