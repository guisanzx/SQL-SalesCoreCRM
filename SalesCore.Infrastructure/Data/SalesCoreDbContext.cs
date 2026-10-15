using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;

namespace SalesCore.Infrastructure.Data;

public class SalesCoreDbContext : DbContext
{
    public SalesCoreDbContext(DbContextOptions<SalesCoreDbContext> options) : base(options) { }

    public DbSet<Empresa> Empresas => Set<Empresa>();
    public DbSet<Contato> Contatos => Set<Contato>();
    public DbSet<Oportunidade> Oportunidades => Set<Oportunidade>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Empresa>(empresa =>
        {
            empresa.ToTable("tbEmpresa", "dbo");
            empresa.HasKey(e => e.cnpj);
            empresa.Property(e => e.cnpj).HasColumnType("char(11)");
            empresa.Property(e => e.razaoSocial).HasColumnType("varchar(100)");
            empresa.Property(e => e.nomeFantasia).HasColumnType("varchar(100)");
            empresa.Property(e => e.email).HasColumnType("varchar(100)");
            empresa.Property(e => e.telefone).HasColumnType("varchar(20)");
        });

        modelBuilder.Entity<Contato>(contato =>
        {
            contato.ToTable("tbContato", "dbo");
            contato.HasKey(c => c.idContato);
            contato.Property(c => c.idContato).UseIdentityColumn();
            contato.Property(c => c.nome).HasColumnType("varchar(50)");
            contato.Property(c => c.email).HasColumnType("varchar(50)");
            contato.Property(c => c.telefone).HasColumnType("varchar(20)");
            contato.Property(c => c.cargo).HasColumnType("varchar(20)");
            contato.Property(c => c.cnpj).HasColumnType("char(11)");
            contato.HasOne<Empresa>().WithMany().HasForeignKey(c => c.cnpj).OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Oportunidade>(oportunidade =>
        {
            oportunidade.ToTable("tbOportunidade", "dbo");
            oportunidade.HasKey(o => o.idOportunidade);
            oportunidade.Property(o => o.idOportunidade).ValueGeneratedNever();
            oportunidade.Property(o => o.titulo).HasColumnType("varchar(100)");
            oportunidade.Property(o => o.descricao).HasColumnType("varchar(150)");
            oportunidade.Property(o => o.valorEstimado).HasColumnType("nchar(14)");
            oportunidade.Property(o => o.dtAbertura).HasColumnType("date");
            oportunidade.Property(o => o.dtPrevisaoFechamento).HasColumnType("date");
            oportunidade.Property(o => o.cnpj).HasColumnType("char(11)");
            oportunidade.HasOne<Empresa>().WithMany().HasForeignKey(o => o.cnpj).OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.ToTable("tbUsuario", "dbo");
            usuario.HasKey(u => u.idUsuario);
            usuario.Property(u => u.idUsuario).UseIdentityColumn();
            usuario.Property(u => u.nome).HasColumnType("varchar(50)");
            usuario.Property(u => u.email).HasColumnType("varchar(50)");
            usuario.Property(u => u.cargo).HasColumnType("varchar(20)");
        });
    }
}
