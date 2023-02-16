using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ManutencaoPlano.Models;

namespace ManutencaoPlano.Data
{
    public partial class planodiarioContext : DbContext
    {
        public planodiarioContext()
        {
        }

        public planodiarioContext(DbContextOptions<planodiarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FtAbateQuarteioHabilitacao> FtAbateQuarteioHabilitacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=planodiario;User Id=postgres;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FtAbateQuarteioHabilitacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ft_abate_quarteio_habilitacao", "fato");

                entity.Property(e => e.Cbd)
                    .HasColumnName("cbd")
                    .HasMaxLength(50);

                entity.Property(e => e.Dmovimento)
                    .HasColumnName("dmovimento")
                    .HasColumnType("date");

                entity.Property(e => e.Isequencial).HasColumnName("isequencial");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
