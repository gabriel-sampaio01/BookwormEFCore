using Bookworm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Bookworm.EFCore.Context;

public class AppDbContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Editora> Editoras { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemPedido> ItemPedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(AppConfig.GetConnectionString())
            .LogTo(Console.WriteLine,
            new[] {DbLoggerCategory.Database.Command.Name},
            Microsoft.Extensions.Logging.LogLevel.Information);
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

            entity.Property(n => n.DtPublicacao)
                  .IsRequired();

            entity.Property(n => n.Estoque)
                  .IsRequired();

        });

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.Property(n => n.Nome)
                  .IsUnicode(false)
                  .HasMaxLength(200)
                  .IsRequired();

            entity.Property(d => d.DataNascimento)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(n => n.Nacionalidade)
                  .IsUnicode(false)
                  .IsRequired();
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(n => n.Nome)
                  .IsUnicode(false)
                  .HasMaxLength(200)
                  .IsRequired();

            entity.Property(n => n.Descricao)
                  .IsUnicode(false)
                  .IsRequired();
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(n => n.Nome)
                  .IsUnicode(false)
                  .HasMaxLength(200)
                  .IsRequired();

            entity.Property(n => n.Email)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(n => n.DataCadastro)
                  .IsUnicode(false)
                  .HasMaxLength(200)
                  .IsRequired();
        });

        modelBuilder.Entity<Editora>(entity =>
        {
            entity.Property(n => n.Nome)
                 .IsUnicode(false)
                 .HasMaxLength(200)
                 .IsRequired();

            entity.Property(n => n.CNPJ)
                 .IsUnicode(false)
                 .HasMaxLength(15)
                 .IsRequired();

            entity.Property(n => n.Pais)
                 .IsUnicode(false)
                 .HasMaxLength(100)
                 .IsRequired();

        });

        modelBuilder.Entity<ItemPedido>( entity =>
        {
            entity.Property(n => n.Quantidade)
                 .IsUnicode(false)
                 .IsRequired();

            entity.Property(n => n.PrecoUnidade)
                 .IsUnicode(false)
                 .IsRequired();
        });

        modelBuilder.Entity<Pedido>( entity =>
        {
            entity.Property(n => n.DataPedido)
               .IsUnicode(false)
               .IsRequired();

            entity.Property(n => n.ValorTotal)
               .IsUnicode(false)
               .IsRequired();

            entity.Property(n => n.Status)
               .IsUnicode(false)
               .IsRequired();
        });
    }
}
