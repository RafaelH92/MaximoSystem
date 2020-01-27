using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;

namespace MaximoSystem.Controllers.Map
{
    class HistPrestaContaMap : EntityTypeConfiguration<HistPrestaConta>
    {
        public HistPrestaContaMap()
        {
            this.ToTable("HIST_PRESTA_CONTAS");
            this.HasKey(d => d.Id_his_pre_con);
            this.Property(d => d.Id_his_pre_con).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(d => d.Id_his_pre_con).HasColumnName("ID_HIS_PRE_CON");
            this.Property(d => d.Dt_processamento).HasColumnName("DT_PROCESSAMENTO").IsRequired();
            this.Property(d => d.Id_cc).HasColumnName("ID_CC");
            this.Property(d => d.Cd_custo).HasColumnName("CD_CUSTO");
            this.Property(d => d.Id_cdes).HasColumnName("ID_CDES");
            this.Property(d => d.Cd_cdespesa).HasColumnName("CD_CDESPESA");
            this.Property(d => d.Valor).HasColumnName("VALOR").IsRequired();

        }
    }
}