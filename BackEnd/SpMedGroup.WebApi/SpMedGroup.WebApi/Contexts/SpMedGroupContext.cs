using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpMedGroup.WebApi.Domains
{
    public partial class SpMedGroupContext : DbContext
    {
        public SpMedGroupContext()
        {
        }

        public SpMedGroupContext(DbContextOptions<SpMedGroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinica> Clinica { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Especialidade> Especialidade { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<Prontuario> Prontuario { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PKIN6P4\\MYDATABASE; Initial Catalog=SpMedGroup; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.HasKey(e => e.IdClinica);

                entity.HasIndex(e => e.NomeClinica)
                    .HasName("UQ__Clinica__5D092ACE53E653C9")
                    .IsUnique();

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomeClinica)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasKey(e => e.IdConsulta);

                entity.Property(e => e.DataConsulta).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consulta__IdMedi__4F7CD00D");

                entity.HasOne(d => d.IdProntuarioNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdProntuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consulta__IdPron__4E88ABD4");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.IdEndereco);

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdClinica)
                    .HasConstraintName("FK__Endereco__IdClin__52593CB8");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Endereco__IdUsua__534D60F1");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade);

                entity.HasIndex(e => e.NomeEspecialidade)
                    .HasName("UQ__Especial__D6E5EBAE8D1D3D8F")
                    .IsUnique();

                entity.Property(e => e.NomeEspecialidade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.HasIndex(e => e.Crm)
                    .HasName("UQ__Medico__C1F887FFA30A8F66")
                    .IsUnique();

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasColumnName("CRM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.Medico)
                    .HasForeignKey(d => d.IdClinica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico__IdClinic__47DBAE45");

                entity.HasOne(d => d.IdEspecialidadeNavigation)
                    .WithMany(p => p.Medico)
                    .HasForeignKey(d => d.IdEspecialidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico__IdEspeci__45F365D3");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Medico)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico__IdUsuari__46E78A0C");
            });

            modelBuilder.Entity<Prontuario>(entity =>
            {
                entity.HasKey(e => e.IdProntuario);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.Prontuario)
                    .HasForeignKey(d => d.IdClinica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prontuari__IdCli__4AB81AF0");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Prontuario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prontuari__IdUsu__4BAC3F29");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.Property(e => e.TituloTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.HasIndex(e => e.Cpf)
                    .HasName("UQ__Usuario__C1F8973158B350CA")
                    .IsUnique();

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Usuario__A9D10534EFD4F193")
                    .IsUnique();

                entity.HasIndex(e => e.Rg)
                    .HasName("UQ__Usuario__321537C8E3F07B1F")
                    .IsUnique();

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataNasc).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__IdTipoU__4222D4EF");
            });
        }
    }
}
