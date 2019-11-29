using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Controllers;
using MaximoSystem.Entidades;

namespace MaximoSystem.Controllers.Map
{
    class CdespesaMap : EntityTypeConfiguration<Cdespesa>
    {
        public CdespesaMap() //MAPEANDO A CLASSE CDESPESAS
        {
            this.ToTable("CDESPESAS");
            this.HasKey(d => new { d.Id_cdes, d.Cd_cdespesa});
            this.Property(d => d.Id_cdes).HasColumnName("ID_CDES");
            this.Property(d => d.Cd_cdespesa).HasColumnName("CD_CDESPESA");
            this.Property(d => d.De_cdespesa).HasColumnName("DE_CDESPESA").IsRequired();
            this.Property(d => d.Fg_inativo).HasColumnName("FG_INATIVO").IsRequired();

        }
    }
}
