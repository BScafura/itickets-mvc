namespace Tickets.Models
{
    public class OrdemItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        
        public double Preco { get; set; }

        public int FilmeId { get; set;}

        public int OrdemId { get; set;}

        public virtual Filme? Filme { get; set; }

        public virtual Ordem? Price { get;}
    }
}
