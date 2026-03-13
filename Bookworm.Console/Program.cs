using Bookworm.Domain;
using Bookworm.EFCore;
using Bookworm.EFCore.Context;


using (AppDbContext context = new AppDbContext())
{
    Console.WriteLine("Criando Banco...");
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
    Console.WriteLine("Banco Criado.");
}