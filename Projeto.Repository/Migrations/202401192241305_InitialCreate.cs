namespace Projeto.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        IdContato = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        DesContato = c.String(nullable: false, maxLength: 255),
                        TipoContato = c.Int(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdContato)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Sobrenome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        DataNascimento = c.DateTime(nullable: false),
                        CPF = c.String(nullable: false, maxLength: 14),
                        RG = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.IdPessoa);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 255),
                        Numero = c.String(nullable: false, maxLength: 10),
                        Cep = c.Int(nullable: false),
                        Complemento = c.String(maxLength: 100),
                        Cidade = c.String(nullable: false, maxLength: 100),
                        Estado = c.String(nullable: false, maxLength: 50),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEndereco)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Telefone = c.String(nullable: false, maxLength: 50),
                        Senha = c.String(nullable: false, maxLength: 50),
                        Imagem = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contatos", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Enderecos", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.Usuario", new[] { "Email" });
            DropIndex("dbo.Enderecos", new[] { "PessoaId" });
            DropIndex("dbo.Contatos", new[] { "PessoaId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Contatos");
        }
    }
}
