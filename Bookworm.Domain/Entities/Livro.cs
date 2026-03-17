using System.ComponentModel.DataAnnotations;

namespace Bookworm.Domain.Entities;

public class Livro
{
    public int LivroId { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public DateTime DtPublicacao { get; set; }
    public int Estoque { get; set; }

    public int EditoraId { get; set; } // Chave Estrangeira

    public ICollection<Autor> Autores { get; set; } // Relacao N:N
    public ICollection<Categoria> Categorias { get; set; } // N:N 
}
