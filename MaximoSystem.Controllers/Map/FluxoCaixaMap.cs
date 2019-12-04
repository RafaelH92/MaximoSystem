using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;

namespace MaximoSystem.Controllers.Map
{
    public class FluxoCaixaMap : EntityTypeConfiguration<FluxoCaixa>
    {
        public FluxoCaixaMap()
        {
            this.ToTable("FLUXO_CAIXA");
            this.HasKey(d => d.Id_Flca);
            this.Property(d => d.Id_Flca).HasColumnName("ID_FLCA");
            this.Property(d => d.Dt_movimento).HasColumnName("DT_MOVIMENTO").IsRequired();
            this.Property(d => d.Id_func).HasColumnName("ID_FUNC");
            this.Property(d => d.Cd_func).HasColumnName("CD_FUNC");
            this.Property(d => d.De_operacao).HasColumnName("DE_OPERACAO").IsRequired();
            this.Property(d => d.Valor).HasColumnName("VALOR").IsRequired();
            this.Property(d => d.Tp_oper).HasColumnName("TP_OPER").IsRequired();

        }
    }
}
