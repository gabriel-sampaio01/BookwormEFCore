namespace Bookworm.Domain.Entities
{
    public class ItemPedido
    {
        public int ItemPedidoID { get; set; }
        public int PedidoID { get; set; }
        public int LivroID { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnidade { get; set; }

    }
}
