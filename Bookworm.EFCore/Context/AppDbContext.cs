using Bookworm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Bookworm.EFCore.Context;

public class AppDbContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Editora> Editoras { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Livro>(entity =>
        {

            entity.Property(n => n.Nome)
                  .IsUnicode(false)
                  .HasMaxLength(250)
                  .IsRequired();

            entity.Property(n => n.Preco)
                  .IsRequired();

        });

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.Property(n => n.Nome)
                  .IsUnicode(false)
                  .HasMaxLength(150)
                  .IsRequired();
        });
    }
}
