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
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(u => u.IdUsuario);

            Property(u => u.IdUsuario)
                    .HasColumnName("IdUsuario")
                    .IsRequired();

            Property(u => u.Username)
                    .HasColumnName("Nome")
                    .HasMaxLength(50)
                    .IsRequired();

            Property(u => u.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                        new IndexAnnotation(new IndexAttribute("IX_Email")
                        { IsUnique = true }));
           
            Property(u => u.Telefone)
                 .HasColumnName("Telefone")
                 .HasMaxLength(50)
                 .IsRequired();

            Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(50)
                .IsRequired();

            Property(u => u.Imagem)
                    .HasColumnName("Imagem")
                    .IsRequired();
        }
    }
}
