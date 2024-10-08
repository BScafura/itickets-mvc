namespace Tickets.Models
{
    public class Elenco
    {
        public int FilmeId { get; set; }
        public virtual Filme? Filme { get; set; }
        public int AtorId { get; set;}
        public virtual Ator? Ator { get; set; }
    }
}
