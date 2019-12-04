namespace MaximoSystem.Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CCUSTOS",
                c => new
                    {
                        ID_CC = c.Int(nullable: false),
                        CD_CUSTO = c.Long(nullable: false),
                        DE_CUSTO = c.String(nullable: false),
                        FG_INATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_CC, t.CD_CUSTO });
            
            CreateTable(
                "dbo.CDESPESAS",
                c => new
                    {
                        ID_CDES = c.Int(nullable: false),
                        CD_CDESPESA = c.Long(nullable: false),
                        DE_CDESPESA = c.String(nullable: false),
                        FG_INATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_CDES, t.CD_CDESPESA });
            
            CreateTable(
                "dbo.FLUXO_CAIXA",
                c => new
                    {
                        ID_FLCA = c.Int(nullable: false, identity: true),
                        DT_MOVIMENTO = c.DateTime(nullable: false),
                        ID_FUNC = c.Int(nullable: false),
                        CD_FUNC = c.Long(nullable: false),
                        DE_OPERACAO = c.String(nullable: false),
                        VALOR = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TP_OPER = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_FLCA)
                .ForeignKey("dbo.FUNCIONARIOS", t => new { t.ID_FUNC, t.CD_FUNC }, cascadeDelete: true)
                .Index(t => new { t.ID_FUNC, t.CD_FUNC });
            
            CreateTable(
                "dbo.FUNCIONARIOS",
                c => new
                    {
                        ID_FUNC = c.Int(nullable: false),
                        CD_FUNC = c.Long(nullable: false),
                        DE_FUNC = c.String(nullable: false),
                        FG_ATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_FUNC, t.CD_FUNC });
            
            CreateTable(
                "dbo.PRESTACONTAS",
                c => new
                    {
                        ID_PRE_CON = c.Int(nullable: false, identity: true),
                        DT_MOVIMENTO = c.DateTime(nullable: false),
                        ID_CC = c.Int(nullable: false),
                        CD_CUSTO = c.Int(nullable: false),
                        ID_CDES = c.Int(nullable: false),
                        CD_CDESPESA = c.Int(nullable: false),
                        VL_SAIDA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FG_DISPONIVEL = c.Int(nullable: false),
                        Ccusto_Id_cc = c.Int(),
                        Ccusto_Cd_custo = c.Long(),
                        Cdespesa_Id_cdes = c.Int(),
                        Cdespesa_Cd_cdespesa = c.Long(),
                    })
                .PrimaryKey(t => t.ID_PRE_CON)
                .ForeignKey("dbo.CCUSTOS", t => new { t.Ccusto_Id_cc, t.Ccusto_Cd_custo })
                .ForeignKey("dbo.CDESPESAS", t => new { t.Cdespesa_Id_cdes, t.Cdespesa_Cd_cdespesa })
                .Index(t => new { t.Ccusto_Id_cc, t.Ccusto_Cd_custo })
                .Index(t => new { t.Cdespesa_Id_cdes, t.Cdespesa_Cd_cdespesa });
            
            CreateTable(
                "dbo.USUARIOS",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false),
                        USUARIO_SISTEMA = c.String(nullable: false, maxLength: 128),
                        NOME_USUARIO = c.String(nullable: false),
                        SENHA_USUARIO = c.String(nullable: false),
                        FG_USUARIO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_USUARIO, t.USUARIO_SISTEMA });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRESTACONTAS", new[] { "Cdespesa_Id_cdes", "Cdespesa_Cd_cdespesa" }, "dbo.CDESPESAS");
            DropForeignKey("dbo.PRESTACONTAS", new[] { "Ccusto_Id_cc", "Ccusto_Cd_custo" }, "dbo.CCUSTOS");
            DropForeignKey("dbo.FLUXO_CAIXA", new[] { "ID_FUNC", "CD_FUNC" }, "dbo.FUNCIONARIOS");
            DropIndex("dbo.PRESTACONTAS", new[] { "Cdespesa_Id_cdes", "Cdespesa_Cd_cdespesa" });
            DropIndex("dbo.PRESTACONTAS", new[] { "Ccusto_Id_cc", "Ccusto_Cd_custo" });
            DropIndex("dbo.FLUXO_CAIXA", new[] { "ID_FUNC", "CD_FUNC" });
            DropTable("dbo.USUARIOS");
            DropTable("dbo.PRESTACONTAS");
            DropTable("dbo.FUNCIONARIOS");
            DropTable("dbo.FLUXO_CAIXA");
            DropTable("dbo.CDESPESAS");
            DropTable("dbo.CCUSTOS");
        }
    }
}
