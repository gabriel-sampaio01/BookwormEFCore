namespace Bookworm.Domain.Entities
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }

        public int ClienteID { get; set; }

        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
