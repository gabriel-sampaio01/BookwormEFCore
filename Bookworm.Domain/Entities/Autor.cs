namespace Bookworm.Domain.Entities;

public class Autor
{
    public int AutorID { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Nacionalidade { get; set; }

    public ICollection<Livro> Livros { get; set; } // Relacao N:N
}
