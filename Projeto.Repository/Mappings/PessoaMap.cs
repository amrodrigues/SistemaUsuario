using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Repository.Mappings
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");
            // Chave primária
            HasKey(p => p.IdPessoa);

            // Mapeamento das propriedades
            Property(p => p.IdPessoa).HasColumnName("IdPessoa").IsRequired();
            Property(p => p.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(100);
            Property(p => p.Sobrenome).HasColumnName("Sobrenome").IsRequired().HasMaxLength(100);
            Property(p => p.Email).HasColumnName("Email").IsRequired().HasMaxLength(100);
            Property(p => p.DataNascimento).HasColumnName("DataNascimento").IsRequired();
            Property(p => p.CPF).HasColumnName("CPF").IsRequired().HasMaxLength(14);
            Property(p => p.RG).HasColumnName("RG").IsRequired().HasMaxLength(20);

            // Relacionamento com Contatos (um para muitos)
            HasMany(p => p.Contatos)
                .WithRequired(c => c.Pessoa)
                .HasForeignKey(c => c.PessoaId);


            // Relacionamento com Enderecos (um para muitos)
            HasMany(p => p.Enderecos)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.PessoaId);
                
        }
    }

}