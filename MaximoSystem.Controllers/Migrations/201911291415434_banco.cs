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
            DropTable("dbo.USUARIOS");
            DropTable("dbo.FUNCIONARIOS");
            DropTable("dbo.CDESPESAS");
            DropTable("dbo.CCUSTOS");
        }
    }
}
