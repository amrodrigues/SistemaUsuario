using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            // Tabela no banco de dados
            ToTable("Enderecos");

            // Chave primária
            HasKey(e => e.IdEndereco);

            // Mapeamento das propriedades
            Property(e => e.IdEndereco).HasColumnName("IdEndereco").IsRequired();
            Property(e => e.Logradouro).HasColumnName("Logradouro").IsRequired().HasMaxLength(255);
            Property(e => e.Numero).HasColumnName("Numero").IsRequired().HasMaxLength(10);
            Property(e => e.Cep).HasColumnName("Cep").IsRequired();
            Property(e => e.Complemento).HasColumnName("Complemento").HasMaxLength(100);
            Property(e => e.Cidade).HasColumnName("Cidade").IsRequired().HasMaxLength(100);
            Property(e => e.Estado).HasColumnName("Estado").IsRequired().HasMaxLength(50);

            // Relacionamento com Pessoa (muitos para um)
            HasRequired(e => e.Pessoa)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(e => e.PessoaId);
               
        }
    }
}
