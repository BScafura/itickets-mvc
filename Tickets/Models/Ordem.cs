namespace Tickets.Models
{
    public class Ordem
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? UserId { get; set; }

        public ICollection<OrdemItem> OrdemItems { get; set; }  
    }
}
