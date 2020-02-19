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
                        ID_CC = c.Int(nullable: false, identity: true),
                        CD_CUSTO = c.Long(nullable: false),
                        DE_CUSTO = c.String(nullable: false),
                        FG_INATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CC)
                .Index(t => t.CD_CUSTO, unique: true, name: "Index");
            
            CreateTable(
                "dbo.CDESPESAS",
                c => new
                    {
                        ID_CDES = c.Int(nullable: false, identity: true),
                        CD_CDESPESA = c.Long(nullable: false),
                        DE_CDESPESA = c.String(nullable: false),
                        FG_INATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CDES)
                .Index(t => t.CD_CDESPESA, unique: true, name: "Index");
            
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
                .ForeignKey("dbo.FUNCIONARIOS", t => t.ID_FUNC, cascadeDelete: true)
                .Index(t => t.ID_FUNC);
            
            CreateTable(
                "dbo.FUNCIONARIOS",
                c => new
                    {
                        ID_FUNC = c.Int(nullable: false, identity: true),
                        CD_FUNC = c.Long(nullable: false),
                        DE_FUNC = c.String(nullable: false),
                        FG_ATIVO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_FUNC)
                .Index(t => t.CD_FUNC, unique: true, name: "Index");
            
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
                .ForeignKey("dbo.CCUSTOS", t => t.ID_CC, cascadeDelete: true)
                .ForeignKey("dbo.CDESPESAS", t => t.ID_CDES, cascadeDelete: true)
                .Index(t => t.ID_CC)
                .Index(t => t.ID_CDES);
            
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
                .ForeignKey("dbo.CCUSTOS", t => t.ID_CC, cascadeDelete: true)
                .ForeignKey("dbo.CDESPESAS", t => t.ID_CDES, cascadeDelete: true)
                .Index(t => t.ID_CC)
                .Index(t => t.ID_CDES);
            
            CreateTable(
                "dbo.USUARIOS",
                c => new
                    {
                        USUARIO_SISTEMA = c.String(nullable: false, maxLength: 128),
                        NOME_USUARIO = c.String(nullable: false),
                        SENHA_USUARIO = c.String(nullable: false),
                        FG_USUARIO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.USUARIO_SISTEMA)
                .Index(t => t.USUARIO_SISTEMA, unique: true, name: "Index");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRESTA_CONTAS", "ID_CDES", "dbo.CDESPESAS");
            DropForeignKey("dbo.PRESTA_CONTAS", "ID_CC", "dbo.CCUSTOS");
            DropForeignKey("dbo.HIST_PRESTA_CONTAS", "ID_CDES", "dbo.CDESPESAS");
            DropForeignKey("dbo.HIST_PRESTA_CONTAS", "ID_CC", "dbo.CCUSTOS");
            DropForeignKey("dbo.FLUXO_CAIXA", "ID_FUNC", "dbo.FUNCIONARIOS");
            DropIndex("dbo.USUARIOS", "Index");
            DropIndex("dbo.PRESTA_CONTAS", new[] { "ID_CDES" });
            DropIndex("dbo.PRESTA_CONTAS", new[] { "ID_CC" });
            DropIndex("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CDES" });
            DropIndex("dbo.HIST_PRESTA_CONTAS", new[] { "ID_CC" });
            DropIndex("dbo.FUNCIONARIOS", "Index");
            DropIndex("dbo.FLUXO_CAIXA", new[] { "ID_FUNC" });
            DropIndex("dbo.CDESPESAS", "Index");
            DropIndex("dbo.CCUSTOS", "Index");
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
