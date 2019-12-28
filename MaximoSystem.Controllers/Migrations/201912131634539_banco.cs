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
                "dbo.HIST_PRESTA_CONTAS",
                c => new
                    {
                        ID_HIS_PRE_CON = c.Int(nullable: false, identity: true),
                        DT_PROCESSAMENTO = c.DateTime(nullable: false),
                        ID_CC = c.Int(nullable: false),
                        CD_CUSTO = c.Long(nullable: false),
                        ID_CDES = c.Int(nullable: false),
                        CD_CDESPESA = c.Long(nullable: false),
                        VALOR = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_HIS_PRE_CON)
                .ForeignKey("dbo.CCUSTOS", t => new { t.ID_CC, t.CD_CUSTO }, cascadeDelete: true)
                .ForeignKey("dbo.CDESPESAS", t => new { t.ID_CDES, t.CD_CDESPESA }, cascadeDelete: true)
                .Index(t => new { t.ID_CC, t.CD_CUSTO })
                .Index(t => new { t.ID_CDES, t.CD_CDESPESA });
            
            CreateTable(
                "dbo.PRESTA_CONTAS",
                c => new
                    {
                        ID_PRE_CON = c.Int(nullable: false, identity: true),
                        DT_MOVIMENTO = c.DateTime(nullable: false),
                        ID_CC = c.Int(nullable: false),
                        CD_CUSTO = c.Long(nullable: false),
                        ID_CDES = c.Int(nullable: false),
                        CD_CDESPESA = c.Long(nullable: false),
                        VL_SAIDA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FG_DISPONIVEL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PRE_CON)
                .ForeignKey("dbo.CCUSTOS", t => new { t.ID_CC, t.CD_CUSTO }, cascadeDelete: true)
                .ForeignKey("dbo.CDESPESAS", t => new { t.ID_CDES, t.CD_CDESPESA }, cascadeDelete: true)
                .Index(t => new { t.ID_CC, t.CD_CUSTO })
                .Index(t => new { t.ID_CDES, t.CD_CDESPESA });
            
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
            DropForeignKey("dbo.PRESTA_CONTAS", new[] { "ID_CDES", "CD_CDESPESA" }, "dbo.CDESPESAS");
            DropForeignKey("dbo.PRESTA_CONTAS", new[] { "ID_CC", "CD_CUSTO" }, "dbo.CCUSTOS");
            DropForeignKey("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CDES", "CD_CDESPESA" }, "dbo.CDESPESAS");
            DropForeignKey("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CC", "CD_CUSTO" }, "dbo.CCUSTOS");
            DropForeignKey("dbo.FLUXO_CAIXA", new[] { "ID_FUNC", "CD_FUNC" }, "dbo.FUNCIONARIOS");
            DropIndex("dbo.PRESTA_CONTAS", new[] { "ID_CDES", "CD_CDESPESA" });
            DropIndex("dbo.PRESTA_CONTAS", new[] { "ID_CC", "CD_CUSTO" });
            DropIndex("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CDES", "CD_CDESPESA" });
            DropIndex("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CC", "CD_CUSTO" });
            DropIndex("dbo.FLUXO_CAIXA", new[] { "ID_FUNC", "CD_FUNC" });
            DropTable("dbo.USUARIOS");
            DropTable("dbo.PRESTA_CONTAS");
            DropTable("dbo.HIST_PRESTA_CONTAS");
            DropTable("dbo.FUNCIONARIOS");
            DropTable("dbo.FLUXO_CAIXA");
            DropTable("dbo.CDESPESAS");
            DropTable("dbo.CCUSTOS");
        }
    }
}
