namespace Menu.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<MenuItem> Itens { get; set; }
        public decimal Total { get; set; }
    }
}
