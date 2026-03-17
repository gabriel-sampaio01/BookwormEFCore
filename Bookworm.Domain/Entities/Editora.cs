namespace Bookworm.Domain.Entities;

public class Editora
{
    public int EditoraID { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string Pais { get; set; }

    public ICollection<Livro> Livros { get; set; } // Relacao 1:N
}
