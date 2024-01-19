using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Mappings
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            // Tabela no banco de dados
            ToTable("Contatos");

            // Chave primária
            HasKey(c => c.IdContato);

            // Mapeamento das propriedades
            Property(c => c.IdContato).HasColumnName("IdContato").IsRequired();
            Property(c => c.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(100);
            Property(c => c.DesContato).HasColumnName("DesContato").IsRequired().HasMaxLength(255);
            Property(c => c.TipoContato).HasColumnName("TipoContato").IsRequired();

            // Chave estrangeira para Pessoa
            Property(c => c.PessoaId).HasColumnName("PessoaId").IsRequired();

            // Relacionamento com Pessoa (muitos para um)
            HasRequired(c => c.Pessoa)
                .WithMany(p => p.Contatos)
                .HasForeignKey(c => c.PessoaId);
                 
        }
    }
}