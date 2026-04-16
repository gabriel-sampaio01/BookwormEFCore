namespace Bookworm.Domain.Entities;
public class Cliente
{
    public int CLienteID { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataCadastro { get; set; }

    public ICollection<Pedido> Pedidos { get; set; }
}

