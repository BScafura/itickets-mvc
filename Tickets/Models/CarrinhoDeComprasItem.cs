namespace Tickets.Models
{
    public class CarrinhoDeComprasItem
    {
        public int Id { get; set; }

        public Filme? Filme { get; set; }

        public int Quantidade {  get; set; }    
        public string? CarrinhoDeComprasId {  get; set; }

    }
}
