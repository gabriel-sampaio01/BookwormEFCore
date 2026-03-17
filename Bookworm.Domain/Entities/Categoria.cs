namespace Bookworm.Domain.Entities;
public class Categoria
{
    public int CategoriaID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public ICollection<Livro> Livros { get; set; } // N:N 
}
